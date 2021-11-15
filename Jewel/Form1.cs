using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Jewel
{
    public partial class TrainerMain : Form
    {
        // Init global vars
        private Entity jt, selectedEntity;
        private Camera camera;
        private DagNode dagHead;

        // Form constructor
        public TrainerMain()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }
        
        // Init memory.dll
        public static Mem m = new Mem();

        private static uint Rebase(uint adr)
        {
            if (adr < 0x20000000)
            {
                return adr + 0x20000000;
            }
            return adr;
        }

        // Handle form loaded
        private void Form1_Load(object sender, EventArgs e)
        {   
            // Start background worker
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        // Handle form closed
        private void Form2_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        /* Game Classes */

        private class Entity
        {
            private uint pointer;
            private static uint oId = 0x18;
            private static uint oTransform = 0x58;
            private static uint oObjPosition = 0x260;

            public Transform transform;

            // Constructor
            public Entity(uint pEntity)
            {
                this.pointer = Rebase(pEntity);
                this.transform = new Transform(m.ReadUInt((pointer + oTransform).ToString("X")));
            }

            public uint getPointer()
            {
                return pointer;
            }

            public uint id
            {
                get
                {
                    return m.ReadUInt(Rebase(pointer + oId).ToString("X"));
                }
            }
        }

        private class Transform
        {
            private uint pointer;
            private static uint oScaleX = 0x0; // Vector
            private static uint oScaleY = 0x10; // Vector
            private static uint oScaleZ = 0x20; // Vector
            private static uint oRelPosition = 0x30; // Vector
            private static uint oTruePosition = 0x70; // Vector

            public Vector scaleX;
            public Vector scaleY;
            public Vector scaleZ;
            public Vector relPosition;
            public Vector truePosition;

            // Constructor
            public Transform(uint pTransform)
            {
                this.pointer = Rebase(pTransform);
                this.scaleX = new Vector((pointer + oScaleX));
                this.scaleY = new Vector((pointer + oScaleY));
                this.scaleZ = new Vector((pointer + oScaleZ));
                this.relPosition = new Vector((pointer + oRelPosition));
                this.truePosition = new Vector((pointer + oTruePosition));
            }

            public uint getPointer()
            {
                return pointer;
            }

            public void ResetScale()
            {
                this.scaleX.X = this.scaleY.Y = this.scaleZ.Z = 1;
            }
        }

        private class Vector
        {
            private uint pointer;
            private static uint oX = 0x0; // float
            private static uint oY = 0x4; // float
            private static uint oZ = 0x8; // float
            
            // Constructor
            public Vector(uint pVector)
            {
                this.pointer = Rebase(pVector);
            }

            public uint getPointer() { return pointer; }

            public float X
            {
                get
                {
                    return m.ReadFloat((pointer + oX).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oX).ToString("X"), "float", value.ToString());
                }
            }
            public float Y
            {
                get
                {
                    return m.ReadFloat((pointer + oY).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oY).ToString("X"), "float", value.ToString());
                }
            }
            public float Z
            {
                get
                {
                    return m.ReadFloat((pointer + oZ).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oZ).ToString("X"), "float", value.ToString());
                }
            }
            
            public override string ToString()
            {
                return (String.Format("({0}, {1}, {2})", X, Y, Z));
            }
        }

        private class FkxEntry
        {
            private uint pointer;
            private static uint oPoolArray = 0x4; // Entity**
            private static uint oPoolSize = 0x8; // uint
            private static uint oEntityId = 0x10; // uint
            private static uint oName = 0x20; // string

            // Constructor
            public FkxEntry(uint pFkxEntry)
            {
                this.pointer = Rebase(pFkxEntry);
            }

            public uint poolArray
            {
                get
                {
                    return m.ReadUInt((pointer + oPoolArray).ToString("X"));
                }
            }

            public uint poolSize
            {
                get
                {
                    return m.ReadUInt((pointer + oPoolSize).ToString("X"));
                }
            }

            public uint entityId
            {
                get
                {
                    return m.ReadUInt((pointer + oEntityId).ToString("X"));
                }
            }

            public string name
            {
                get
                {
                    return m.ReadString((pointer + oName).ToString("X"));
                }
            }
        }

        private class Camera
        {
            private uint pointer;
            private static uint oFadeDistance = 0x1c; // float
            private static uint oFov = 0x24; // float
            private static uint oZoom = 0x4c; // float
            private static uint oResetFlag = 0x300; // uint
            private static uint oFocus = 0x318; // Entity*

            // Constructor
            public Camera(uint pCamera)
            {
                this.pointer = Rebase(pCamera);
            }

            // Getters/Setters
            public uint getPointer()
            {
                return pointer;
            }

            public float fadeDistance
            {
                get
                {
                    return m.ReadFloat((pointer + oFadeDistance).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oFadeDistance).ToString("X"), "float", value.ToString());
                }
            }
            
            public float fov
            {
                get
                {
                    return m.ReadFloat((pointer + oFov).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oFov).ToString("X"), "float", value.ToString());
                }
            }

            public float zoom
            {
                get
                {
                    return m.ReadFloat((pointer + oZoom).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oZoom).ToString("X"), "float", value.ToString());
                }
            }

            public uint focus
            {
                get
                {
                    return m.ReadUInt((pointer + oFocus).ToString("X"));
                }
                set
                {
                    m.WriteMemory((pointer + oFocus).ToString("X"), "int", value.ToString());
                }
            }

            // Resets the camera
            public void Reset()
            {
                m.WriteMemory((pointer + oResetFlag).ToString("X"), "int", "1");
            }
        }

        private class DagNode
        {
            private uint pointer;
            private static uint oId = 0x18;
            private static uint oState = 0x54;
            private static uint oNumChildren = 0xa0;
            private static uint oChildrenArray = 0xa4;
            private static uint oNumParents = 0x94;
            private static uint oParentsArray = 0x98;
            private static uint oJob = 0x7;
            private static uint oCheckpoint = 0xb8;

            public DagNode(uint pDagNode)
            {
                this.pointer = Rebase(pDagNode);
            }

            public uint getPointer()
            {
                return pointer;
            }

            public uint id
            {
                get
                {
                    return m.ReadUInt((pointer + oId).ToString("X"));
                }
            }

            public uint state
            {
                get
                {
                    return m.ReadUInt((pointer + oState).ToString("X"));
                }
            }

            public List<DagNode> children
            {
                get
                {
                    uint numChildren = m.ReadUInt((pointer + oNumChildren).ToString("X"));
                    List<DagNode> children = new List<DagNode>();

                    for (uint i = 0; i < numChildren; i++)
                    {
                        uint nodePtr = m.ReadUInt(Rebase(m.ReadUInt((pointer + oChildrenArray).ToString("X")) + (0x4 * i)).ToString("X"));
                        children.Add(new DagNode(nodePtr));
                    }
                    return children;
                }
            }
        }


        /* Entities Tab */

        // Populate fkxentries list with all FKX entries in ram
        public async void PopulateFkxTreeView()
        {
            ArrayList fkxEntries = new ArrayList();

            // start progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 10;
            });
            
            // Scan for "FK$X" string AOB
            IEnumerable<long> AoBScanResults = await m.AoBScan(0x20000000, 0x21ffffff, "46 4B 24 58", false, true, false);

            // update progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = AoBScanResults.Count() + 10;
            });

            // Add each found FKX entry to the fkxentries list
            foreach (long result in AoBScanResults)
            {
                FkxEntry fkx = new FkxEntry((uint)(result) - 0x1c);
                fkxEntries.Add(fkx);
            }

            // Prepare tree view for update and clear it
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            // Populate tree view with nodes
            foreach(FkxEntry fkx in fkxEntries)
            {
                // Create node with FKX entry attached
                TreeNode fkxNode = new TreeNode(fkx.name);
                fkxNode.Tag = fkx;

                // Add Fkx node to tree
                treeView1.Nodes.Add(fkxNode);

                // Update progress bar
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value += 1;
                });

                // If this Fkx has none or too many entities, skip populating it's entity nodes
                if (fkx.poolArray == 0x0 || fkx.poolSize > 127)
                {
                    continue;
                }

                // Add Entity nodes as subnodes to Fkx node
                for(uint i = 0; i < fkx.poolSize; i++)
                {
                    // Create entity node
                    uint entityPtr = m.ReadUInt(Rebase(fkx.poolArray + (0x4 * i)).ToString("X"));
                    TreeNode entityNode = new TreeNode(entityPtr.ToString("X"));

                    // Attach entity to node
                    entityNode.Tag = new Entity(entityPtr);

                    // Add node to tree
                    var parent = treeView1.Nodes.OfType<TreeNode>()
                            .FirstOrDefault(node => node.Tag.Equals(fkx));
                    parent.Nodes.Add(entityNode);
                }
            }

            // Sort tree view and re-enable update
            treeView1.Sort();
            treeView1.EndUpdate();

            // Complete progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 100;
            });
        }

        // Handle Entity refresh button click
        private void FkxRefreshBtn_Click(object sender, EventArgs e)
        {
            this.PopulateFkxTreeView();
        }

        // Handle Entity treelist select
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EntityPropsPanelTitle.Invoke((MethodInvoker)delegate
            {
                if (e.Node.Tag is Entity)
                {
                    selectedEntity = e.Node.Tag as Entity;
                }
            });
        }

        // Handle update entity position
        private void positionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedEntity == null) return;

            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            float val = 0;
            if (float.TryParse(text, out val))
            {
                switch (textBox.Tag)
                {
                    case "x":
                        //selectedEntity.transform.relPosition.X = val;
                        break;
                    case "y":
                        //selectedEntity.transform.relPosition.Y = val;
                        break;
                    case "z":
                        //selectedEntity.transform.relPosition.Z = val;
                        break;
                    default:
                        break;
                }
            }
        }

        // Handle copy position values
        private void copyPositionBtn_Click(object sender, EventArgs e)
        {
            // Generate value string from current entity position
            string valueString = String.Format("{0},{1},{2}",
                xPosTextBox.Text, yPosTextBox.Text, zPosTextBox.Text);

            // Copy to clipboard
            Clipboard.SetText(valueString);
        }

        // Handle paste position values
        private void pastePositionBtn_Click(object sender, EventArgs e)
        {
            // Read value string from clipboard
            string valueString = Clipboard.GetText();
            string[] values = valueString.Split(',');

            // Validate value string
            if (values.Count() != 3) return;

            float x, y, z;

            if (float.TryParse(values[0], out x) &&
                float.TryParse(values[1], out y) &&
                float.TryParse(values[2], out z))
            {
                // Set entity position
                (selectedEntity.transform.relPosition.X,
                    selectedEntity.transform.relPosition.Y,
                    selectedEntity.transform.relPosition.Z) = (x, y, z);
            }
        }

        // Handle warp to selected button click
        private void WarpToBtn_Click(object sender, EventArgs e)
        {
            if (jt == null || selectedEntity == null) return;

            jt.transform.relPosition.X = selectedEntity.transform.truePosition.X;
            jt.transform.relPosition.Y = selectedEntity.transform.truePosition.Y;
            jt.transform.relPosition.Z = selectedEntity.transform.truePosition.Z;
        }

        private void SetCamFocusBtn_Click(object sender, EventArgs e)
        {
            if (camera == null || selectedEntity == null) return;

            camera.focus = selectedEntity.getPointer();
        }

        // Handle update entity position
        private void scaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedEntity == null) return;

            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            float val = 0;
            if (float.TryParse(text, out val))
            {
                switch (textBox.Tag)
                {
                    case "x":
                        selectedEntity.transform.scaleX.X = val;
                        break;
                    case "y":
                        selectedEntity.transform.scaleY.Y = val;
                        break;
                    case "z":
                        selectedEntity.transform.scaleZ.Z = val;
                        break;
                    default:
                        break;
                }
            }
        }

        private void entityScale_UpDown(object sender, EventArgs e)
        {
            if (selectedEntity == null || selectedEntity.transform == null) return;

            Button button = sender as Button;

            float inc = 1;
            if ((string)button.Tag == "down")
            {
                inc = -1;
            }

            selectedEntity.transform.scaleX.X += inc;
            selectedEntity.transform.scaleY.Y += inc;
            selectedEntity.transform.scaleZ.Z += inc;
        }


        /* DAG Tab */

        private void refreshDagBtn_Click(object sender, EventArgs e)
        {
            dagHead = new DagNode(m.ReadUInt("203e0b04"));
            ArrayList dagNodes = new ArrayList();
            List<uint> visited = new List<uint>();

            // start progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 10;
            });

            // Prepare tree view for update and clear it
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            // Populate tree view
            PopulateDagChildren(dagHead, visited);

            // Sort tree view and re-enable update
            //treeView1.Sort();
            treeView1.EndUpdate();

            // complete progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 100;
            });
        }

        // Recursively populate the tree view with the given node's children
        private void PopulateDagChildren(DagNode node, List<uint> visited)
        {
            // Create tree node with this dag node attached
            TreeNode treeNode = new TreeNode(node.getPointer().ToString("X"));
            treeNode.Tag = node;

            // Add tree node to tree view
            treeView2.Nodes.Add(treeNode);

            // Mark this node as visited
            visited.Add(node.id);

            // Iterate over node chidren
            foreach (DagNode child in node.children)
            {
                // Populate children ONLY if this child was not already visited
                if (!visited.Contains(child.id)) PopulateDagChildren(child, visited);
            }
        }

        // Handle dagnode treelist select
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DagNode dagNode;
            if (e.Node.Tag is DagNode)
            {
                // Get DagNode from tag of selected tree view item
                dagNode = e.Node.Tag as DagNode;

                // Update tab title with node id
                DagPropsPanelTitle.Invoke((MethodInvoker)delegate
                {
                    DagPropsPanelTitle.Text = dagNode.getPointer().ToString("X");
                });

                // Update node state combo box
                dagNodeStateCombo.Invoke((MethodInvoker)delegate
                {
                    Console.WriteLine(String.Format("State: {0}", dagNode.state));
                    Console.WriteLine(dagNodeStateCombo.Items[3]);
                    dagNodeStateCombo.SelectedIndex = (int)dagNode.state;
                });
            }
        }


        /* Camera Tab */

        // Handle refresh camera button clicked
        private void resetCamBtn_Click(object sender, EventArgs e)
        {
            camera.Reset();
        }

        // Handle Focus on Sly button clicked
        private void camFocusOnJtBtn_Click(object sender, EventArgs e)
        {
            camera.focus = jt.getPointer();
        }

        // Handle render distance change
        private void camFadeDistanceValue_ValueChanged(object sender, EventArgs e)
        {
            camera.fadeDistance = (float)camFadeDistanceValue.Value;
        }

        // Handle FOV change
        private void camFovValue_ValueChanged(object sender, EventArgs e)
        {
            camera.fov = (float)camFovValue.Value;
        }

        // Handle follow distance change
        private void camZoomValue_ValueChanged(object sender, EventArgs e)
        {
            camera.zoom = (float)camZoomValue.Value;
        }

        private void entityScaleResetBtn_Click(object sender, EventArgs e)
        {
            if (selectedEntity == null || selectedEntity.transform == null) return;

            selectedEntity.transform.ResetScale();
        }


        /* Background worker (trainer logic) */

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pID;
            bool isProcOpen = false;

            while (true)
            {
                /* Check if process is missing/closed */
                pID = m.GetProcIdFromName("pcsx2");
                if (pID == 0 && isProcOpen)
                {
                    isProcOpen = false;
                }

                // if process not open, try to open it
                if (!isProcOpen)
                {
                    // check if pcsx2 process ID found
                    if (pID > 0)
                    {
                        // if so, open the process
                        isProcOpen = m.OpenProcess(pID);

                        ProcIdLabel.Invoke((MethodInvoker)delegate
                        {
                            ProcIdLabel.Text = pID.ToString();
                            ProcIdLabel.ForeColor = Color.DarkGreen;
                        });
                    }
                    else
                    {
                        // if not, set proc id label to "None"
                        ProcIdLabel.Invoke((MethodInvoker)delegate
                        {
                            ProcIdLabel.Text = "Not Attached";
                            ProcIdLabel.ForeColor = Color.DarkRed;
                        });

                        // process not open, so skip the trainer logic
                        continue;
                    }
                }

                /* Process is open, so let's do this */
                if (jt == null)
                {
                    jt = new Entity(m.ReadUInt("202e1e40"));
                }

                // Read camera values
                if (camera == null)
                {
                    camera = new Camera(0x202ddf40);
                }
                else
                {
                    // Write camera render distance to ui
                    camFadeDistanceValue.Invoke((MethodInvoker)delegate
                    {
                        camFadeDistanceValue.Value = (decimal)camera.fadeDistance;
                    });
                    // Write camera fov to ui
                    camFovValue.Invoke((MethodInvoker)delegate
                    {
                        camFovValue.Value = (decimal)camera.fov;
                    });
                    // Write camera follow distance to ui
                    camZoomValue.Invoke((MethodInvoker)delegate
                    {
                        camZoomValue.Value = (decimal)camera.zoom;
                    });
                }

                // Check if there is an entity selected
                if (selectedEntity != null)
                {
                    // Write entity pointer to UI
                    EntityPropsPanelTitle.Invoke((MethodInvoker)delegate
                    {
                        EntityPropsPanelTitle.Text = selectedEntity.getPointer().ToString("X");
                    });

                    // Check if entity has a Transform
                    if (selectedEntity.transform != null)
                    {
                        // Write entity position to UI
                        xPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!xPosTextBox.Focused)
                            {
                                xPosTextBox.Text = selectedEntity.transform.truePosition.X.ToString();
                            }
                        });
                        yPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!yPosTextBox.Focused)
                            {
                                yPosTextBox.Text = selectedEntity.transform.truePosition.Y.ToString();
                            }
                        });
                        zPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!zPosTextBox.Focused)
                            {
                                zPosTextBox.Text = selectedEntity.transform.truePosition.Z.ToString();
                            }
                        });

                        // Write entity scale to UI
                        xPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!xScaleTextBox.Focused)
                            {
                                xScaleTextBox.Text = selectedEntity.transform.scaleX.X.ToString();
                            }
                        });
                        yPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!yScaleTextBox.Focused)
                            {
                                yScaleTextBox.Text = selectedEntity.transform.scaleY.Y.ToString();
                            }
                        });
                        zPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            if (!zScaleTextBox.Focused)
                            {
                                zScaleTextBox.Text = selectedEntity.transform.scaleZ.Z.ToString();
                            }
                        });
                    }
                }
            }
        }
    }
}

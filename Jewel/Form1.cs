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
            private static uint oScaleY = 0x4; // Vector
            private static uint oScaleZ = 0x8; // Vector
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
                Console.WriteLine((pointer + oResetFlag).ToString("X"));
                m.WriteMemory((pointer + oResetFlag).ToString("X"), "int", "1");
            }
        }


        /* Entities Tab */

        // Populate fkxentries list with all FKX entries in ram
        public async void FindFkxEntries()
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
                if (fkx.name == "jt")
                {
                    Console.WriteLine(String.Format("On {0}", fkx.name));
                    Console.WriteLine(fkx.poolSize);
                    Console.WriteLine(fkx.poolArray.ToString("X"));
                }

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
                    Console.WriteLine(entityNode);

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

            // Reset progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
            });
        }

        // Handle refresh button click
        private void FkxRefreshBtn_Click(object sender, EventArgs e)
        {
            this.FindFkxEntries();
        }

        // Hangle treelist select
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EntityIdLabel.Invoke((MethodInvoker)delegate
            {
                if (e.Node.Tag is Entity)
                {
                    selectedEntity = e.Node.Tag as Entity;
                }
            });
        }

        // Handle warp to selected button click
        private void WarpToBtn_Click(object sender, EventArgs e)
        {
            jt.transform.relPosition.X = selectedEntity.transform.truePosition.X;
            jt.transform.relPosition.Y = selectedEntity.transform.truePosition.Y;
            jt.transform.relPosition.Z = selectedEntity.transform.truePosition.Z;
        }

        private void SetCamFocusBtn_Click(object sender, EventArgs e)
        {
            camera.focus = selectedEntity.getPointer();
        }


        /* Camera Tab */

        // Handle refresh camera button clicked
        private void resetCamBtn_Click(object sender, EventArgs e)
        {
            camera.Reset();
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


        /* Background worker (trainer logic) */

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pID;
            bool isProcOpen = false;

            while (true)
            {
                // check if process is missing/closed
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
                            ProcIdLabel.Text = "None";
                            ProcIdLabel.ForeColor = Color.DarkRed;
                        });

                        // process not open, so skip the trainer logic
                        continue;
                    }
                }

                // process is open, so let's do this
                
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
                    // Update render distance value
                    camFadeDistanceValue.Invoke((MethodInvoker)delegate
                    {
                        camFadeDistanceValue.Value = (decimal)camera.fadeDistance;
                    });
                    // Update fov value
                    camFovValue.Invoke((MethodInvoker)delegate
                    {
                        camFovValue.Value = (decimal)camera.fov;
                    });
                    // Update follow distance value
                    camZoomValue.Invoke((MethodInvoker)delegate
                    {
                        camZoomValue.Value = (decimal)camera.zoom;
                    });
                }

                // write selected entity position to ui
                if (selectedEntity != null)
                {
                    EntityIdLabel.Invoke((MethodInvoker)delegate
                    {
                        EntityIdLabel.Text = selectedEntity.getPointer().ToString("X");
                    });
                    if (selectedEntity.transform != null)
                    {
                        xPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            xPosTextBox.Text = selectedEntity.transform.truePosition.X.ToString();
                        });
                        yPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            yPosTextBox.Text = selectedEntity.transform.truePosition.Y.ToString();
                        });
                        zPosTextBox.Invoke((MethodInvoker)delegate
                        {
                            zPosTextBox.Text = selectedEntity.transform.truePosition.Z.ToString();
                        });
                    }
                }
            }
        }
    }
}

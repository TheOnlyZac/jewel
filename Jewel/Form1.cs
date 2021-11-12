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
        // initialize global vars
        private Entity jt, selectedEntity;
        private ArrayList fkxEntries = new ArrayList();
        private ArrayList allEntities = new ArrayList();

        // Constructor
        public TrainerMain()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }
        
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

        // Define game classes
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

            public uint getPointer() { return pointer; }

            public uint id
            {
                get { return m.ReadUInt(Rebase(pointer + oId).ToString("X")); }
            }
        }

        private class Transform
        {
            private uint pointer;
            private static uint oScaleX = 0x0;
            private static uint oScaleY = 0x4;
            private static uint oScaleZ = 0x8;
            private static uint oRelPosition = 0x30;
            private static uint oTruePosition = 0x70;

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

            public uint getPointer() { return pointer; }
        }

        private class Vector
        {
            private uint pointer;
            private static uint oX = 0x0;
            private static uint oY = 0x4;
            private static uint oZ = 0x8;
            
            // Constructor
            public Vector(uint pVector)
            {
                this.pointer = Rebase(pVector);
            }

            public uint getPointer() { return pointer; }

            public float X
            {
                get { return m.ReadFloat((pointer + oX).ToString("X")); }
                set { m.WriteMemory((pointer + oX).ToString("X"), "float", value.ToString()); }
            }
            public float Y
            {
                get { return m.ReadFloat((pointer + oY).ToString("X")); }
                set { m.WriteMemory((pointer + oY).ToString("X"), "float", value.ToString()); }
            }
            public float Z
            {
                get { return m.ReadFloat((pointer + oZ).ToString("X")); }
                set { m.WriteMemory((pointer + oZ).ToString("X"), "float", value.ToString()); }
            }
            
            public override string ToString()
            {
                return (String.Format("({0}, {1}, {2})", X, Y, Z));
            }
        }

        private class FkxEntry
        {
            private static uint oPoolArray = 0x4;
            private static uint oPoolSize = 0x8;
            private static uint oEntityId = 0x10;
            private static uint oName = 0x20;

            public uint pointer;

            // Constructor
            public FkxEntry(uint pFkxEntry)
            {
                this.pointer = Rebase(pFkxEntry);
            }

            public uint poolArray
            {
                get { return m.ReadUInt((pointer + oPoolArray).ToString("X")); }
            }

            public uint poolSize
            {
                get { return m.ReadUInt((pointer + oPoolSize).ToString("X")); }
            }

            public uint entityId
            {
                get { return m.ReadUInt((pointer + oEntityId).ToString("X")); }
            }

            public string name
            {
                get { return m.ReadString((pointer + oName).ToString("X")); }
            }
        }

        // Populate fkxentries list with all FKX entries in ram
        public async void FindFkxEntries()
        {
            // start progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 10;
            });

            fkxEntries.Clear();
            IEnumerable<long> AoBScanResults = await m.AoBScan(0x20000000, 0x21ffffff, "46 4B 24 58", false, true, false);
            int numResults = AoBScanResults.Count();

            // update progress bar
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = numResults+10;
            });

            // Add each found FKX entry to the fkxentries list
            foreach (long result in AoBScanResults)
            {
                FkxEntry fkx = new FkxEntry((uint)(result) - 0x1c);
                fkxEntries.Add(fkx);
            }

            // Set wait cursor and pause treeView update
            Cursor.Current = Cursors.WaitCursor;
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach(FkxEntry fkx in fkxEntries)
            {
                Console.WriteLine(String.Format("On {0}", fkx.name));

                // Create node with FKX entry attached
                TreeNode fkxNode = new TreeNode(fkx.name);
                fkxNode.Tag = fkx;

                // Add node to tree
                treeView1.Nodes.Add(fkxNode);

                // If this entity is fishy, don't populate it's entity nodes
                if (fkx.poolArray == 0x0 || fkx.poolSize > 127)
                {
                    Console.WriteLine(String.Format("Skipping {0}", fkx.name));
                    continue;
                }
                // Add Entity nodes as subnodes to FKX entries
                for(uint i = 0; i < fkx.poolSize; i++)
                {
                    // Create entity node
                    uint entityPtr = m.ReadUInt(Rebase(fkx.poolArray + (0x4 * i)).ToString("X"));
                    TreeNode entityNode = new TreeNode(entityPtr.ToString("X"));

                    // Attach entity to node
                    entityNode.Tag = new Entity(entityPtr);

                    // Add node to tree
                    treeView1.Nodes[fkxEntries.IndexOf(fkx)].Nodes.Add(entityNode);
                }

                // Update progress bar
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value += 1;
                });
            }

            // Reset cursor and re-enable treeView update
            treeView1.Sort();
            Cursor.Current = Cursors.Default;
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
        private void WarpToSelected_Click(object sender, EventArgs e)
        {
            jt.transform.relPosition.X = selectedEntity.transform.truePosition.X;
            jt.transform.relPosition.Y = selectedEntity.transform.truePosition.Y;
            jt.transform.relPosition.Z = selectedEntity.transform.truePosition.Z;
        }

        // Background worker (trainer logic)
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

                // write selected entity position to ui
                if (selectedEntity != null)
                {
                    EntityIdLabel.Invoke((MethodInvoker)delegate
                    {
                        EntityIdLabel.Text = selectedEntity.getPointer().ToString("X");
                    });
                    if (selectedEntity.transform != null)
                    {
                        XPosLabel.Invoke((MethodInvoker)delegate
                        {
                            XPosLabel.Text = selectedEntity.transform.truePosition.X.ToString();
                        });
                        YPosLabel.Invoke((MethodInvoker)delegate
                        {
                            YPosLabel.Text = selectedEntity.transform.truePosition.Y.ToString();
                        });
                        ZPosLabel.Invoke((MethodInvoker)delegate
                        {
                            ZPosLabel.Text = selectedEntity.transform.truePosition.Z.ToString();
                        });
                    }
                }
            }
        }
    }
}

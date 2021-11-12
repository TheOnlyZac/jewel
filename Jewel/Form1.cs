using System;
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
    public partial class Form1 : Form
    {
        // initialize global vars
        private Entity jt, selectedEntity;
        private BindingList<FkxEntry> fkxEntries = new BindingList<FkxEntry>();
        private BindingList<Entity> allEntities = new BindingList<Entity>();

        // Constructor
        public Form1()
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
            private static uint oPosition = 0x30;

            public Vector scaleX;
            public Vector scaleY;
            public Vector scaleZ;
            public Vector position;

            // Constructor
            public Transform(uint pTransform)
            {
                this.pointer = Rebase(pTransform);
                this.scaleX = new Vector((pointer + oScaleX));
                this.scaleY = new Vector((pointer + oScaleY));
                this.scaleZ = new Vector((pointer + oScaleZ));
                this.position = new Vector((pointer + oPosition));
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
            fkxEntries.Clear();
            IEnumerable<long> AoBScanResults = await m.AoBScan("46 4B 24 58", false, true, false);

            Console.WriteLine(AoBScanResults.Count());
            // Add each found FKX entry to the fkxentries list
            foreach (long result in AoBScanResults)
            {
                FkxEntry fkx = new FkxEntry((uint)(result) - 0x1c);
                fkxEntries.Add(fkx);
            }
        }

        // Handle change selected FKX
        private void FkxListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = FkxListbox.SelectedIndex;
            allEntities.Clear();
            FkxEntry fkx = (FkxEntry)FkxListbox.SelectedItem;
            for (uint i = 0; i < fkx.poolSize; i++)
            {
                uint entityPtr = Rebase(fkx.poolArray + (0x4 * i));
                allEntities.Add(new Entity(m.ReadUInt(entityPtr.ToString("X"))));
            }
        }

        // Handle change selected Entity
        private void EntityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEntity = (Entity)EntityListBox.SelectedItem;
        }

        // Handle refresh button click
        private void FkxRefreshBtn_Click(object sender, EventArgs e)
        {
            this.FindFkxEntries();
            // Update FK$X listbox data source
            FkxListbox.Invoke((MethodInvoker)delegate
            {
                FkxListbox.DataSource = fkxEntries;
                FkxListbox.DisplayMember = "name";
            });

            // Update entities listbox data source
            EntityListBox.Invoke((MethodInvoker)delegate
            {
                EntityListBox.DataSource = allEntities;
                EntityListBox.DisplayMember = "id";
            });
        }

        // Handle warp to selected button click
        private void WarpToSelected_Click(object sender, EventArgs e)
        {
            jt.transform.position.X = selectedEntity.transform.position.Z;
            jt.transform.position.Y = selectedEntity.transform.position.Y;
            jt.transform.position.Z = selectedEntity.transform.position.Z;
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
                    XPosLabel.Invoke((MethodInvoker)delegate
                    {
                        XPosLabel.Text = selectedEntity.transform.position.X.ToString();
                    });
                    YPosLabel.Invoke((MethodInvoker)delegate
                    {
                        YPosLabel.Text = selectedEntity.transform.position.Y.ToString();
                    });
                    ZPosLabel.Invoke((MethodInvoker)delegate
                    {
                        ZPosLabel.Text = selectedEntity.transform.position.Z.ToString();
                    });

                }
            }
        }
    }
}

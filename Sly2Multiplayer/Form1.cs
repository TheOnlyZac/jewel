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

namespace Sly2Multiplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        public static Mem m = new Mem();

        // Handle form loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load");
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

        // Generate game classes
        private class Entity
        {
            public Transform transform;

            public Entity(uint pEntity)
            {
                this.transform = new Transform(m.ReadUInt((pEntity + 0x20000058).ToString("X")));
            }
        }

        private class Transform
        {
            public Vector position;

            public Transform(uint pTransform)
            {
                this.position = new Vector(pTransform + 0x30);
            }
        }

        private class Vector
        {
            private uint pX, pY, pZ;

            public Vector(uint pVector)
            {
                Console.WriteLine(pVector.ToString("X"));
                (this.pX, this.pY, this.pZ) =
                    (pVector + 0x20000000, pVector + 0x20000004, pVector + 0x20000008);

                Console.WriteLine(this.pX.ToString("X"));
            }

            public float x
            {
                get { return m.ReadFloat(pX.ToString("X")); }
                set { m.WriteMemory(pX.ToString("X"), "float", value.ToString()); }
            }
            public float y
            {
                get { return m.ReadFloat(pY.ToString("X")); }
                set { m.WriteMemory(pY.ToString("X"), "float", value.ToString()); }
            }
            public float z
            {
                get { return m.ReadFloat(pZ.ToString("X")); }
                set { m.WriteMemory(pZ.ToString("X"), "float", value.ToString()); }
            }
        }

        // initialize entity pointers
        private Entity jt, bentley;

        private  void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("bgworker started");
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
                if (bentley == null)
                {
                    bentley = new Entity(m.ReadUInt("202dd5bc"));
                }

                // read sly's position vector
                XPosLabel.Invoke((MethodInvoker)delegate
                {
                    XPosLabel.Text = jt.transform.position.x.ToString();
                });
                YPosLabel.Invoke((MethodInvoker)delegate
                {
                    YPosLabel.Text = jt.transform.position.y.ToString();
                });
                ZPosLabel.Invoke((MethodInvoker)delegate
                {
                    ZPosLabel.Text = jt.transform.position.z.ToString();
                });
            }
        }

        /* public partial class Vector
        {
            public float x, y, z;

            public Vector()
            {
                (this.x, this.y, this.z) = (0, 0, 0);
            }

            public Vector(float x, float y, float z)
            {
                (this.x, this.y, this.z) = (x, y, z);
            }

            public override string ToString()
            {
                return (String.Format("({0}, {1}, {2})", this.x, this.y, this.z));
            }
        } */
    }
}

namespace Jewel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcIdTitle = new System.Windows.Forms.Label();
            this.ProcIdLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.XPosTitle = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.XPosLabel = new System.Windows.Forms.Label();
            this.YPosTitle = new System.Windows.Forms.Label();
            this.YPosLabel = new System.Windows.Forms.Label();
            this.ZPosTitle = new System.Windows.Forms.Label();
            this.ZPosLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcIdTitle
            // 
            this.ProcIdTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcIdTitle.AutoSize = true;
            this.ProcIdTitle.Location = new System.Drawing.Point(8, 4);
            this.ProcIdTitle.Name = "ProcIdTitle";
            this.ProcIdTitle.Size = new System.Drawing.Size(62, 13);
            this.ProcIdTitle.TabIndex = 0;
            this.ProcIdTitle.Text = "Process ID:";
            // 
            // ProcIdLabel
            // 
            this.ProcIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcIdLabel.AutoSize = true;
            this.ProcIdLabel.Location = new System.Drawing.Point(67, 4);
            this.ProcIdLabel.Name = "ProcIdLabel";
            this.ProcIdLabel.Size = new System.Drawing.Size(46, 13);
            this.ProcIdLabel.TabIndex = 1;
            this.ProcIdLabel.Text = "$ProcID";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // XPosTitle
            // 
            this.XPosTitle.AutoSize = true;
            this.XPosTitle.Location = new System.Drawing.Point(155, 104);
            this.XPosTitle.Name = "XPosTitle";
            this.XPosTitle.Size = new System.Drawing.Size(34, 13);
            this.XPosTitle.TabIndex = 3;
            this.XPosTitle.Text = "Sly X:";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FooterPanel.Controls.Add(this.ProcIdLabel);
            this.FooterPanel.Controls.Add(this.ProcIdTitle);
            this.FooterPanel.Location = new System.Drawing.Point(-3, 274);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(426, 20);
            this.FooterPanel.TabIndex = 4;
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.Location = new System.Drawing.Point(195, 104);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(35, 13);
            this.XPosLabel.TabIndex = 5;
            this.XPosLabel.Text = "label1";
            // 
            // YPosTitle
            // 
            this.YPosTitle.AutoSize = true;
            this.YPosTitle.Location = new System.Drawing.Point(155, 117);
            this.YPosTitle.Name = "YPosTitle";
            this.YPosTitle.Size = new System.Drawing.Size(34, 13);
            this.YPosTitle.TabIndex = 3;
            this.YPosTitle.Text = "Sly Y:";
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.Location = new System.Drawing.Point(195, 117);
            this.YPosLabel.Name = "YPosLabel";
            this.YPosLabel.Size = new System.Drawing.Size(35, 13);
            this.YPosLabel.TabIndex = 5;
            this.YPosLabel.Text = "label1";
            // 
            // ZPosTitle
            // 
            this.ZPosTitle.AutoSize = true;
            this.ZPosTitle.Location = new System.Drawing.Point(155, 130);
            this.ZPosTitle.Name = "ZPosTitle";
            this.ZPosTitle.Size = new System.Drawing.Size(34, 13);
            this.ZPosTitle.TabIndex = 3;
            this.ZPosTitle.Text = "Sly Z:";
            // 
            // ZPosLabel
            // 
            this.ZPosLabel.AutoSize = true;
            this.ZPosLabel.Location = new System.Drawing.Point(195, 130);
            this.ZPosLabel.Name = "ZPosLabel";
            this.ZPosLabel.Size = new System.Drawing.Size(35, 13);
            this.ZPosLabel.TabIndex = 5;
            this.ZPosLabel.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 264);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 294);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ZPosLabel);
            this.Controls.Add(this.ZPosTitle);
            this.Controls.Add(this.YPosLabel);
            this.Controls.Add(this.YPosTitle);
            this.Controls.Add(this.XPosLabel);
            this.Controls.Add(this.XPosTitle);
            this.Controls.Add(this.FooterPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcIdTitle;
        private System.Windows.Forms.Label ProcIdLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label XPosTitle;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label XPosLabel;
        private System.Windows.Forms.Label YPosTitle;
        private System.Windows.Forms.Label YPosLabel;
        private System.Windows.Forms.Label ZPosTitle;
        private System.Windows.Forms.Label ZPosLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}


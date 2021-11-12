namespace Jewel
{
    partial class TrainerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerMain));
            this.ProcIdTitle = new System.Windows.Forms.Label();
            this.ProcIdLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.XPosTitle = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.XPosLabel = new System.Windows.Forms.Label();
            this.YPosTitle = new System.Windows.Forms.Label();
            this.YPosLabel = new System.Windows.Forms.Label();
            this.ZPosTitle = new System.Windows.Forms.Label();
            this.ZPosLabel = new System.Windows.Forms.Label();
            this.FkxRefreshBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EntitiesTitle = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SetCamFocusBtn = new System.Windows.Forms.Button();
            this.WarpToBtn = new System.Windows.Forms.Button();
            this.EntityIdLabel = new System.Windows.Forms.Label();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcIdTitle
            // 
            this.ProcIdTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcIdTitle.AutoSize = true;
            this.ProcIdTitle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ProcIdTitle.Location = new System.Drawing.Point(8, 2);
            this.ProcIdTitle.Name = "ProcIdTitle";
            this.ProcIdTitle.Size = new System.Drawing.Size(62, 14);
            this.ProcIdTitle.TabIndex = 0;
            this.ProcIdTitle.Text = "Process ID:";
            // 
            // ProcIdLabel
            // 
            this.ProcIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcIdLabel.AutoSize = true;
            this.ProcIdLabel.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ProcIdLabel.Location = new System.Drawing.Point(67, 2);
            this.ProcIdLabel.Name = "ProcIdLabel";
            this.ProcIdLabel.Size = new System.Drawing.Size(44, 14);
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
            this.XPosTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.XPosTitle.Location = new System.Drawing.Point(20, 53);
            this.XPosTitle.Name = "XPosTitle";
            this.XPosTitle.Size = new System.Drawing.Size(16, 16);
            this.XPosTitle.TabIndex = 3;
            this.XPosTitle.Text = "X";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FooterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FooterPanel.Controls.Add(this.progressBar1);
            this.FooterPanel.Controls.Add(this.ProcIdLabel);
            this.FooterPanel.Controls.Add(this.ProcIdTitle);
            this.FooterPanel.Location = new System.Drawing.Point(-3, 344);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(539, 20);
            this.FooterPanel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(374, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.XPosLabel.Location = new System.Drawing.Point(42, 53);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(46, 16);
            this.XPosLabel.TabIndex = 5;
            this.XPosLabel.Text = "$xPos";
            // 
            // YPosTitle
            // 
            this.YPosTitle.AutoSize = true;
            this.YPosTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.YPosTitle.Location = new System.Drawing.Point(20, 69);
            this.YPosTitle.Name = "YPosTitle";
            this.YPosTitle.Size = new System.Drawing.Size(17, 16);
            this.YPosTitle.TabIndex = 3;
            this.YPosTitle.Text = "Y";
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.YPosLabel.Location = new System.Drawing.Point(42, 69);
            this.YPosLabel.Name = "YPosLabel";
            this.YPosLabel.Size = new System.Drawing.Size(47, 16);
            this.YPosLabel.TabIndex = 5;
            this.YPosLabel.Text = "$yPos";
            // 
            // ZPosTitle
            // 
            this.ZPosTitle.AutoSize = true;
            this.ZPosTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.ZPosTitle.Location = new System.Drawing.Point(20, 85);
            this.ZPosTitle.Name = "ZPosTitle";
            this.ZPosTitle.Size = new System.Drawing.Size(16, 16);
            this.ZPosTitle.TabIndex = 3;
            this.ZPosTitle.Text = "Z";
            // 
            // ZPosLabel
            // 
            this.ZPosLabel.AutoSize = true;
            this.ZPosLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.ZPosLabel.Location = new System.Drawing.Point(42, 85);
            this.ZPosLabel.Name = "ZPosLabel";
            this.ZPosLabel.Size = new System.Drawing.Size(46, 16);
            this.ZPosLabel.TabIndex = 5;
            this.ZPosLabel.Text = "$zPos";
            // 
            // FkxRefreshBtn
            // 
            this.FkxRefreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FkxRefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FkxRefreshBtn.BackgroundImage")));
            this.FkxRefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FkxRefreshBtn.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FkxRefreshBtn.Location = new System.Drawing.Point(4, 3);
            this.FkxRefreshBtn.Name = "FkxRefreshBtn";
            this.FkxRefreshBtn.Size = new System.Drawing.Size(20, 20);
            this.FkxRefreshBtn.TabIndex = 7;
            this.FkxRefreshBtn.UseVisualStyleBackColor = true;
            this.FkxRefreshBtn.Click += new System.EventHandler(this.FkxRefreshBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.EntitiesTitle);
            this.splitContainer1.Panel1.Controls.Add(this.FkxRefreshBtn);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.SetCamFocusBtn);
            this.splitContainer1.Panel2.Controls.Add(this.WarpToBtn);
            this.splitContainer1.Panel2.Controls.Add(this.EntityIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.YPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.ZPosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.XPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.ZPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.XPosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.YPosLabel);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(536, 345);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 8;
            // 
            // EntitiesTitle
            // 
            this.EntitiesTitle.AutoSize = true;
            this.EntitiesTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.EntitiesTitle.Location = new System.Drawing.Point(26, 4);
            this.EntitiesTitle.Name = "EntitiesTitle";
            this.EntitiesTitle.Size = new System.Drawing.Size(118, 18);
            this.EntitiesTitle.TabIndex = 9;
            this.EntitiesTitle.Text = "Loaded Entities";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 319);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SetCamFocusBtn
            // 
            this.SetCamFocusBtn.Location = new System.Drawing.Point(18, 133);
            this.SetCamFocusBtn.Name = "SetCamFocusBtn";
            this.SetCamFocusBtn.Size = new System.Drawing.Size(75, 23);
            this.SetCamFocusBtn.TabIndex = 8;
            this.SetCamFocusBtn.Text = "Cam Focus";
            this.SetCamFocusBtn.UseVisualStyleBackColor = true;
            this.SetCamFocusBtn.Click += new System.EventHandler(this.SetCamFocusBtn_Click);
            // 
            // WarpToBtn
            // 
            this.WarpToBtn.Location = new System.Drawing.Point(18, 104);
            this.WarpToBtn.Name = "WarpToBtn";
            this.WarpToBtn.Size = new System.Drawing.Size(75, 23);
            this.WarpToBtn.TabIndex = 7;
            this.WarpToBtn.Text = "Warp To";
            this.WarpToBtn.UseVisualStyleBackColor = true;
            this.WarpToBtn.Click += new System.EventHandler(this.WarpToBtn_Click);
            // 
            // EntityIdLabel
            // 
            this.EntityIdLabel.AutoSize = true;
            this.EntityIdLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntityIdLabel.Location = new System.Drawing.Point(14, 15);
            this.EntityIdLabel.Name = "EntityIdLabel";
            this.EntityIdLabel.Size = new System.Drawing.Size(85, 23);
            this.EntityIdLabel.TabIndex = 6;
            this.EntityIdLabel.Text = "$entityId";
            // 
            // TrainerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 364);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerMain";
            this.Text = "Jewel";
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button FkxRefreshBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label EntityIdLabel;
        private System.Windows.Forms.Button WarpToBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label EntitiesTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SetCamFocusBtn;
    }
}


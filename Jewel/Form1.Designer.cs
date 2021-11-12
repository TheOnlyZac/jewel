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
            this.FkxListbox = new System.Windows.Forms.ListBox();
            this.FkxRefreshBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EntityNameLabel = new System.Windows.Forms.Label();
            this.EntityListBox = new System.Windows.Forms.ListBox();
            this.WarpToSelected = new System.Windows.Forms.Button();
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
            this.FooterPanel.Controls.Add(this.ProcIdLabel);
            this.FooterPanel.Controls.Add(this.ProcIdTitle);
            this.FooterPanel.Location = new System.Drawing.Point(-3, 276);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(563, 20);
            this.FooterPanel.TabIndex = 4;
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
            // FkxListbox
            // 
            this.FkxListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FkxListbox.FormattingEnabled = true;
            this.FkxListbox.Location = new System.Drawing.Point(0, 25);
            this.FkxListbox.Name = "FkxListbox";
            this.FkxListbox.Size = new System.Drawing.Size(127, 251);
            this.FkxListbox.Sorted = true;
            this.FkxListbox.TabIndex = 6;
            this.FkxListbox.SelectedIndexChanged += new System.EventHandler(this.FkxListbox_SelectedIndexChanged);
            // 
            // FkxRefreshBtn
            // 
            this.FkxRefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FkxRefreshBtn.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FkxRefreshBtn.Location = new System.Drawing.Point(4, 2);
            this.FkxRefreshBtn.Name = "FkxRefreshBtn";
            this.FkxRefreshBtn.Size = new System.Drawing.Size(249, 23);
            this.FkxRefreshBtn.TabIndex = 7;
            this.FkxRefreshBtn.Text = "Refresh";
            this.FkxRefreshBtn.UseVisualStyleBackColor = true;
            this.FkxRefreshBtn.Click += new System.EventHandler(this.FkxRefreshBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.EntityListBox);
            this.splitContainer1.Panel1.Controls.Add(this.FkxListbox);
            this.splitContainer1.Panel1.Controls.Add(this.FkxRefreshBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.WarpToSelected);
            this.splitContainer1.Panel2.Controls.Add(this.EntityNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.YPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.ZPosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.XPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.ZPosTitle);
            this.splitContainer1.Panel2.Controls.Add(this.XPosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.YPosLabel);
            this.splitContainer1.Size = new System.Drawing.Size(560, 277);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 8;
            // 
            // EntityNameLabel
            // 
            this.EntityNameLabel.AutoSize = true;
            this.EntityNameLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntityNameLabel.Location = new System.Drawing.Point(14, 15);
            this.EntityNameLabel.Name = "EntityNameLabel";
            this.EntityNameLabel.Size = new System.Drawing.Size(119, 23);
            this.EntityNameLabel.TabIndex = 6;
            this.EntityNameLabel.Text = "$entityName";
            // 
            // EntityListBox
            // 
            this.EntityListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityListBox.FormattingEnabled = true;
            this.EntityListBox.Location = new System.Drawing.Point(125, 25);
            this.EntityListBox.Name = "EntityListBox";
            this.EntityListBox.Size = new System.Drawing.Size(133, 251);
            this.EntityListBox.Sorted = true;
            this.EntityListBox.TabIndex = 8;
            this.EntityListBox.SelectedIndexChanged += new System.EventHandler(this.EntityListBox_SelectedIndexChanged);
            // 
            // WarpToSelected
            // 
            this.WarpToSelected.Location = new System.Drawing.Point(18, 104);
            this.WarpToSelected.Name = "WarpToSelected";
            this.WarpToSelected.Size = new System.Drawing.Size(75, 23);
            this.WarpToSelected.TabIndex = 7;
            this.WarpToSelected.Text = "Warp To";
            this.WarpToSelected.UseVisualStyleBackColor = true;
            this.WarpToSelected.Click += new System.EventHandler(this.WarpToSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 296);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox FkxListbox;
        private System.Windows.Forms.Button FkxRefreshBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label EntityNameLabel;
        private System.Windows.Forms.ListBox EntityListBox;
        private System.Windows.Forms.Button WarpToSelected;
    }
}


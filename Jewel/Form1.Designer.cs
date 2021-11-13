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
            this.YPosTitle = new System.Windows.Forms.Label();
            this.ZPosTitle = new System.Windows.Forms.Label();
            this.FkxRefreshBtn = new System.Windows.Forms.Button();
            this.entitiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.EntitiesTitle = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.zPosTextBox = new System.Windows.Forms.TextBox();
            this.yPosTextBox = new System.Windows.Forms.TextBox();
            this.xPosTextBox = new System.Windows.Forms.TextBox();
            this.SetCamFocusBtn = new System.Windows.Forms.Button();
            this.WarpToBtn = new System.Windows.Forms.Button();
            this.EntityIdLabel = new System.Windows.Forms.Label();
            this.trainerTabs = new System.Windows.Forms.TabControl();
            this.entitiesTab = new System.Windows.Forms.TabPage();
            this.cameraTab = new System.Windows.Forms.TabPage();
            this.camFadeDistanceLabel = new System.Windows.Forms.Label();
            this.camFovLabel = new System.Windows.Forms.Label();
            this.cameraTabTitle = new System.Windows.Forms.Label();
            this.camFadeDistanceValue = new System.Windows.Forms.NumericUpDown();
            this.camFovValue = new System.Windows.Forms.NumericUpDown();
            this.resetCamBtn = new System.Windows.Forms.Button();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesSplitContainer)).BeginInit();
            this.entitiesSplitContainer.Panel1.SuspendLayout();
            this.entitiesSplitContainer.Panel2.SuspendLayout();
            this.entitiesSplitContainer.SuspendLayout();
            this.trainerTabs.SuspendLayout();
            this.entitiesTab.SuspendLayout();
            this.cameraTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFadeDistanceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFovValue)).BeginInit();
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
            this.XPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPosTitle.Location = new System.Drawing.Point(18, 57);
            this.XPosTitle.Name = "XPosTitle";
            this.XPosTitle.Size = new System.Drawing.Size(17, 16);
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
            // YPosTitle
            // 
            this.YPosTitle.AutoSize = true;
            this.YPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YPosTitle.Location = new System.Drawing.Point(18, 83);
            this.YPosTitle.Name = "YPosTitle";
            this.YPosTitle.Size = new System.Drawing.Size(16, 16);
            this.YPosTitle.TabIndex = 3;
            this.YPosTitle.Text = "Y";
            // 
            // ZPosTitle
            // 
            this.ZPosTitle.AutoSize = true;
            this.ZPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZPosTitle.Location = new System.Drawing.Point(19, 109);
            this.ZPosTitle.Name = "ZPosTitle";
            this.ZPosTitle.Size = new System.Drawing.Size(15, 16);
            this.ZPosTitle.TabIndex = 3;
            this.ZPosTitle.Text = "Z";
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
            // entitiesSplitContainer
            // 
            this.entitiesSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entitiesSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.entitiesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.entitiesSplitContainer.Name = "entitiesSplitContainer";
            // 
            // entitiesSplitContainer.Panel1
            // 
            this.entitiesSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.entitiesSplitContainer.Panel1.Controls.Add(this.EntitiesTitle);
            this.entitiesSplitContainer.Panel1.Controls.Add(this.FkxRefreshBtn);
            this.entitiesSplitContainer.Panel1.Controls.Add(this.treeView1);
            // 
            // entitiesSplitContainer.Panel2
            // 
            this.entitiesSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.entitiesSplitContainer.Panel2.Controls.Add(this.zPosTextBox);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.yPosTextBox);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.xPosTextBox);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.SetCamFocusBtn);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.WarpToBtn);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.EntityIdLabel);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.YPosTitle);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.XPosTitle);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.ZPosTitle);
            this.entitiesSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.entitiesSplitContainer.Size = new System.Drawing.Size(531, 316);
            this.entitiesSplitContainer.SplitterDistance = 204;
            this.entitiesSplitContainer.TabIndex = 8;
            // 
            // EntitiesTitle
            // 
            this.EntitiesTitle.AutoSize = true;
            this.EntitiesTitle.Font = new System.Drawing.Font("Arial", 11F);
            this.EntitiesTitle.Location = new System.Drawing.Point(26, 5);
            this.EntitiesTitle.Name = "EntitiesTitle";
            this.EntitiesTitle.Size = new System.Drawing.Size(108, 17);
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
            this.treeView1.Size = new System.Drawing.Size(201, 290);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // zPosTextBox
            // 
            this.zPosTextBox.Location = new System.Drawing.Point(38, 106);
            this.zPosTextBox.Name = "zPosTextBox";
            this.zPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.zPosTextBox.TabIndex = 9;
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Location = new System.Drawing.Point(38, 80);
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.yPosTextBox.TabIndex = 9;
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Location = new System.Drawing.Point(38, 54);
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.xPosTextBox.TabIndex = 9;
            // 
            // SetCamFocusBtn
            // 
            this.SetCamFocusBtn.Location = new System.Drawing.Point(18, 171);
            this.SetCamFocusBtn.Name = "SetCamFocusBtn";
            this.SetCamFocusBtn.Size = new System.Drawing.Size(84, 23);
            this.SetCamFocusBtn.TabIndex = 8;
            this.SetCamFocusBtn.Text = "Cam Focus";
            this.SetCamFocusBtn.UseVisualStyleBackColor = true;
            this.SetCamFocusBtn.Click += new System.EventHandler(this.SetCamFocusBtn_Click);
            // 
            // WarpToBtn
            // 
            this.WarpToBtn.Location = new System.Drawing.Point(18, 142);
            this.WarpToBtn.Name = "WarpToBtn";
            this.WarpToBtn.Size = new System.Drawing.Size(84, 23);
            this.WarpToBtn.TabIndex = 7;
            this.WarpToBtn.Text = "Warp To";
            this.WarpToBtn.UseVisualStyleBackColor = true;
            this.WarpToBtn.Click += new System.EventHandler(this.WarpToBtn_Click);
            // 
            // EntityIdLabel
            // 
            this.EntityIdLabel.AutoSize = true;
            this.EntityIdLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityIdLabel.Location = new System.Drawing.Point(14, 16);
            this.EntityIdLabel.Name = "EntityIdLabel";
            this.EntityIdLabel.Size = new System.Drawing.Size(165, 22);
            this.EntityIdLabel.TabIndex = 6;
            this.EntityIdLabel.Text = "Select an entity...";
            // 
            // trainerTabs
            // 
            this.trainerTabs.Controls.Add(this.entitiesTab);
            this.trainerTabs.Controls.Add(this.cameraTab);
            this.trainerTabs.Font = new System.Drawing.Font("Arial", 9F);
            this.trainerTabs.Location = new System.Drawing.Point(-3, 0);
            this.trainerTabs.Name = "trainerTabs";
            this.trainerTabs.SelectedIndex = 0;
            this.trainerTabs.Size = new System.Drawing.Size(539, 344);
            this.trainerTabs.TabIndex = 10;
            // 
            // entitiesTab
            // 
            this.entitiesTab.BackColor = System.Drawing.SystemColors.Control;
            this.entitiesTab.Controls.Add(this.entitiesSplitContainer);
            this.entitiesTab.Location = new System.Drawing.Point(4, 24);
            this.entitiesTab.Name = "entitiesTab";
            this.entitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.entitiesTab.Size = new System.Drawing.Size(531, 316);
            this.entitiesTab.TabIndex = 0;
            this.entitiesTab.Text = "Entities";
            // 
            // cameraTab
            // 
            this.cameraTab.Controls.Add(this.camFadeDistanceLabel);
            this.cameraTab.Controls.Add(this.camFovLabel);
            this.cameraTab.Controls.Add(this.cameraTabTitle);
            this.cameraTab.Controls.Add(this.camFadeDistanceValue);
            this.cameraTab.Controls.Add(this.camFovValue);
            this.cameraTab.Controls.Add(this.resetCamBtn);
            this.cameraTab.Location = new System.Drawing.Point(4, 24);
            this.cameraTab.Name = "cameraTab";
            this.cameraTab.Padding = new System.Windows.Forms.Padding(3);
            this.cameraTab.Size = new System.Drawing.Size(531, 316);
            this.cameraTab.TabIndex = 1;
            this.cameraTab.Text = "Camera";
            this.cameraTab.UseVisualStyleBackColor = true;
            // 
            // camFadeDistanceLabel
            // 
            this.camFadeDistanceLabel.AutoSize = true;
            this.camFadeDistanceLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camFadeDistanceLabel.Location = new System.Drawing.Point(16, 86);
            this.camFadeDistanceLabel.Name = "camFadeDistanceLabel";
            this.camFadeDistanceLabel.Size = new System.Drawing.Size(98, 16);
            this.camFadeDistanceLabel.TabIndex = 11;
            this.camFadeDistanceLabel.Text = "Fade Distance";
            this.camFadeDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camFovLabel
            // 
            this.camFovLabel.AutoSize = true;
            this.camFovLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camFovLabel.Location = new System.Drawing.Point(16, 146);
            this.camFovLabel.Name = "camFovLabel";
            this.camFovLabel.Size = new System.Drawing.Size(35, 16);
            this.camFovLabel.TabIndex = 11;
            this.camFovLabel.Text = "FOV";
            this.camFovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cameraTabTitle
            // 
            this.cameraTabTitle.AutoSize = true;
            this.cameraTabTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraTabTitle.Location = new System.Drawing.Point(13, 16);
            this.cameraTabTitle.Name = "cameraTabTitle";
            this.cameraTabTitle.Size = new System.Drawing.Size(160, 22);
            this.cameraTabTitle.TabIndex = 7;
            this.cameraTabTitle.Text = "Camera Options";
            // 
            // camFadeDistanceValue
            // 
            this.camFadeDistanceValue.DecimalPlaces = 2;
            this.camFadeDistanceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.camFadeDistanceValue.Location = new System.Drawing.Point(19, 105);
            this.camFadeDistanceValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.camFadeDistanceValue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.camFadeDistanceValue.Name = "camFadeDistanceValue";
            this.camFadeDistanceValue.Size = new System.Drawing.Size(89, 21);
            this.camFadeDistanceValue.TabIndex = 1;
            this.camFadeDistanceValue.ValueChanged += new System.EventHandler(this.camFadeDistanceValue_ValueChanged);
            // 
            // camFovValue
            // 
            this.camFovValue.DecimalPlaces = 2;
            this.camFovValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.camFovValue.Location = new System.Drawing.Point(19, 165);
            this.camFovValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.camFovValue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.camFovValue.Name = "camFovValue";
            this.camFovValue.Size = new System.Drawing.Size(89, 21);
            this.camFovValue.TabIndex = 1;
            this.camFovValue.ValueChanged += new System.EventHandler(this.camFovValue_ValueChanged);
            // 
            // resetCamBtn
            // 
            this.resetCamBtn.Location = new System.Drawing.Point(17, 41);
            this.resetCamBtn.Name = "resetCamBtn";
            this.resetCamBtn.Size = new System.Drawing.Size(120, 23);
            this.resetCamBtn.TabIndex = 0;
            this.resetCamBtn.Text = "Refresh Camera";
            this.resetCamBtn.UseVisualStyleBackColor = true;
            this.resetCamBtn.Click += new System.EventHandler(this.resetCamBtn_Click);
            // 
            // TrainerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 364);
            this.Controls.Add(this.trainerTabs);
            this.Controls.Add(this.FooterPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrainerMain";
            this.Text = "Jewel";
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.entitiesSplitContainer.Panel1.ResumeLayout(false);
            this.entitiesSplitContainer.Panel1.PerformLayout();
            this.entitiesSplitContainer.Panel2.ResumeLayout(false);
            this.entitiesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesSplitContainer)).EndInit();
            this.entitiesSplitContainer.ResumeLayout(false);
            this.trainerTabs.ResumeLayout(false);
            this.entitiesTab.ResumeLayout(false);
            this.cameraTab.ResumeLayout(false);
            this.cameraTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFadeDistanceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFovValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProcIdTitle;
        private System.Windows.Forms.Label ProcIdLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label XPosTitle;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label YPosTitle;
        private System.Windows.Forms.Label ZPosTitle;
        private System.Windows.Forms.Button FkxRefreshBtn;
        private System.Windows.Forms.SplitContainer entitiesSplitContainer;
        private System.Windows.Forms.Label EntityIdLabel;
        private System.Windows.Forms.Button WarpToBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label EntitiesTitle;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SetCamFocusBtn;
        private System.Windows.Forms.TabControl trainerTabs;
        private System.Windows.Forms.TabPage entitiesTab;
        private System.Windows.Forms.TabPage cameraTab;
        private System.Windows.Forms.TextBox xPosTextBox;
        private System.Windows.Forms.TextBox zPosTextBox;
        private System.Windows.Forms.TextBox yPosTextBox;
        private System.Windows.Forms.Label camFovLabel;
        private System.Windows.Forms.Label cameraTabTitle;
        private System.Windows.Forms.NumericUpDown camFovValue;
        private System.Windows.Forms.Button resetCamBtn;
        private System.Windows.Forms.Label camFadeDistanceLabel;
        private System.Windows.Forms.NumericUpDown camFadeDistanceValue;
    }
}


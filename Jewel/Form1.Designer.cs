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
            this.components = new System.ComponentModel.Container();
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
            this.pastePositionBtn = new System.Windows.Forms.Button();
            this.copyPositionBtn = new System.Windows.Forms.Button();
            this.entityPositionLabel = new System.Windows.Forms.Label();
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
            this.camZoomLabel = new System.Windows.Forms.Label();
            this.camFovLabel = new System.Windows.Forms.Label();
            this.cameraTabTitle = new System.Windows.Forms.Label();
            this.camZoomValue = new System.Windows.Forms.NumericUpDown();
            this.camFadeDistanceValue = new System.Windows.Forms.NumericUpDown();
            this.camFovValue = new System.Windows.Forms.NumericUpDown();
            this.resetCamBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.camFocusOnJtBtn = new System.Windows.Forms.Button();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesSplitContainer)).BeginInit();
            this.entitiesSplitContainer.Panel1.SuspendLayout();
            this.entitiesSplitContainer.Panel2.SuspendLayout();
            this.entitiesSplitContainer.SuspendLayout();
            this.trainerTabs.SuspendLayout();
            this.entitiesTab.SuspendLayout();
            this.cameraTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camZoomValue)).BeginInit();
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
            this.ProcIdLabel.Size = new System.Drawing.Size(25, 14);
            this.ProcIdLabel.TabIndex = 1;
            this.ProcIdLabel.Text = "N/A";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // XPosTitle
            // 
            this.XPosTitle.AutoSize = true;
            this.XPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XPosTitle.Location = new System.Drawing.Point(18, 74);
            this.XPosTitle.Name = "XPosTitle";
            this.XPosTitle.Size = new System.Drawing.Size(15, 16);
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
            this.FooterPanel.Location = new System.Drawing.Point(1, 341);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(445, 20);
            this.FooterPanel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(280, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // YPosTitle
            // 
            this.YPosTitle.AutoSize = true;
            this.YPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YPosTitle.Location = new System.Drawing.Point(17, 98);
            this.YPosTitle.Name = "YPosTitle";
            this.YPosTitle.Size = new System.Drawing.Size(17, 16);
            this.YPosTitle.TabIndex = 3;
            this.YPosTitle.Text = "Y";
            // 
            // ZPosTitle
            // 
            this.ZPosTitle.AutoSize = true;
            this.ZPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZPosTitle.Location = new System.Drawing.Point(18, 122);
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
            this.toolTip1.SetToolTip(this.FkxRefreshBtn, "Refresh entity list");
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
            this.entitiesSplitContainer.Panel2.Controls.Add(this.pastePositionBtn);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.copyPositionBtn);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.entityPositionLabel);
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
            this.entitiesSplitContainer.Size = new System.Drawing.Size(443, 313);
            this.entitiesSplitContainer.SplitterDistance = 219;
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
            this.treeView1.Font = new System.Drawing.Font("Arial", 8F);
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 287);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pastePositionBtn
            // 
            this.pastePositionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pastePositionBtn.BackgroundImage")));
            this.pastePositionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pastePositionBtn.FlatAppearance.BorderSize = 0;
            this.pastePositionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastePositionBtn.Location = new System.Drawing.Point(120, 50);
            this.pastePositionBtn.Name = "pastePositionBtn";
            this.pastePositionBtn.Size = new System.Drawing.Size(17, 17);
            this.pastePositionBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.pastePositionBtn, "Paste");
            this.pastePositionBtn.UseVisualStyleBackColor = true;
            this.pastePositionBtn.Click += new System.EventHandler(this.pastePositionBtn_Click);
            // 
            // copyPositionBtn
            // 
            this.copyPositionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyPositionBtn.BackgroundImage")));
            this.copyPositionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyPositionBtn.FlatAppearance.BorderSize = 0;
            this.copyPositionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPositionBtn.Location = new System.Drawing.Point(98, 50);
            this.copyPositionBtn.Name = "copyPositionBtn";
            this.copyPositionBtn.Size = new System.Drawing.Size(17, 17);
            this.copyPositionBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.copyPositionBtn, "Copy");
            this.copyPositionBtn.UseVisualStyleBackColor = true;
            this.copyPositionBtn.Click += new System.EventHandler(this.copyPositionBtn_Click);
            // 
            // entityPositionLabel
            // 
            this.entityPositionLabel.AutoSize = true;
            this.entityPositionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityPositionLabel.Location = new System.Drawing.Point(18, 50);
            this.entityPositionLabel.Name = "entityPositionLabel";
            this.entityPositionLabel.Size = new System.Drawing.Size(59, 16);
            this.entityPositionLabel.TabIndex = 12;
            this.entityPositionLabel.Text = "Position";
            this.entityPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zPosTextBox
            // 
            this.zPosTextBox.Location = new System.Drawing.Point(37, 119);
            this.zPosTextBox.Name = "zPosTextBox";
            this.zPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.zPosTextBox.TabIndex = 9;
            this.zPosTextBox.Tag = "z";
            this.zPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Location = new System.Drawing.Point(37, 95);
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.yPosTextBox.TabIndex = 9;
            this.yPosTextBox.Tag = "y";
            this.yPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Location = new System.Drawing.Point(37, 71);
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(100, 21);
            this.xPosTextBox.TabIndex = 9;
            this.xPosTextBox.Tag = "x";
            this.xPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // SetCamFocusBtn
            // 
            this.SetCamFocusBtn.Location = new System.Drawing.Point(17, 202);
            this.SetCamFocusBtn.Name = "SetCamFocusBtn";
            this.SetCamFocusBtn.Size = new System.Drawing.Size(84, 23);
            this.SetCamFocusBtn.TabIndex = 8;
            this.SetCamFocusBtn.Text = "Cam Focus";
            this.SetCamFocusBtn.UseVisualStyleBackColor = true;
            this.SetCamFocusBtn.Click += new System.EventHandler(this.SetCamFocusBtn_Click);
            // 
            // WarpToBtn
            // 
            this.WarpToBtn.Location = new System.Drawing.Point(17, 146);
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
            this.trainerTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainerTabs.Controls.Add(this.entitiesTab);
            this.trainerTabs.Controls.Add(this.cameraTab);
            this.trainerTabs.Font = new System.Drawing.Font("Arial", 9F);
            this.trainerTabs.Location = new System.Drawing.Point(-3, 0);
            this.trainerTabs.Name = "trainerTabs";
            this.trainerTabs.SelectedIndex = 0;
            this.trainerTabs.Size = new System.Drawing.Size(451, 341);
            this.trainerTabs.TabIndex = 10;
            // 
            // entitiesTab
            // 
            this.entitiesTab.BackColor = System.Drawing.SystemColors.Control;
            this.entitiesTab.Controls.Add(this.entitiesSplitContainer);
            this.entitiesTab.Location = new System.Drawing.Point(4, 24);
            this.entitiesTab.Name = "entitiesTab";
            this.entitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.entitiesTab.Size = new System.Drawing.Size(443, 313);
            this.entitiesTab.TabIndex = 0;
            this.entitiesTab.Text = "Entities";
            // 
            // cameraTab
            // 
            this.cameraTab.Controls.Add(this.camFocusOnJtBtn);
            this.cameraTab.Controls.Add(this.camFadeDistanceLabel);
            this.cameraTab.Controls.Add(this.camZoomLabel);
            this.cameraTab.Controls.Add(this.camFovLabel);
            this.cameraTab.Controls.Add(this.cameraTabTitle);
            this.cameraTab.Controls.Add(this.camZoomValue);
            this.cameraTab.Controls.Add(this.camFadeDistanceValue);
            this.cameraTab.Controls.Add(this.camFovValue);
            this.cameraTab.Controls.Add(this.resetCamBtn);
            this.cameraTab.Location = new System.Drawing.Point(4, 24);
            this.cameraTab.Name = "cameraTab";
            this.cameraTab.Padding = new System.Windows.Forms.Padding(3);
            this.cameraTab.Size = new System.Drawing.Size(443, 313);
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
            // camZoomLabel
            // 
            this.camZoomLabel.AutoSize = true;
            this.camZoomLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camZoomLabel.Location = new System.Drawing.Point(16, 198);
            this.camZoomLabel.Name = "camZoomLabel";
            this.camZoomLabel.Size = new System.Drawing.Size(43, 16);
            this.camZoomLabel.TabIndex = 11;
            this.camZoomLabel.Text = "Zoom";
            this.camZoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // camFovLabel
            // 
            this.camFovLabel.AutoSize = true;
            this.camFovLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camFovLabel.Location = new System.Drawing.Point(16, 142);
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
            // camZoomValue
            // 
            this.camZoomValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.camZoomValue.Location = new System.Drawing.Point(19, 217);
            this.camZoomValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.camZoomValue.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.camZoomValue.Name = "camZoomValue";
            this.camZoomValue.Size = new System.Drawing.Size(89, 21);
            this.camZoomValue.TabIndex = 1;
            this.camZoomValue.ValueChanged += new System.EventHandler(this.camZoomValue_ValueChanged);
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
            99999,
            0,
            0,
            0});
            this.camFadeDistanceValue.Minimum = new decimal(new int[] {
            99999,
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
            this.camFovValue.Location = new System.Drawing.Point(19, 161);
            this.camFovValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.camFovValue.Minimum = new decimal(new int[] {
            99999,
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
            // camFocusOnJtBtn
            // 
            this.camFocusOnJtBtn.Location = new System.Drawing.Point(143, 41);
            this.camFocusOnJtBtn.Name = "camFocusOnJtBtn";
            this.camFocusOnJtBtn.Size = new System.Drawing.Size(109, 23);
            this.camFocusOnJtBtn.TabIndex = 12;
            this.camFocusOnJtBtn.Text = "Focus on Sly";
            this.camFocusOnJtBtn.UseVisualStyleBackColor = true;
            // 
            // TrainerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(446, 361);
            this.Controls.Add(this.trainerTabs);
            this.Controls.Add(this.FooterPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 400);
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
            ((System.ComponentModel.ISupportInitialize)(this.camZoomValue)).EndInit();
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
        private System.Windows.Forms.Label camZoomLabel;
        private System.Windows.Forms.NumericUpDown camZoomValue;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label entityPositionLabel;
        private System.Windows.Forms.Button pastePositionBtn;
        private System.Windows.Forms.Button copyPositionBtn;
        private System.Windows.Forms.Button camFocusOnJtBtn;
    }
}


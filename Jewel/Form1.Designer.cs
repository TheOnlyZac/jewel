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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.YPosTitle = new System.Windows.Forms.Label();
            this.ZPosTitle = new System.Windows.Forms.Label();
            this.FkxRefreshBtn = new System.Windows.Forms.Button();
            this.entitiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.EntitiesTitle = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.entityPosGroupBox = new System.Windows.Forms.GroupBox();
            this.pastePosBtn = new System.Windows.Forms.Button();
            this.copyPosBtn = new System.Windows.Forms.Button();
            this.zPosTextBox = new System.Windows.Forms.TextBox();
            this.WarpToBtn = new System.Windows.Forms.Button();
            this.yPosTextBox = new System.Windows.Forms.TextBox();
            this.xPosTextBox = new System.Windows.Forms.TextBox();
            this.SetCamFocusBtn = new System.Windows.Forms.Button();
            this.EntityIdLabel = new System.Windows.Forms.Label();
            this.trainerTabs = new System.Windows.Forms.TabControl();
            this.entitiesTab = new System.Windows.Forms.TabPage();
            this.dagTab = new System.Windows.Forms.TabPage();
            this.dagSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.dagNodeEdgesGroupBox = new System.Windows.Forms.GroupBox();
            this.dagNodeChildrenLabel = new System.Windows.Forms.Label();
            this.dagNodeParentsLabel = new System.Windows.Forms.Label();
            this.dagNodeChildrenListBox = new System.Windows.Forms.ListBox();
            this.dagNodeParentsListBox = new System.Windows.Forms.ListBox();
            this.dagNodeStateGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cameraTab = new System.Windows.Forms.TabPage();
            this.renderOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.camFadeDistanceLabel = new System.Windows.Forms.Label();
            this.camFovValue = new System.Windows.Forms.NumericUpDown();
            this.camFadeDistanceValue = new System.Windows.Forms.NumericUpDown();
            this.camZoomLabel = new System.Windows.Forms.Label();
            this.camZoomValue = new System.Windows.Forms.NumericUpDown();
            this.camFovLabel = new System.Windows.Forms.Label();
            this.camFocusOnJtBtn = new System.Windows.Forms.Button();
            this.cameraTabTitle = new System.Windows.Forms.Label();
            this.resetCamBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entityScaleGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zScaleTextBox = new System.Windows.Forms.TextBox();
            this.entityScaleResetBtn = new System.Windows.Forms.Button();
            this.yScaleTextBox = new System.Windows.Forms.TextBox();
            this.xScaleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesSplitContainer)).BeginInit();
            this.entitiesSplitContainer.Panel1.SuspendLayout();
            this.entitiesSplitContainer.Panel2.SuspendLayout();
            this.entitiesSplitContainer.SuspendLayout();
            this.entityPosGroupBox.SuspendLayout();
            this.trainerTabs.SuspendLayout();
            this.entitiesTab.SuspendLayout();
            this.dagTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagSplitContainer)).BeginInit();
            this.dagSplitContainer.Panel1.SuspendLayout();
            this.dagSplitContainer.Panel2.SuspendLayout();
            this.dagSplitContainer.SuspendLayout();
            this.dagNodeEdgesGroupBox.SuspendLayout();
            this.dagNodeStateGroupBox.SuspendLayout();
            this.cameraTab.SuspendLayout();
            this.renderOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFovValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFadeDistanceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camZoomValue)).BeginInit();
            this.entityScaleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcIdTitle
            // 
            this.ProcIdTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcIdTitle.AutoSize = true;
            this.ProcIdTitle.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ProcIdTitle.Location = new System.Drawing.Point(10, 294);
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
            this.ProcIdLabel.Location = new System.Drawing.Point(69, 294);
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
            this.XPosTitle.Location = new System.Drawing.Point(12, 25);
            this.XPosTitle.Name = "XPosTitle";
            this.XPosTitle.Size = new System.Drawing.Size(15, 16);
            this.XPosTitle.TabIndex = 3;
            this.XPosTitle.Text = "X";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(370, 294);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(160, 13);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // YPosTitle
            // 
            this.YPosTitle.AutoSize = true;
            this.YPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YPosTitle.Location = new System.Drawing.Point(11, 49);
            this.YPosTitle.Name = "YPosTitle";
            this.YPosTitle.Size = new System.Drawing.Size(17, 16);
            this.YPosTitle.TabIndex = 3;
            this.YPosTitle.Text = "Y";
            // 
            // ZPosTitle
            // 
            this.ZPosTitle.AutoSize = true;
            this.ZPosTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZPosTitle.Location = new System.Drawing.Point(12, 73);
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
            this.entitiesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.entitiesSplitContainer.IsSplitterFixed = true;
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
            this.entitiesSplitContainer.Panel2.Controls.Add(this.entityScaleGroupBox);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.entityPosGroupBox);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.SetCamFocusBtn);
            this.entitiesSplitContainer.Panel2.Controls.Add(this.EntityIdLabel);
            this.entitiesSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.entitiesSplitContainer.Size = new System.Drawing.Size(529, 265);
            this.entitiesSplitContainer.SplitterDistance = 195;
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
            this.treeView1.Location = new System.Drawing.Point(3, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(189, 238);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // entityPosGroupBox
            // 
            this.entityPosGroupBox.Controls.Add(this.pastePosBtn);
            this.entityPosGroupBox.Controls.Add(this.ZPosTitle);
            this.entityPosGroupBox.Controls.Add(this.copyPosBtn);
            this.entityPosGroupBox.Controls.Add(this.XPosTitle);
            this.entityPosGroupBox.Controls.Add(this.YPosTitle);
            this.entityPosGroupBox.Controls.Add(this.zPosTextBox);
            this.entityPosGroupBox.Controls.Add(this.WarpToBtn);
            this.entityPosGroupBox.Controls.Add(this.yPosTextBox);
            this.entityPosGroupBox.Controls.Add(this.xPosTextBox);
            this.entityPosGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityPosGroupBox.Location = new System.Drawing.Point(16, 52);
            this.entityPosGroupBox.Name = "entityPosGroupBox";
            this.entityPosGroupBox.Size = new System.Drawing.Size(125, 127);
            this.entityPosGroupBox.TabIndex = 11;
            this.entityPosGroupBox.TabStop = false;
            this.entityPosGroupBox.Text = "Position";
            // 
            // pastePosBtn
            // 
            this.pastePosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pastePosBtn.BackgroundImage")));
            this.pastePosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pastePosBtn.FlatAppearance.BorderSize = 0;
            this.pastePosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastePosBtn.Location = new System.Drawing.Point(93, 0);
            this.pastePosBtn.Name = "pastePosBtn";
            this.pastePosBtn.Size = new System.Drawing.Size(15, 15);
            this.pastePosBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.pastePosBtn, "Paste");
            this.pastePosBtn.UseVisualStyleBackColor = true;
            this.pastePosBtn.Click += new System.EventHandler(this.pastePositionBtn_Click);
            // 
            // copyPosBtn
            // 
            this.copyPosBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyPosBtn.BackgroundImage")));
            this.copyPosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyPosBtn.FlatAppearance.BorderSize = 0;
            this.copyPosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPosBtn.Location = new System.Drawing.Point(71, 0);
            this.copyPosBtn.Name = "copyPosBtn";
            this.copyPosBtn.Size = new System.Drawing.Size(15, 15);
            this.copyPosBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.copyPosBtn, "Copy");
            this.copyPosBtn.UseVisualStyleBackColor = true;
            this.copyPosBtn.Click += new System.EventHandler(this.copyPositionBtn_Click);
            // 
            // zPosTextBox
            // 
            this.zPosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zPosTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zPosTextBox.Location = new System.Drawing.Point(31, 70);
            this.zPosTextBox.Name = "zPosTextBox";
            this.zPosTextBox.Size = new System.Drawing.Size(78, 21);
            this.zPosTextBox.TabIndex = 9;
            this.zPosTextBox.Tag = "z";
            this.zPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // WarpToBtn
            // 
            this.WarpToBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WarpToBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarpToBtn.Location = new System.Drawing.Point(11, 97);
            this.WarpToBtn.Name = "WarpToBtn";
            this.WarpToBtn.Size = new System.Drawing.Size(98, 23);
            this.WarpToBtn.TabIndex = 7;
            this.WarpToBtn.Text = "Warp To";
            this.WarpToBtn.UseVisualStyleBackColor = true;
            this.WarpToBtn.Click += new System.EventHandler(this.WarpToBtn_Click);
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yPosTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosTextBox.Location = new System.Drawing.Point(31, 46);
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(78, 21);
            this.yPosTextBox.TabIndex = 9;
            this.yPosTextBox.Tag = "y";
            this.yPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.xPosTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosTextBox.Location = new System.Drawing.Point(31, 22);
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(78, 21);
            this.xPosTextBox.TabIndex = 9;
            this.xPosTextBox.Tag = "x";
            this.xPosTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // SetCamFocusBtn
            // 
            this.SetCamFocusBtn.Location = new System.Drawing.Point(16, 195);
            this.SetCamFocusBtn.Name = "SetCamFocusBtn";
            this.SetCamFocusBtn.Size = new System.Drawing.Size(125, 23);
            this.SetCamFocusBtn.TabIndex = 8;
            this.SetCamFocusBtn.Text = "Set Camera Focus";
            this.SetCamFocusBtn.UseVisualStyleBackColor = true;
            this.SetCamFocusBtn.Click += new System.EventHandler(this.SetCamFocusBtn_Click);
            // 
            // EntityIdLabel
            // 
            this.EntityIdLabel.AutoSize = true;
            this.EntityIdLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityIdLabel.Location = new System.Drawing.Point(12, 16);
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
            this.trainerTabs.Controls.Add(this.dagTab);
            this.trainerTabs.Controls.Add(this.cameraTab);
            this.trainerTabs.Font = new System.Drawing.Font("Arial", 9F);
            this.trainerTabs.Location = new System.Drawing.Point(0, 0);
            this.trainerTabs.Name = "trainerTabs";
            this.trainerTabs.SelectedIndex = 0;
            this.trainerTabs.Size = new System.Drawing.Size(537, 291);
            this.trainerTabs.TabIndex = 10;
            // 
            // entitiesTab
            // 
            this.entitiesTab.BackColor = System.Drawing.Color.White;
            this.entitiesTab.Controls.Add(this.entitiesSplitContainer);
            this.entitiesTab.Location = new System.Drawing.Point(4, 24);
            this.entitiesTab.Name = "entitiesTab";
            this.entitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.entitiesTab.Size = new System.Drawing.Size(529, 263);
            this.entitiesTab.TabIndex = 0;
            this.entitiesTab.Text = "Entities";
            // 
            // dagTab
            // 
            this.dagTab.Controls.Add(this.dagSplitContainer);
            this.dagTab.Location = new System.Drawing.Point(4, 24);
            this.dagTab.Name = "dagTab";
            this.dagTab.Size = new System.Drawing.Size(529, 263);
            this.dagTab.TabIndex = 2;
            this.dagTab.Text = "DAG";
            this.dagTab.UseVisualStyleBackColor = true;
            // 
            // dagSplitContainer
            // 
            this.dagSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dagSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.dagSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.dagSplitContainer.IsSplitterFixed = true;
            this.dagSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.dagSplitContainer.Name = "dagSplitContainer";
            // 
            // dagSplitContainer.Panel1
            // 
            this.dagSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.dagSplitContainer.Panel1.Controls.Add(this.label1);
            this.dagSplitContainer.Panel1.Controls.Add(this.button1);
            this.dagSplitContainer.Panel1.Controls.Add(this.treeView2);
            // 
            // dagSplitContainer.Panel2
            // 
            this.dagSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.dagSplitContainer.Panel2.Controls.Add(this.dagNodeEdgesGroupBox);
            this.dagSplitContainer.Panel2.Controls.Add(this.dagNodeStateGroupBox);
            this.dagSplitContainer.Panel2.Controls.Add(this.label5);
            this.dagSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dagSplitContainer.Size = new System.Drawing.Size(529, 263);
            this.dagSplitContainer.SplitterDistance = 195;
            this.dagSplitContainer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F);
            this.label1.Location = new System.Drawing.Point(26, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current DAG Tasks";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button1, "Refresh entity list");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.Font = new System.Drawing.Font("Arial", 8F);
            this.treeView2.Location = new System.Drawing.Point(3, 25);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(189, 238);
            this.treeView2.TabIndex = 8;
            // 
            // dagNodeEdgesGroupBox
            // 
            this.dagNodeEdgesGroupBox.Controls.Add(this.dagNodeChildrenLabel);
            this.dagNodeEdgesGroupBox.Controls.Add(this.dagNodeParentsLabel);
            this.dagNodeEdgesGroupBox.Controls.Add(this.dagNodeChildrenListBox);
            this.dagNodeEdgesGroupBox.Controls.Add(this.dagNodeParentsListBox);
            this.dagNodeEdgesGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dagNodeEdgesGroupBox.Location = new System.Drawing.Point(18, 113);
            this.dagNodeEdgesGroupBox.Name = "dagNodeEdgesGroupBox";
            this.dagNodeEdgesGroupBox.Size = new System.Drawing.Size(261, 130);
            this.dagNodeEdgesGroupBox.TabIndex = 11;
            this.dagNodeEdgesGroupBox.TabStop = false;
            this.dagNodeEdgesGroupBox.Text = "Edges";
            // 
            // dagNodeChildrenLabel
            // 
            this.dagNodeChildrenLabel.AutoSize = true;
            this.dagNodeChildrenLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dagNodeChildrenLabel.Location = new System.Drawing.Point(130, 23);
            this.dagNodeChildrenLabel.Name = "dagNodeChildrenLabel";
            this.dagNodeChildrenLabel.Size = new System.Drawing.Size(54, 15);
            this.dagNodeChildrenLabel.TabIndex = 12;
            this.dagNodeChildrenLabel.Text = "Children";
            this.dagNodeChildrenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dagNodeParentsLabel
            // 
            this.dagNodeParentsLabel.AutoSize = true;
            this.dagNodeParentsLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dagNodeParentsLabel.Location = new System.Drawing.Point(6, 23);
            this.dagNodeParentsLabel.Name = "dagNodeParentsLabel";
            this.dagNodeParentsLabel.Size = new System.Drawing.Size(52, 15);
            this.dagNodeParentsLabel.TabIndex = 12;
            this.dagNodeParentsLabel.Text = "Parents";
            this.dagNodeParentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dagNodeChildrenListBox
            // 
            this.dagNodeChildrenListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dagNodeChildrenListBox.FormattingEnabled = true;
            this.dagNodeChildrenListBox.ItemHeight = 15;
            this.dagNodeChildrenListBox.Location = new System.Drawing.Point(133, 41);
            this.dagNodeChildrenListBox.Name = "dagNodeChildrenListBox";
            this.dagNodeChildrenListBox.Size = new System.Drawing.Size(120, 79);
            this.dagNodeChildrenListBox.TabIndex = 10;
            // 
            // dagNodeParentsListBox
            // 
            this.dagNodeParentsListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dagNodeParentsListBox.FormattingEnabled = true;
            this.dagNodeParentsListBox.ItemHeight = 15;
            this.dagNodeParentsListBox.Location = new System.Drawing.Point(7, 41);
            this.dagNodeParentsListBox.Name = "dagNodeParentsListBox";
            this.dagNodeParentsListBox.Size = new System.Drawing.Size(120, 79);
            this.dagNodeParentsListBox.TabIndex = 10;
            // 
            // dagNodeStateGroupBox
            // 
            this.dagNodeStateGroupBox.Controls.Add(this.comboBox1);
            this.dagNodeStateGroupBox.Controls.Add(this.button4);
            this.dagNodeStateGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dagNodeStateGroupBox.Location = new System.Drawing.Point(18, 52);
            this.dagNodeStateGroupBox.Name = "dagNodeStateGroupBox";
            this.dagNodeStateGroupBox.Size = new System.Drawing.Size(207, 50);
            this.dagNodeStateGroupBox.TabIndex = 11;
            this.dagNodeStateGroupBox.TabStop = false;
            this.dagNodeStateGroupBox.Text = "State";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Unavailable",
            "Available",
            "Complete",
            "Final"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(133, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select a task...";
            // 
            // cameraTab
            // 
            this.cameraTab.Controls.Add(this.renderOptionsGroupBox);
            this.cameraTab.Controls.Add(this.camFocusOnJtBtn);
            this.cameraTab.Controls.Add(this.cameraTabTitle);
            this.cameraTab.Controls.Add(this.resetCamBtn);
            this.cameraTab.Location = new System.Drawing.Point(4, 24);
            this.cameraTab.Name = "cameraTab";
            this.cameraTab.Padding = new System.Windows.Forms.Padding(3);
            this.cameraTab.Size = new System.Drawing.Size(529, 263);
            this.cameraTab.TabIndex = 1;
            this.cameraTab.Text = "Camera";
            this.cameraTab.UseVisualStyleBackColor = true;
            // 
            // renderOptionsGroupBox
            // 
            this.renderOptionsGroupBox.Controls.Add(this.camFadeDistanceLabel);
            this.renderOptionsGroupBox.Controls.Add(this.camFovValue);
            this.renderOptionsGroupBox.Controls.Add(this.camFadeDistanceValue);
            this.renderOptionsGroupBox.Controls.Add(this.camZoomLabel);
            this.renderOptionsGroupBox.Controls.Add(this.camZoomValue);
            this.renderOptionsGroupBox.Controls.Add(this.camFovLabel);
            this.renderOptionsGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderOptionsGroupBox.Location = new System.Drawing.Point(21, 50);
            this.renderOptionsGroupBox.Name = "renderOptionsGroupBox";
            this.renderOptionsGroupBox.Size = new System.Drawing.Size(134, 176);
            this.renderOptionsGroupBox.TabIndex = 13;
            this.renderOptionsGroupBox.TabStop = false;
            this.renderOptionsGroupBox.Text = "Render Options";
            // 
            // camFadeDistanceLabel
            // 
            this.camFadeDistanceLabel.AutoSize = true;
            this.camFadeDistanceLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.camFadeDistanceLabel.Location = new System.Drawing.Point(15, 26);
            this.camFadeDistanceLabel.Name = "camFadeDistanceLabel";
            this.camFadeDistanceLabel.Size = new System.Drawing.Size(87, 15);
            this.camFadeDistanceLabel.TabIndex = 11;
            this.camFadeDistanceLabel.Text = "Fade Distance";
            this.camFadeDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camFovValue
            // 
            this.camFovValue.DecimalPlaces = 2;
            this.camFovValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camFovValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.camFovValue.Location = new System.Drawing.Point(18, 94);
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
            // camFadeDistanceValue
            // 
            this.camFadeDistanceValue.DecimalPlaces = 2;
            this.camFadeDistanceValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camFadeDistanceValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.camFadeDistanceValue.Location = new System.Drawing.Point(18, 43);
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
            // camZoomLabel
            // 
            this.camZoomLabel.AutoSize = true;
            this.camZoomLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.camZoomLabel.Location = new System.Drawing.Point(15, 128);
            this.camZoomLabel.Name = "camZoomLabel";
            this.camZoomLabel.Size = new System.Drawing.Size(39, 15);
            this.camZoomLabel.TabIndex = 11;
            this.camZoomLabel.Text = "Zoom";
            this.camZoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // camZoomValue
            // 
            this.camZoomValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camZoomValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.camZoomValue.Location = new System.Drawing.Point(18, 145);
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
            // camFovLabel
            // 
            this.camFovLabel.AutoSize = true;
            this.camFovLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.camFovLabel.Location = new System.Drawing.Point(15, 77);
            this.camFovLabel.Name = "camFovLabel";
            this.camFovLabel.Size = new System.Drawing.Size(30, 15);
            this.camFovLabel.TabIndex = 11;
            this.camFovLabel.Text = "FOV";
            this.camFovLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // camFocusOnJtBtn
            // 
            this.camFocusOnJtBtn.Location = new System.Drawing.Point(174, 79);
            this.camFocusOnJtBtn.Name = "camFocusOnJtBtn";
            this.camFocusOnJtBtn.Size = new System.Drawing.Size(120, 23);
            this.camFocusOnJtBtn.TabIndex = 12;
            this.camFocusOnJtBtn.Text = "Focus on Sly";
            this.camFocusOnJtBtn.UseVisualStyleBackColor = true;
            // 
            // cameraTabTitle
            // 
            this.cameraTabTitle.AutoSize = true;
            this.cameraTabTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraTabTitle.Location = new System.Drawing.Point(17, 16);
            this.cameraTabTitle.Name = "cameraTabTitle";
            this.cameraTabTitle.Size = new System.Drawing.Size(82, 22);
            this.cameraTabTitle.TabIndex = 7;
            this.cameraTabTitle.Text = "Camera";
            // 
            // resetCamBtn
            // 
            this.resetCamBtn.Location = new System.Drawing.Point(174, 50);
            this.resetCamBtn.Name = "resetCamBtn";
            this.resetCamBtn.Size = new System.Drawing.Size(120, 23);
            this.resetCamBtn.TabIndex = 0;
            this.resetCamBtn.Text = "Refresh Camera";
            this.resetCamBtn.UseVisualStyleBackColor = true;
            this.resetCamBtn.Click += new System.EventHandler(this.resetCamBtn_Click);
            // 
            // entityScaleGroupBox
            // 
            this.entityScaleGroupBox.Controls.Add(this.button2);
            this.entityScaleGroupBox.Controls.Add(this.label2);
            this.entityScaleGroupBox.Controls.Add(this.button3);
            this.entityScaleGroupBox.Controls.Add(this.label3);
            this.entityScaleGroupBox.Controls.Add(this.label4);
            this.entityScaleGroupBox.Controls.Add(this.zScaleTextBox);
            this.entityScaleGroupBox.Controls.Add(this.entityScaleResetBtn);
            this.entityScaleGroupBox.Controls.Add(this.yScaleTextBox);
            this.entityScaleGroupBox.Controls.Add(this.xScaleTextBox);
            this.entityScaleGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityScaleGroupBox.Location = new System.Drawing.Point(157, 52);
            this.entityScaleGroupBox.Name = "entityScaleGroupBox";
            this.entityScaleGroupBox.Size = new System.Drawing.Size(125, 127);
            this.entityScaleGroupBox.TabIndex = 12;
            this.entityScaleGroupBox.TabStop = false;
            this.entityScaleGroupBox.Text = "Scale";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(93, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button2, "Paste");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Z";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(71, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 15);
            this.button3.TabIndex = 10;
            this.toolTip1.SetToolTip(this.button3, "Copy");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // zScaleTextBox
            // 
            this.zScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zScaleTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zScaleTextBox.Location = new System.Drawing.Point(31, 70);
            this.zScaleTextBox.Name = "zScaleTextBox";
            this.zScaleTextBox.Size = new System.Drawing.Size(78, 21);
            this.zScaleTextBox.TabIndex = 9;
            this.zScaleTextBox.Tag = "z";
            this.zScaleTextBox.TextChanged += new System.EventHandler(this.scaleTextBox_TextChanged);
            // 
            // entityScaleResetBtn
            // 
            this.entityScaleResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entityScaleResetBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityScaleResetBtn.Location = new System.Drawing.Point(11, 97);
            this.entityScaleResetBtn.Name = "entityScaleResetBtn";
            this.entityScaleResetBtn.Size = new System.Drawing.Size(98, 23);
            this.entityScaleResetBtn.TabIndex = 7;
            this.entityScaleResetBtn.Text = "Reset";
            this.entityScaleResetBtn.UseVisualStyleBackColor = true;
            this.entityScaleResetBtn.Click += new System.EventHandler(this.entityScaleResetBtn_Click);
            // 
            // yScaleTextBox
            // 
            this.yScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yScaleTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yScaleTextBox.Location = new System.Drawing.Point(31, 46);
            this.yScaleTextBox.Name = "yScaleTextBox";
            this.yScaleTextBox.Size = new System.Drawing.Size(78, 21);
            this.yScaleTextBox.TabIndex = 9;
            this.yScaleTextBox.Tag = "y";
            this.yScaleTextBox.TextChanged += new System.EventHandler(this.scaleTextBox_TextChanged);
            // 
            // xScaleTextBox
            // 
            this.xScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.xScaleTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScaleTextBox.Location = new System.Drawing.Point(31, 22);
            this.xScaleTextBox.Name = "xScaleTextBox";
            this.xScaleTextBox.Size = new System.Drawing.Size(78, 21);
            this.xScaleTextBox.TabIndex = 9;
            this.xScaleTextBox.Tag = "x";
            this.xScaleTextBox.TextChanged += new System.EventHandler(this.scaleTextBox_TextChanged);
            // 
            // TrainerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trainerTabs);
            this.Controls.Add(this.ProcIdLabel);
            this.Controls.Add(this.ProcIdTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "TrainerMain";
            this.Text = "Jewel";
            this.entitiesSplitContainer.Panel1.ResumeLayout(false);
            this.entitiesSplitContainer.Panel1.PerformLayout();
            this.entitiesSplitContainer.Panel2.ResumeLayout(false);
            this.entitiesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesSplitContainer)).EndInit();
            this.entitiesSplitContainer.ResumeLayout(false);
            this.entityPosGroupBox.ResumeLayout(false);
            this.entityPosGroupBox.PerformLayout();
            this.trainerTabs.ResumeLayout(false);
            this.entitiesTab.ResumeLayout(false);
            this.dagTab.ResumeLayout(false);
            this.dagSplitContainer.Panel1.ResumeLayout(false);
            this.dagSplitContainer.Panel1.PerformLayout();
            this.dagSplitContainer.Panel2.ResumeLayout(false);
            this.dagSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagSplitContainer)).EndInit();
            this.dagSplitContainer.ResumeLayout(false);
            this.dagNodeEdgesGroupBox.ResumeLayout(false);
            this.dagNodeEdgesGroupBox.PerformLayout();
            this.dagNodeStateGroupBox.ResumeLayout(false);
            this.cameraTab.ResumeLayout(false);
            this.cameraTab.PerformLayout();
            this.renderOptionsGroupBox.ResumeLayout(false);
            this.renderOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camFovValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camFadeDistanceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camZoomValue)).EndInit();
            this.entityScaleGroupBox.ResumeLayout(false);
            this.entityScaleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcIdTitle;
        private System.Windows.Forms.Label ProcIdLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label XPosTitle;
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
        private System.Windows.Forms.Button pastePosBtn;
        private System.Windows.Forms.Button copyPosBtn;
        private System.Windows.Forms.Button camFocusOnJtBtn;
        private System.Windows.Forms.GroupBox entityPosGroupBox;
        private System.Windows.Forms.GroupBox renderOptionsGroupBox;
        private System.Windows.Forms.TabPage dagTab;
        private System.Windows.Forms.SplitContainer dagSplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.GroupBox dagNodeStateGroupBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox dagNodeEdgesGroupBox;
        private System.Windows.Forms.ListBox dagNodeChildrenListBox;
        private System.Windows.Forms.ListBox dagNodeParentsListBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dagNodeChildrenLabel;
        private System.Windows.Forms.Label dagNodeParentsLabel;
        private System.Windows.Forms.GroupBox entityScaleGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zScaleTextBox;
        private System.Windows.Forms.Button entityScaleResetBtn;
        private System.Windows.Forms.TextBox yScaleTextBox;
        private System.Windows.Forms.TextBox xScaleTextBox;
    }
}


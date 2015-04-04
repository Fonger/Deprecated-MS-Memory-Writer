namespace MS_MemoryWriter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.HackListView = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colAddress = new System.Windows.Forms.ColumnHeader();
            this.col_Type = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.AuthorList = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新增NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開啟OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.新增toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.編輯StripButton1 = new System.Windows.Forms.ToolStripButton();
            this.刪除toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增項目AddAItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MSStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReadValue = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IsHex = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripHack = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刪除RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除RemoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripHack.SuspendLayout();
            this.SuspendLayout();
            // 
            // HackListView
            // 
            this.HackListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HackListView.CheckBoxes = true;
            this.HackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAddress,
            this.col_Type,
            this.colValue});
            this.HackListView.ContextMenuStrip = this.contextMenuStripHack;
            this.HackListView.Location = new System.Drawing.Point(12, 80);
            this.HackListView.MultiSelect = false;
            this.HackListView.Name = "HackListView";
            this.HackListView.Size = new System.Drawing.Size(661, 303);
            this.HackListView.TabIndex = 0;
            this.HackListView.Tag = "taskmgr.exe";
            this.HackListView.UseCompatibleStateImageBehavior = false;
            this.HackListView.View = System.Windows.Forms.View.Details;
            this.HackListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.HackListView_ItemChecked);
            this.HackListView.SelectedIndexChanged += new System.EventHandler(this.HackListView_SelectedIndexChanged_1);
            this.HackListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.HackListView_ItemCheck);
            // 
            // colName
            // 
            this.colName.Text = "Lock | 名稱(Name)";
            this.colName.Width = 151;
            // 
            // colAddress
            // 
            this.colAddress.Text = "位址(Address)";
            this.colAddress.Width = 122;
            // 
            // col_Type
            // 
            this.col_Type.Text = "型態(Type)";
            this.col_Type.Width = 164;
            // 
            // colValue
            // 
            this.colValue.Text = "值(Value)";
            this.colValue.Width = 201;
            // 
            // AuthorList
            // 
            this.AuthorList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorList.AutoSize = true;
            this.AuthorList.Location = new System.Drawing.Point(12, 407);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.Size = new System.Drawing.Size(639, 12);
            this.AuthorList.TabIndex = 1;
            this.AuthorList.Text = "Program and GUI: nimo1993; HS-CRC Cracking: 大可, JaySecret, nimo1993; Assembler: K" +
                "game Thanks to: Dark Byte. (依字母順序)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripButton,
            this.開啟OToolStripButton,
            this.儲存SToolStripButton,
            this.toolStripSeparator,
            this.新增toolStripButton,
            this.編輯StripButton1,
            this.刪除toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // 新增NToolStripButton
            // 
            this.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripButton.Image")));
            this.新增NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripButton.Name = "新增NToolStripButton";
            this.新增NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新增NToolStripButton.Text = "新增(&N)";
            this.新增NToolStripButton.Click += new System.EventHandler(this.新增NToolStripButton_Click);
            // 
            // 開啟OToolStripButton
            // 
            this.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripButton.Image")));
            this.開啟OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripButton.Name = "開啟OToolStripButton";
            this.開啟OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.開啟OToolStripButton.Text = "開啟(&O)";
            this.開啟OToolStripButton.Click += new System.EventHandler(this.開啟OToolStripButton_Click);
            // 
            // 儲存SToolStripButton
            // 
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripButton.Image")));
            this.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            this.儲存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.儲存SToolStripButton.Text = "儲存(&S)";
            this.儲存SToolStripButton.Click += new System.EventHandler(this.儲存SToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 新增toolStripButton
            // 
            this.新增toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增toolStripButton.Image")));
            this.新增toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增toolStripButton.Name = "新增toolStripButton";
            this.新增toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新增toolStripButton.Text = "新增(Add)";
            this.新增toolStripButton.Click += new System.EventHandler(this.新增toolStripButton_Click);
            // 
            // 編輯StripButton1
            // 
            this.編輯StripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.編輯StripButton1.Image = ((System.Drawing.Image)(resources.GetObject("編輯StripButton1.Image")));
            this.編輯StripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.編輯StripButton1.Name = "編輯StripButton1";
            this.編輯StripButton1.Size = new System.Drawing.Size(23, 22);
            this.編輯StripButton1.Text = "編輯(Edit)";
            this.編輯StripButton1.Click += new System.EventHandler(this.編輯StripButton1_Click);
            // 
            // 刪除toolStripButton
            // 
            this.刪除toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.刪除toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("刪除toolStripButton.Image")));
            this.刪除toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.刪除toolStripButton.Name = "刪除toolStripButton";
            this.刪除toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.刪除toolStripButton.Text = "刪除(Remove)";
            this.刪除toolStripButton.Click += new System.EventHandler(this.刪除toolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.toolStripSeparator2,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.toolStripSeparator3,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.檔案FToolStripMenuItem.Text = "檔案(&File)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.新增NToolStripMenuItem.Text = "新增(&New)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.開啟OToolStripMenuItem.Text = "開啟(&Open)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.儲存SToolStripMenuItem.Text = "儲存(&Save)";
            this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(Save &As)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.結束XToolStripMenuItem.Text = "結束(E&xit)";
            this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增項目AddAItemToolStripMenuItem,
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem,
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.編輯EToolStripMenuItem.Text = "編輯(&Edit)";
            // 
            // 新增項目AddAItemToolStripMenuItem
            // 
            this.新增項目AddAItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增項目AddAItemToolStripMenuItem.Image")));
            this.新增項目AddAItemToolStripMenuItem.Name = "新增項目AddAItemToolStripMenuItem";
            this.新增項目AddAItemToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.新增項目AddAItemToolStripMenuItem.Text = "新增項目(&Add a item)";
            this.新增項目AddAItemToolStripMenuItem.Click += new System.EventHandler(this.新增項目AddAItemToolStripMenuItem_Click);
            // 
            // 編輯選取項目EditTheSelectedItemToolStripMenuItem
            // 
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("編輯選取項目EditTheSelectedItemToolStripMenuItem.Image")));
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem.Name = "編輯選取項目EditTheSelectedItemToolStripMenuItem";
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem.Text = "編輯選取項目(&Edit the selected item)";
            this.編輯選取項目EditTheSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.編輯選取項目EditTheSelectedItemToolStripMenuItem_Click);
            // 
            // 刪除選取項目RemoveTheSelectedItemToolStripMenuItem
            // 
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Image")));
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Name = "刪除選取項目RemoveTheSelectedItemToolStripMenuItem";
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Text = "刪除選取項目(&Remove the selected item)";
            this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.刪除選取項目RemoveTheSelectedItemToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.toolStripSeparator7,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.說明HToolStripMenuItem.Text = "說明(&Help)";
            // 
            // 內容CToolStripMenuItem
            // 
            this.內容CToolStripMenuItem.Enabled = false;
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            this.內容CToolStripMenuItem.Size = new System.Drawing.Size(554, 22);
            this.內容CToolStripMenuItem.Text = "我需要有人幫忙寫說明文件... (I need someone who is enthusiastic help me write the help docume" +
                "nt.)";
            this.內容CToolStripMenuItem.Click += new System.EventHandler(this.內容CToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(551, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(554, 22);
            this.關於AToolStripMenuItem.Text = "關於(&About)...";
            this.關於AToolStripMenuItem.Click += new System.EventHandler(this.關於AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.MSStatus,
            this.toolStripFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(145, 20);
            this.toolStripSplitButton1.Text = "Click to attach MS.";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // MSStatus
            // 
            this.MSStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.MSStatus.Name = "MSStatus";
            this.MSStatus.Size = new System.Drawing.Size(124, 17);
            this.MSStatus.Text = "No MapleStory Attached!";
            // 
            // toolStripFileName
            // 
            this.toolStripFileName.Name = "toolStripFileName";
            this.toolStripFileName.Size = new System.Drawing.Size(63, 17);
            this.toolStripFileName.Text = "* Unsaved *";
            // 
            // timerReadValue
            // 
            this.timerReadValue.Enabled = true;
            this.timerReadValue.Interval = 500;
            this.timerReadValue.Tick += new System.EventHandler(this.timerReadValue_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "因為尚未完成，現在只有Auto Assemble Script可以寫入，鎖定Value功能不支援.";
            // 
            // IsHex
            // 
            this.IsHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IsHex.AutoSize = true;
            this.IsHex.Location = new System.Drawing.Point(468, 58);
            this.IsHex.Name = "IsHex";
            this.IsHex.Size = new System.Drawing.Size(205, 16);
            this.IsHex.TabIndex = 6;
            this.IsHex.Text = "顯示16進位數值 (Show as hex value)";
            this.IsHex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nimo Table:";
            // 
            // contextMenuStripHack
            // 
            this.contextMenuStripHack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刪除RemoveToolStripMenuItem,
            this.刪除RemoveToolStripMenuItem1});
            this.contextMenuStripHack.Name = "contextMenuStripHack";
            this.contextMenuStripHack.Size = new System.Drawing.Size(142, 48);
            // 
            // 刪除RemoveToolStripMenuItem
            // 
            this.刪除RemoveToolStripMenuItem.Name = "刪除RemoveToolStripMenuItem";
            this.刪除RemoveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刪除RemoveToolStripMenuItem.Text = "編輯(&Edit)";
            this.刪除RemoveToolStripMenuItem.Click += new System.EventHandler(this.刪除RemoveToolStripMenuItem_Click);
            // 
            // 刪除RemoveToolStripMenuItem1
            // 
            this.刪除RemoveToolStripMenuItem1.Name = "刪除RemoveToolStripMenuItem1";
            this.刪除RemoveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.刪除RemoveToolStripMenuItem1.Text = "刪除(&Remove)";
            this.刪除RemoveToolStripMenuItem1.Click += new System.EventHandler(this.刪除RemoveToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IsHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AuthorList);
            this.Controls.Add(this.HackListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MS-Memory Writer v1.0 alpha for MapleStory and HackShield 5.2.17.993+ by nimo1993" +
                ".";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripHack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView HackListView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader col_Type;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Label AuthorList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 新增NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開啟OToolStripButton;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 新增toolStripButton;
        private System.Windows.Forms.ToolStripButton 刪除toolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MSStatus;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Timer timerReadValue;
        private System.Windows.Forms.ToolStripMenuItem 新增項目AddAItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除選取項目RemoveTheSelectedItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 編輯StripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 編輯選取項目EditTheSelectedItemToolStripMenuItem;
        private System.Windows.Forms.CheckBox IsHex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFileName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHack;
        private System.Windows.Forms.ToolStripMenuItem 刪除RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除RemoveToolStripMenuItem1;


    }
}
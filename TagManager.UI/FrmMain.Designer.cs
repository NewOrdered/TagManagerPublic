namespace TagManager.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnEditor = new System.Windows.Forms.Panel();
            this.dataListViewAllTags = new BrightIdeasSoftware.DataListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.commentColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tagIcons = new System.Windows.Forms.ImageList(this.components);
            this.dataListViewMembers = new BrightIdeasSoftware.DataListView();
            this.memberNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.memberTypeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.memberCommentColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblSelectedSuperTagName = new System.Windows.Forms.Label();
            this.gBoxMembers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBoxSelectedSuperTag = new System.Windows.Forms.PictureBox();
            this.lblMembersCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCopyComments = new System.Windows.Forms.Button();
            this.btnEditComments = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnEditIoItems = new System.Windows.Forms.Button();
            this.btnDuplicateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.cMenuStripSelectedObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStripMenuItemDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalItemsCount = new System.Windows.Forms.Label();
            this.btnDuplicateItem = new System.Windows.Forms.Button();
            this.cMenuStripSelectedSuperTag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStripMenuSuperTagRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuSuperTagDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuSuperTagCreateTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuSuperTagCreateIndirect = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuSuperTagDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStripMultipleObjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAlarmGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAccessNames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDBLoadMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeAsk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeIgnore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeTerminate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnNewSuperTag = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewAllTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewMembers)).BeginInit();
            this.gBoxMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSelectedSuperTag)).BeginInit();
            this.panel4.SuspendLayout();
            this.cMenuStripSelectedObject.SuspendLayout();
            this.cMenuStripSelectedSuperTag.SuspendLayout();
            this.cMenuStripMultipleObjects.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEditor
            // 
            this.pnEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEditor.Location = new System.Drawing.Point(683, 4);
            this.pnEditor.Margin = new System.Windows.Forms.Padding(4);
            this.pnEditor.Name = "pnEditor";
            this.pnEditor.Size = new System.Drawing.Size(511, 405);
            this.pnEditor.TabIndex = 3;
            // 
            // dataListViewAllTags
            // 
            this.dataListViewAllTags.AllColumns.Add(this.nameColumn);
            this.dataListViewAllTags.AllColumns.Add(this.typeColumn);
            this.dataListViewAllTags.AllColumns.Add(this.commentColumn);
            this.dataListViewAllTags.AutoGenerateColumns = false;
            this.dataListViewAllTags.CellEditUseWholeCell = false;
            this.dataListViewAllTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.typeColumn,
            this.commentColumn});
            this.dataListViewAllTags.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListViewAllTags.DataSource = null;
            this.dataListViewAllTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListViewAllTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataListViewAllTags.FullRowSelect = true;
            this.dataListViewAllTags.HideSelection = false;
            this.dataListViewAllTags.Location = new System.Drawing.Point(4, 4);
            this.dataListViewAllTags.Margin = new System.Windows.Forms.Padding(4);
            this.dataListViewAllTags.Name = "dataListViewAllTags";
            this.tableLayoutPanel1.SetRowSpan(this.dataListViewAllTags, 2);
            this.dataListViewAllTags.ShowCommandMenuOnRightClick = true;
            this.dataListViewAllTags.ShowGroups = false;
            this.dataListViewAllTags.Size = new System.Drawing.Size(671, 684);
            this.dataListViewAllTags.SmallImageList = this.tagIcons;
            this.dataListViewAllTags.TabIndex = 6;
            this.dataListViewAllTags.UseCompatibleStateImageBehavior = false;
            this.dataListViewAllTags.UseHotItem = true;
            this.dataListViewAllTags.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 220;
            // 
            // typeColumn
            // 
            this.typeColumn.AspectName = "Type";
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 130;
            // 
            // commentColumn
            // 
            this.commentColumn.AspectName = "Comment";
            this.commentColumn.FillsFreeSpace = true;
            this.commentColumn.Text = "Comment";
            this.commentColumn.Width = 299;
            // 
            // tagIcons
            // 
            this.tagIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tagIcons.ImageStream")));
            this.tagIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tagIcons.Images.SetKeyName(0, "bool");
            this.tagIcons.Images.SetKeyName(1, "folder");
            this.tagIcons.Images.SetKeyName(2, "integer");
            this.tagIcons.Images.SetKeyName(3, "msg");
            this.tagIcons.Images.SetKeyName(4, "real");
            this.tagIcons.Images.SetKeyName(5, "link");
            this.tagIcons.Images.SetKeyName(6, "empty");
            // 
            // dataListViewMembers
            // 
            this.dataListViewMembers.AllColumns.Add(this.memberNameColumn);
            this.dataListViewMembers.AllColumns.Add(this.memberTypeColumn);
            this.dataListViewMembers.AllColumns.Add(this.memberCommentColumn);
            this.dataListViewMembers.AutoGenerateColumns = false;
            this.dataListViewMembers.CellEditUseWholeCell = false;
            this.dataListViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberNameColumn,
            this.memberTypeColumn,
            this.memberCommentColumn});
            this.dataListViewMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListViewMembers.DataSource = null;
            this.dataListViewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListViewMembers.FullRowSelect = true;
            this.dataListViewMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dataListViewMembers.HideSelection = false;
            this.dataListViewMembers.Location = new System.Drawing.Point(4, 32);
            this.dataListViewMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dataListViewMembers.MultiSelect = false;
            this.dataListViewMembers.Name = "dataListViewMembers";
            this.dataListViewMembers.ShowGroups = false;
            this.dataListViewMembers.ShowHeaderInAllViews = false;
            this.dataListViewMembers.ShowItemToolTips = true;
            this.dataListViewMembers.Size = new System.Drawing.Size(388, 264);
            this.dataListViewMembers.SmallImageList = this.tagIcons;
            this.dataListViewMembers.TabIndex = 8;
            this.dataListViewMembers.UseCompatibleStateImageBehavior = false;
            this.dataListViewMembers.UseHotItem = true;
            this.dataListViewMembers.View = System.Windows.Forms.View.Details;
            // 
            // memberNameColumn
            // 
            this.memberNameColumn.AspectName = "Name";
            this.memberNameColumn.Width = 150;
            // 
            // memberTypeColumn
            // 
            this.memberTypeColumn.AspectName = "Type";
            this.memberTypeColumn.Width = 120;
            // 
            // memberCommentColumn
            // 
            this.memberCommentColumn.AspectName = "Comment";
            this.memberCommentColumn.FillsFreeSpace = true;
            // 
            // lblSelectedSuperTagName
            // 
            this.lblSelectedSuperTagName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectedSuperTagName.AutoSize = true;
            this.lblSelectedSuperTagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedSuperTagName.Location = new System.Drawing.Point(28, 4);
            this.lblSelectedSuperTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedSuperTagName.Name = "lblSelectedSuperTagName";
            this.lblSelectedSuperTagName.Size = new System.Drawing.Size(65, 16);
            this.lblSelectedSuperTagName.TabIndex = 7;
            this.lblSelectedSuperTagName.Text = "<Name>";
            // 
            // gBoxMembers
            // 
            this.gBoxMembers.Controls.Add(this.tableLayoutPanel2);
            this.gBoxMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxMembers.Location = new System.Drawing.Point(0, 0);
            this.gBoxMembers.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxMembers.Name = "gBoxMembers";
            this.gBoxMembers.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxMembers.Size = new System.Drawing.Size(513, 323);
            this.gBoxMembers.TabIndex = 9;
            this.gBoxMembers.TabStop = false;
            this.gBoxMembers.Text = "Members";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.Controls.Add(this.dataListViewMembers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 300);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pBoxSelectedSuperTag);
            this.panel3.Controls.Add(this.lblSelectedSuperTagName);
            this.panel3.Controls.Add(this.lblMembersCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 22);
            this.panel3.TabIndex = 9;
            // 
            // pBoxSelectedSuperTag
            // 
            this.pBoxSelectedSuperTag.Location = new System.Drawing.Point(5, 3);
            this.pBoxSelectedSuperTag.Name = "pBoxSelectedSuperTag";
            this.pBoxSelectedSuperTag.Size = new System.Drawing.Size(16, 16);
            this.pBoxSelectedSuperTag.TabIndex = 10;
            this.pBoxSelectedSuperTag.TabStop = false;
            // 
            // lblMembersCount
            // 
            this.lblMembersCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMembersCount.AutoSize = true;
            this.lblMembersCount.Location = new System.Drawing.Point(297, 4);
            this.lblMembersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembersCount.Name = "lblMembersCount";
            this.lblMembersCount.Size = new System.Drawing.Size(79, 16);
            this.lblMembersCount.TabIndex = 9;
            this.lblMembersCount.Text = "<Members>";
            this.lblMembersCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCopyComments);
            this.panel4.Controls.Add(this.btnEditComments);
            this.panel4.Controls.Add(this.btnNewMember);
            this.panel4.Controls.Add(this.btnEditIoItems);
            this.panel4.Controls.Add(this.btnDuplicateMember);
            this.panel4.Controls.Add(this.btnDeleteMember);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(399, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 266);
            this.panel4.TabIndex = 10;
            // 
            // btnCopyComments
            // 
            this.btnCopyComments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCopyComments.Location = new System.Drawing.Point(4, 177);
            this.btnCopyComments.Name = "btnCopyComments";
            this.btnCopyComments.Size = new System.Drawing.Size(96, 28);
            this.btnCopyComments.TabIndex = 23;
            this.btnCopyComments.Text = "Copy AC > C";
            this.btnCopyComments.UseVisualStyleBackColor = true;
            this.btnCopyComments.Click += new System.EventHandler(this.btnCopyComments_Click);
            // 
            // btnEditComments
            // 
            this.btnEditComments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditComments.Location = new System.Drawing.Point(4, 143);
            this.btnEditComments.Name = "btnEditComments";
            this.btnEditComments.Size = new System.Drawing.Size(96, 28);
            this.btnEditComments.TabIndex = 22;
            this.btnEditComments.Text = "Comments...";
            this.btnEditComments.UseVisualStyleBackColor = true;
            this.btnEditComments.Click += new System.EventHandler(this.btnEditComments_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewMember.Location = new System.Drawing.Point(4, 4);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(96, 28);
            this.btnNewMember.TabIndex = 20;
            this.btnNewMember.Text = "New...";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnEditIoItems
            // 
            this.btnEditIoItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditIoItems.Location = new System.Drawing.Point(4, 109);
            this.btnEditIoItems.Name = "btnEditIoItems";
            this.btnEditIoItems.Size = new System.Drawing.Size(96, 28);
            this.btnEditIoItems.TabIndex = 21;
            this.btnEditIoItems.Text = "Edit I/O...";
            this.btnEditIoItems.UseVisualStyleBackColor = true;
            this.btnEditIoItems.Click += new System.EventHandler(this.btnEditIoItems_Click);
            // 
            // btnDuplicateMember
            // 
            this.btnDuplicateMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuplicateMember.Location = new System.Drawing.Point(4, 40);
            this.btnDuplicateMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuplicateMember.Name = "btnDuplicateMember";
            this.btnDuplicateMember.Size = new System.Drawing.Size(96, 28);
            this.btnDuplicateMember.TabIndex = 10;
            this.btnDuplicateMember.Text = "Duplicate";
            this.btnDuplicateMember.UseVisualStyleBackColor = true;
            this.btnDuplicateMember.Click += new System.EventHandler(this.btnDuplicateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteMember.Location = new System.Drawing.Point(4, 75);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(96, 28);
            this.btnDeleteMember.TabIndex = 11;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // cMenuStripSelectedObject
            // 
            this.cMenuStripSelectedObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuItemDuplicate,
            this.tStripMenuItemDelete});
            this.cMenuStripSelectedObject.Name = "cMenuStripSelectedObject";
            this.cMenuStripSelectedObject.Size = new System.Drawing.Size(118, 48);
            // 
            // tStripMenuItemDuplicate
            // 
            this.tStripMenuItemDuplicate.Name = "tStripMenuItemDuplicate";
            this.tStripMenuItemDuplicate.ShowShortcutKeys = false;
            this.tStripMenuItemDuplicate.Size = new System.Drawing.Size(117, 22);
            this.tStripMenuItemDuplicate.Text = "Duplicate";
            this.tStripMenuItemDuplicate.Click += new System.EventHandler(this.tStripMenuItemDuplicate_Click);
            // 
            // tStripMenuItemDelete
            // 
            this.tStripMenuItemDelete.Name = "tStripMenuItemDelete";
            this.tStripMenuItemDelete.Size = new System.Drawing.Size(117, 22);
            this.tStripMenuItemDelete.Text = "Delete";
            this.tStripMenuItemDelete.Click += new System.EventHandler(this.tStripMenuItemDelete_Click);
            // 
            // lblTotalItemsCount
            // 
            this.lblTotalItemsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalItemsCount.AutoSize = true;
            this.lblTotalItemsCount.Location = new System.Drawing.Point(4, 20);
            this.lblTotalItemsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItemsCount.Name = "lblTotalItemsCount";
            this.lblTotalItemsCount.Size = new System.Drawing.Size(88, 16);
            this.lblTotalItemsCount.TabIndex = 10;
            this.lblTotalItemsCount.Text = "<Total Items>";
            this.lblTotalItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDuplicateItem
            // 
            this.btnDuplicateItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDuplicateItem.Location = new System.Drawing.Point(461, 14);
            this.btnDuplicateItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuplicateItem.Name = "btnDuplicateItem";
            this.btnDuplicateItem.Size = new System.Drawing.Size(100, 28);
            this.btnDuplicateItem.TabIndex = 11;
            this.btnDuplicateItem.Text = "Duplicate";
            this.btnDuplicateItem.UseVisualStyleBackColor = true;
            this.btnDuplicateItem.Click += new System.EventHandler(this.btnDuplicateItem_Click);
            // 
            // cMenuStripSelectedSuperTag
            // 
            this.cMenuStripSelectedSuperTag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuSuperTagRename,
            this.tStripMenuSuperTagDuplicate,
            this.tStripMenuSuperTagCreateTemplate,
            this.tStripMenuSuperTagCreateIndirect,
            this.tStripMenuSuperTagDelete});
            this.cMenuStripSelectedSuperTag.Name = "cMenuStripSelectedSuperTag";
            this.cMenuStripSelectedSuperTag.Size = new System.Drawing.Size(171, 114);
            // 
            // tStripMenuSuperTagRename
            // 
            this.tStripMenuSuperTagRename.Name = "tStripMenuSuperTagRename";
            this.tStripMenuSuperTagRename.Size = new System.Drawing.Size(170, 22);
            this.tStripMenuSuperTagRename.Text = "Rename";
            this.tStripMenuSuperTagRename.Click += new System.EventHandler(this.tStripMenuSuperTagRename_Click);
            // 
            // tStripMenuSuperTagDuplicate
            // 
            this.tStripMenuSuperTagDuplicate.Name = "tStripMenuSuperTagDuplicate";
            this.tStripMenuSuperTagDuplicate.Size = new System.Drawing.Size(170, 22);
            this.tStripMenuSuperTagDuplicate.Text = "Duplicate";
            this.tStripMenuSuperTagDuplicate.Click += new System.EventHandler(this.tStripMenuSuperTagDuplicate_Click);
            // 
            // tStripMenuSuperTagCreateTemplate
            // 
            this.tStripMenuSuperTagCreateTemplate.Name = "tStripMenuSuperTagCreateTemplate";
            this.tStripMenuSuperTagCreateTemplate.Size = new System.Drawing.Size(170, 22);
            this.tStripMenuSuperTagCreateTemplate.Text = "Create Template...";
            this.tStripMenuSuperTagCreateTemplate.Click += new System.EventHandler(this.tStripMenuSuperTagCreateTemplate_Click);
            // 
            // tStripMenuSuperTagCreateIndirect
            // 
            this.tStripMenuSuperTagCreateIndirect.Name = "tStripMenuSuperTagCreateIndirect";
            this.tStripMenuSuperTagCreateIndirect.Size = new System.Drawing.Size(170, 22);
            this.tStripMenuSuperTagCreateIndirect.Text = "Create Indirect...";
            this.tStripMenuSuperTagCreateIndirect.Click += new System.EventHandler(this.tStripMenuSuperTagCreateIndirect_Click);
            // 
            // tStripMenuSuperTagDelete
            // 
            this.tStripMenuSuperTagDelete.Name = "tStripMenuSuperTagDelete";
            this.tStripMenuSuperTagDelete.Size = new System.Drawing.Size(170, 22);
            this.tStripMenuSuperTagDelete.Text = "Delete";
            this.tStripMenuSuperTagDelete.Click += new System.EventHandler(this.tStripMenuSuperTagDelete_Click);
            // 
            // cMenuStripMultipleObjects
            // 
            this.cMenuStripMultipleObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuDelete});
            this.cMenuStripMultipleObjects.Name = "cMenuStripMultipleObjects";
            this.cMenuStripMultipleObjects.Size = new System.Drawing.Size(108, 26);
            // 
            // tStripMenuDelete
            // 
            this.tStripMenuDelete.Name = "tStripMenuDelete";
            this.tStripMenuDelete.Size = new System.Drawing.Size(107, 22);
            this.tStripMenuDelete.Text = "Delete";
            this.tStripMenuDelete.Click += new System.EventHandler(this.tStripMenuDelete_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuSpecial});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1198, 24);
            this.menuStripMain.TabIndex = 17;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenuImport,
            this.toolStripMenuIExport,
            this.toolStripFileSeparator1,
            this.toolStripMenuExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuFile.Text = "File";
            // 
            // tStripMenuImport
            // 
            this.tStripMenuImport.Name = "tStripMenuImport";
            this.tStripMenuImport.Size = new System.Drawing.Size(123, 22);
            this.tStripMenuImport.Text = "Import...";
            this.tStripMenuImport.Click += new System.EventHandler(this.tStripMenuImport_Click);
            // 
            // toolStripMenuIExport
            // 
            this.toolStripMenuIExport.Name = "toolStripMenuIExport";
            this.toolStripMenuIExport.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuIExport.Text = "Export...";
            this.toolStripMenuIExport.Click += new System.EventHandler(this.toolStripMenuIExport_Click);
            // 
            // toolStripFileSeparator1
            // 
            this.toolStripFileSeparator1.Name = "toolStripFileSeparator1";
            this.toolStripFileSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // toolStripMenuSpecial
            // 
            this.toolStripMenuSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAlarmGroups,
            this.toolStripMenuAccessNames,
            this.toolStripMenuTemplates,
            this.toolStripMenuDBLoadMode});
            this.toolStripMenuSpecial.Name = "toolStripMenuSpecial";
            this.toolStripMenuSpecial.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuSpecial.Text = "Special";
            // 
            // toolStripMenuAlarmGroups
            // 
            this.toolStripMenuAlarmGroups.Name = "toolStripMenuAlarmGroups";
            this.toolStripMenuAlarmGroups.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuAlarmGroups.Text = "Alarm Groups...";
            this.toolStripMenuAlarmGroups.Click += new System.EventHandler(this.toolStripMenuAlarmGroups_Click);
            // 
            // toolStripMenuAccessNames
            // 
            this.toolStripMenuAccessNames.Name = "toolStripMenuAccessNames";
            this.toolStripMenuAccessNames.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuAccessNames.Text = "Access Names...";
            this.toolStripMenuAccessNames.Click += new System.EventHandler(this.toolStripMenuAccessNames_Click);
            // 
            // toolStripMenuTemplates
            // 
            this.toolStripMenuTemplates.Name = "toolStripMenuTemplates";
            this.toolStripMenuTemplates.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuTemplates.Text = "Templates...";
            this.toolStripMenuTemplates.Click += new System.EventHandler(this.toolStripMenuTemplates_Click);
            // 
            // toolStripMenuDBLoadMode
            // 
            this.toolStripMenuDBLoadMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuModeReplace,
            this.toolStripMenuModeUpdate,
            this.toolStripMenuModeAsk,
            this.toolStripMenuModeIgnore,
            this.toolStripMenuModeTerminate,
            this.toolStripMenuModeTest});
            this.toolStripMenuDBLoadMode.Name = "toolStripMenuDBLoadMode";
            this.toolStripMenuDBLoadMode.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuDBLoadMode.Text = "DBLoad Mode";
            // 
            // toolStripMenuModeReplace
            // 
            this.toolStripMenuModeReplace.Name = "toolStripMenuModeReplace";
            this.toolStripMenuModeReplace.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeReplace.Tag = "Replace";
            this.toolStripMenuModeReplace.Text = "Replace";
            // 
            // toolStripMenuModeUpdate
            // 
            this.toolStripMenuModeUpdate.Name = "toolStripMenuModeUpdate";
            this.toolStripMenuModeUpdate.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeUpdate.Tag = "Update";
            this.toolStripMenuModeUpdate.Text = "Update";
            // 
            // toolStripMenuModeAsk
            // 
            this.toolStripMenuModeAsk.Name = "toolStripMenuModeAsk";
            this.toolStripMenuModeAsk.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeAsk.Tag = "Ask";
            this.toolStripMenuModeAsk.Text = "Ask";
            // 
            // toolStripMenuModeIgnore
            // 
            this.toolStripMenuModeIgnore.Name = "toolStripMenuModeIgnore";
            this.toolStripMenuModeIgnore.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeIgnore.Tag = "Ignore";
            this.toolStripMenuModeIgnore.Text = "Ignore";
            // 
            // toolStripMenuModeTerminate
            // 
            this.toolStripMenuModeTerminate.Name = "toolStripMenuModeTerminate";
            this.toolStripMenuModeTerminate.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeTerminate.Tag = "Terminate";
            this.toolStripMenuModeTerminate.Text = "Terminate";
            // 
            // toolStripMenuModeTest
            // 
            this.toolStripMenuModeTest.Name = "toolStripMenuModeTest";
            this.toolStripMenuModeTest.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuModeTest.Tag = "Test";
            this.toolStripMenuModeTest.Text = "Test";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteItem.Location = new System.Drawing.Point(569, 14);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewItem.Location = new System.Drawing.Point(353, 14);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(100, 28);
            this.btnNewItem.TabIndex = 19;
            this.btnNewItem.Text = "New Tag...";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnNewSuperTag
            // 
            this.btnNewSuperTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewSuperTag.Location = new System.Drawing.Point(221, 14);
            this.btnNewSuperTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSuperTag.Name = "btnNewSuperTag";
            this.btnNewSuperTag.Size = new System.Drawing.Size(124, 28);
            this.btnNewSuperTag.TabIndex = 20;
            this.btnNewSuperTag.Text = "New SuperTag...";
            this.btnNewSuperTag.UseVisualStyleBackColor = true;
            this.btnNewSuperTag.Click += new System.EventHandler(this.btnNewSuperTag_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataListViewAllTags, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnEditor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 742);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnDuplicateItem);
            this.panel1.Controls.Add(this.btnNewItem);
            this.panel1.Controls.Add(this.btnNewSuperTag);
            this.panel1.Controls.Add(this.lblTotalItemsCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 695);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gBoxMembers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(682, 416);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(513, 323);
            this.panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 766);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1206, 794);
            this.Name = "FrmMain";
            this.Text = "Tag Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewAllTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewMembers)).EndInit();
            this.gBoxMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSelectedSuperTag)).EndInit();
            this.panel4.ResumeLayout(false);
            this.cMenuStripSelectedObject.ResumeLayout(false);
            this.cMenuStripSelectedSuperTag.ResumeLayout(false);
            this.cMenuStripMultipleObjects.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnEditor;
        private BrightIdeasSoftware.DataListView dataListViewAllTags;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn typeColumn;
        private BrightIdeasSoftware.OLVColumn commentColumn;
        private BrightIdeasSoftware.DataListView dataListViewMembers;
        private BrightIdeasSoftware.OLVColumn memberNameColumn;
        private BrightIdeasSoftware.OLVColumn memberTypeColumn;
        private System.Windows.Forms.Label lblSelectedSuperTagName;
        private System.Windows.Forms.GroupBox gBoxMembers;
        private System.Windows.Forms.ContextMenuStrip cMenuStripSelectedObject;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItemDuplicate;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuItemDelete;
        private System.Windows.Forms.Label lblTotalItemsCount;
        private System.Windows.Forms.Label lblMembersCount;
        private System.Windows.Forms.Button btnDuplicateMember;
        private System.Windows.Forms.Button btnDuplicateItem;
        private System.Windows.Forms.ImageList tagIcons;
        private System.Windows.Forms.ContextMenuStrip cMenuStripSelectedSuperTag;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSuperTagRename;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSuperTagDuplicate;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSuperTagDelete;
        private System.Windows.Forms.ContextMenuStrip cMenuStripMultipleObjects;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuDelete;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSpecial;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAlarmGroups;
        private BrightIdeasSoftware.OLVColumn memberCommentColumn;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuImport;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnNewSuperTag;
        private System.Windows.Forms.Button btnEditIoItems;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEditComments;
        private System.Windows.Forms.Button btnCopyComments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAccessNames;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTemplates;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSuperTagCreateTemplate;
        private System.Windows.Forms.ToolStripMenuItem tStripMenuSuperTagCreateIndirect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDBLoadMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeAsk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeReplace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeIgnore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeTerminate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModeTest;
        private System.Windows.Forms.ToolStripSeparator toolStripFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.PictureBox pBoxSelectedSuperTag;
    }
}


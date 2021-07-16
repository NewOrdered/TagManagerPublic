
namespace TagManager.UI.UserControls
{
    partial class AlarmGroupTreeViewPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeListViewAlarmGroups = new BrightIdeasSoftware.TreeListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeListViewAlarmGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListViewAlarmGroups
            // 
            this.treeListViewAlarmGroups.AllColumns.Add(this.olvColumnName);
            this.treeListViewAlarmGroups.CellEditUseWholeCell = false;
            this.treeListViewAlarmGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName});
            this.treeListViewAlarmGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListViewAlarmGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListViewAlarmGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.treeListViewAlarmGroups.FullRowSelect = true;
            this.treeListViewAlarmGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.treeListViewAlarmGroups.HideSelection = false;
            this.treeListViewAlarmGroups.Location = new System.Drawing.Point(0, 0);
            this.treeListViewAlarmGroups.Name = "treeListViewAlarmGroups";
            this.treeListViewAlarmGroups.ShowGroups = false;
            this.treeListViewAlarmGroups.ShowHeaderInAllViews = false;
            this.treeListViewAlarmGroups.Size = new System.Drawing.Size(336, 232);
            this.treeListViewAlarmGroups.SmallImageList = this.imageList1;
            this.treeListViewAlarmGroups.TabIndex = 16;
            this.treeListViewAlarmGroups.UseCompatibleStateImageBehavior = false;
            this.treeListViewAlarmGroups.View = System.Windows.Forms.View.Details;
            this.treeListViewAlarmGroups.VirtualMode = true;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AlarmGroupTreeViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListViewAlarmGroups);
            this.Name = "AlarmGroupTreeViewPanel";
            this.Size = new System.Drawing.Size(336, 232);
            ((System.ComponentModel.ISupportInitialize)(this.treeListViewAlarmGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView treeListViewAlarmGroups;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private System.Windows.Forms.ImageList imageList1;
    }
}

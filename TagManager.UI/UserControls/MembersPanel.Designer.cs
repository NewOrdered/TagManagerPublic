
namespace TagManager.UI.UserControls
{
    partial class MembersPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataListViewMembers = new BrightIdeasSoftware.DataListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "<Name>";
            // 
            // dataListViewMembers
            // 
            this.dataListViewMembers.AllColumns.Add(this.nameColumn);
            this.dataListViewMembers.AllColumns.Add(this.typeColumn);
            this.dataListViewMembers.AutoGenerateColumns = false;
            this.dataListViewMembers.CellEditUseWholeCell = false;
            this.dataListViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.typeColumn});
            this.dataListViewMembers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListViewMembers.DataSource = null;
            this.dataListViewMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.dataListViewMembers.HideSelection = false;
            this.dataListViewMembers.Location = new System.Drawing.Point(15, 39);
            this.dataListViewMembers.Name = "dataListViewMembers";
            this.dataListViewMembers.ShowGroups = false;
            this.dataListViewMembers.ShowHeaderInAllViews = false;
            this.dataListViewMembers.Size = new System.Drawing.Size(249, 157);
            this.dataListViewMembers.TabIndex = 1;
            this.dataListViewMembers.UseCompatibleStateImageBehavior = false;
            this.dataListViewMembers.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.Width = 100;
            // 
            // typeColumn
            // 
            this.typeColumn.AspectName = "Type";
            this.typeColumn.Width = 119;
            // 
            // MembersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataListViewMembers);
            this.Controls.Add(this.label1);
            this.Name = "MembersPanel";
            this.Size = new System.Drawing.Size(274, 217);
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataListView dataListViewMembers;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn typeColumn;
    }
}

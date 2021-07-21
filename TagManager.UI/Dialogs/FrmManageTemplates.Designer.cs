
namespace TagManager.UI.Dialogs
{
    partial class FrmManageTemplates
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
            this.dataListViewSuperTagTemplates = new BrightIdeasSoftware.DataListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMembers = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnComment = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.modifyButtonsPanel = new TagManager.UI.UserControls.ModifyButtonsPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewSuperTagTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListViewSuperTagTemplates
            // 
            this.dataListViewSuperTagTemplates.AllColumns.Add(this.olvColumnName);
            this.dataListViewSuperTagTemplates.AllColumns.Add(this.olvColumnMembers);
            this.dataListViewSuperTagTemplates.AllColumns.Add(this.olvColumnComment);
            this.dataListViewSuperTagTemplates.CellEditUseWholeCell = false;
            this.dataListViewSuperTagTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnMembers,
            this.olvColumnComment});
            this.dataListViewSuperTagTemplates.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListViewSuperTagTemplates.DataSource = null;
            this.dataListViewSuperTagTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dataListViewSuperTagTemplates.FullRowSelect = true;
            this.dataListViewSuperTagTemplates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataListViewSuperTagTemplates.HideSelection = false;
            this.dataListViewSuperTagTemplates.Location = new System.Drawing.Point(8, 8);
            this.dataListViewSuperTagTemplates.MultiSelect = false;
            this.dataListViewSuperTagTemplates.Name = "dataListViewSuperTagTemplates";
            this.dataListViewSuperTagTemplates.ShowGroups = false;
            this.dataListViewSuperTagTemplates.ShowHeaderInAllViews = false;
            this.dataListViewSuperTagTemplates.Size = new System.Drawing.Size(427, 396);
            this.dataListViewSuperTagTemplates.TabIndex = 1;
            this.dataListViewSuperTagTemplates.UseCompatibleStateImageBehavior = false;
            this.dataListViewSuperTagTemplates.UseHotItem = true;
            this.dataListViewSuperTagTemplates.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 150;
            // 
            // olvColumnMembers
            // 
            this.olvColumnMembers.AspectName = "MembersCount";
            this.olvColumnMembers.Text = "Members";
            this.olvColumnMembers.Width = 70;
            // 
            // olvColumnComment
            // 
            this.olvColumnComment.AspectName = "Comment";
            this.olvColumnComment.FillsFreeSpace = true;
            this.olvColumnComment.Text = "Comment";
            this.olvColumnComment.Width = 200;
            // 
            // modifyButtonsPanel
            // 
            this.modifyButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.modifyButtonsPanel.Location = new System.Drawing.Point(442, 8);
            this.modifyButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButtonsPanel.Name = "modifyButtonsPanel";
            this.modifyButtonsPanel.Size = new System.Drawing.Size(100, 168);
            this.modifyButtonsPanel.TabIndex = 2;
            // 
            // FrmManageTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 416);
            this.ControlBox = false;
            this.Controls.Add(this.modifyButtonsPanel);
            this.Controls.Add(this.dataListViewSuperTagTemplates);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageTemplates";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Templates";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewSuperTagTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.DataListView dataListViewSuperTagTemplates;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnMembers;
        private BrightIdeasSoftware.OLVColumn olvColumnComment;
        private UserControls.ModifyButtonsPanel modifyButtonsPanel;
    }
}
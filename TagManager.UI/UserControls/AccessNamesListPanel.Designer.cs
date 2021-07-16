
namespace TagManager.UI.UserControls
{
    partial class AccessNamesListPanel
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataListViewAccessNames = new BrightIdeasSoftware.DataListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnNode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnApplication = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTopic = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewAccessNames)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataListViewAccessNames
            // 
            this.dataListViewAccessNames.AllColumns.Add(this.olvColumnName);
            this.dataListViewAccessNames.AllColumns.Add(this.olvColumnNode);
            this.dataListViewAccessNames.AllColumns.Add(this.olvColumnApplication);
            this.dataListViewAccessNames.AllColumns.Add(this.olvColumnTopic);
            this.dataListViewAccessNames.CellEditUseWholeCell = false;
            this.dataListViewAccessNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnNode,
            this.olvColumnApplication,
            this.olvColumnTopic});
            this.dataListViewAccessNames.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListViewAccessNames.DataSource = null;
            this.dataListViewAccessNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListViewAccessNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dataListViewAccessNames.FullRowSelect = true;
            this.dataListViewAccessNames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataListViewAccessNames.HideSelection = false;
            this.dataListViewAccessNames.Location = new System.Drawing.Point(0, 0);
            this.dataListViewAccessNames.MultiSelect = false;
            this.dataListViewAccessNames.Name = "dataListViewAccessNames";
            this.dataListViewAccessNames.ShowGroups = false;
            this.dataListViewAccessNames.ShowHeaderInAllViews = false;
            this.dataListViewAccessNames.Size = new System.Drawing.Size(384, 265);
            this.dataListViewAccessNames.TabIndex = 0;
            this.dataListViewAccessNames.UseCompatibleStateImageBehavior = false;
            this.dataListViewAccessNames.UseHotItem = true;
            this.dataListViewAccessNames.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 100;
            // 
            // olvColumnNode
            // 
            this.olvColumnNode.AspectName = "NodeName";
            this.olvColumnNode.Text = "Node";
            this.olvColumnNode.Width = 100;
            // 
            // olvColumnApplication
            // 
            this.olvColumnApplication.AspectName = "Application";
            this.olvColumnApplication.Text = "Application";
            this.olvColumnApplication.Width = 100;
            // 
            // olvColumnTopic
            // 
            this.olvColumnTopic.AspectName = "Topic";
            this.olvColumnTopic.FillsFreeSpace = true;
            this.olvColumnTopic.Text = "Topic";
            this.olvColumnTopic.Width = 70;
            // 
            // AccessNamesListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataListViewAccessNames);
            this.Name = "AccessNamesListPanel";
            this.Size = new System.Drawing.Size(384, 265);
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewAccessNames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.DataListView dataListViewAccessNames;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnNode;
        private BrightIdeasSoftware.OLVColumn olvColumnApplication;
        private BrightIdeasSoftware.OLVColumn olvColumnTopic;
    }
}

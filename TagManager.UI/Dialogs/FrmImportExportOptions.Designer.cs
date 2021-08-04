
namespace TagManager.UI.Dialogs
{
    partial class FrmImportExportOptions
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
            this.okCancelButtonsPanel = new TagManager.UI.UserControls.OkCancelButtonsPanel();
            this.chBoxAlarmGroups = new System.Windows.Forms.CheckBox();
            this.chBoxAccessNames = new System.Windows.Forms.CheckBox();
            this.chBoxTags = new System.Windows.Forms.CheckBox();
            this.chBoxIndirectTags = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okCancelButtonsPanel
            // 
            this.okCancelButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.okCancelButtonsPanel.Location = new System.Drawing.Point(256, 13);
            this.okCancelButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.okCancelButtonsPanel.Name = "okCancelButtonsPanel";
            this.okCancelButtonsPanel.Size = new System.Drawing.Size(100, 63);
            this.okCancelButtonsPanel.TabIndex = 0;
            // 
            // chBoxAlarmGroups
            // 
            this.chBoxAlarmGroups.AutoSize = true;
            this.chBoxAlarmGroups.Location = new System.Drawing.Point(32, 43);
            this.chBoxAlarmGroups.Name = "chBoxAlarmGroups";
            this.chBoxAlarmGroups.Size = new System.Drawing.Size(109, 20);
            this.chBoxAlarmGroups.TabIndex = 1;
            this.chBoxAlarmGroups.Text = "Alarm Groups";
            this.chBoxAlarmGroups.UseVisualStyleBackColor = true;
            // 
            // chBoxAccessNames
            // 
            this.chBoxAccessNames.AutoSize = true;
            this.chBoxAccessNames.Location = new System.Drawing.Point(32, 69);
            this.chBoxAccessNames.Name = "chBoxAccessNames";
            this.chBoxAccessNames.Size = new System.Drawing.Size(119, 20);
            this.chBoxAccessNames.TabIndex = 2;
            this.chBoxAccessNames.Text = "Access Names";
            this.chBoxAccessNames.UseVisualStyleBackColor = true;
            // 
            // chBoxTags
            // 
            this.chBoxTags.AutoSize = true;
            this.chBoxTags.Location = new System.Drawing.Point(32, 95);
            this.chBoxTags.Name = "chBoxTags";
            this.chBoxTags.Size = new System.Drawing.Size(59, 20);
            this.chBoxTags.TabIndex = 3;
            this.chBoxTags.Text = "Tags";
            this.chBoxTags.UseVisualStyleBackColor = true;
            // 
            // chBoxIndirectTags
            // 
            this.chBoxIndirectTags.AutoSize = true;
            this.chBoxIndirectTags.Location = new System.Drawing.Point(32, 121);
            this.chBoxIndirectTags.Name = "chBoxIndirectTags";
            this.chBoxIndirectTags.Size = new System.Drawing.Size(105, 20);
            this.chBoxIndirectTags.TabIndex = 4;
            this.chBoxIndirectTags.Text = "Indirect Tags";
            this.chBoxIndirectTags.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select options: ";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(32, 156);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // FrmImportExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 214);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chBoxIndirectTags);
            this.Controls.Add(this.chBoxTags);
            this.Controls.Add(this.chBoxAccessNames);
            this.Controls.Add(this.chBoxAlarmGroups);
            this.Controls.Add(this.okCancelButtonsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportExportOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "< Import / Export Options >";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.OkCancelButtonsPanel okCancelButtonsPanel;
        private System.Windows.Forms.CheckBox chBoxAlarmGroups;
        private System.Windows.Forms.CheckBox chBoxAccessNames;
        private System.Windows.Forms.CheckBox chBoxTags;
        private System.Windows.Forms.CheckBox chBoxIndirectTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAll;
    }
}
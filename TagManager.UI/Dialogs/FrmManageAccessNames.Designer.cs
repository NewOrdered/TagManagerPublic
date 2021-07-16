
namespace TagManager.UI.Dialogs
{
    partial class FrmManageAccessNames
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
            this.accessNamesListPanel = new TagManager.UI.UserControls.AccessNamesListPanel();
            this.okCancelButtonsPanel = new TagManager.UI.UserControls.OkCancelButtonsPanel();
            this.modifyButtonsPanel = new TagManager.UI.UserControls.ModifyButtonsPanel();
            this.SuspendLayout();
            // 
            // accessNamesListPanel
            // 
            this.accessNamesListPanel.Location = new System.Drawing.Point(14, 14);
            this.accessNamesListPanel.Margin = new System.Windows.Forms.Padding(5);
            this.accessNamesListPanel.Name = "accessNamesListPanel";
            this.accessNamesListPanel.Size = new System.Drawing.Size(399, 307);
            this.accessNamesListPanel.TabIndex = 0;
            // 
            // okCancelButtonsPanel
            // 
            this.okCancelButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.okCancelButtonsPanel.Location = new System.Drawing.Point(422, 14);
            this.okCancelButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.okCancelButtonsPanel.Name = "okCancelButtonsPanel";
            this.okCancelButtonsPanel.Size = new System.Drawing.Size(100, 63);
            this.okCancelButtonsPanel.TabIndex = 5;
            // 
            // modifyButtonsPanel
            // 
            this.modifyButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.modifyButtonsPanel.Location = new System.Drawing.Point(422, 13);
            this.modifyButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButtonsPanel.Name = "modifyButtonsPanel";
            this.modifyButtonsPanel.Size = new System.Drawing.Size(100, 168);
            this.modifyButtonsPanel.TabIndex = 6;
            // 
            // FrmManageAccessNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 332);
            this.ControlBox = false;
            this.Controls.Add(this.modifyButtonsPanel);
            this.Controls.Add(this.okCancelButtonsPanel);
            this.Controls.Add(this.accessNamesListPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageAccessNames";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Access Names";
            this.Load += new System.EventHandler(this.FrmManageAccessNames_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AccessNamesListPanel accessNamesListPanel;
        private UserControls.OkCancelButtonsPanel okCancelButtonsPanel;
        private UserControls.ModifyButtonsPanel modifyButtonsPanel;
    }
}
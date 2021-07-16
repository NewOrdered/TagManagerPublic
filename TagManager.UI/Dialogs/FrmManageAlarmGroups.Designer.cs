
namespace TagManager.UI.Dialogs
{
    partial class FrmManageAlarmGroups
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
            this.alarmGroupTreeViewPanel = new TagManager.UI.UserControls.AlarmGroupTreeViewPanel();
            this.okCancelButtonsPanel = new TagManager.UI.UserControls.OkCancelButtonsPanel();
            this.modifyButtonsPanel = new TagManager.UI.UserControls.ModifyButtonsPanel();
            this.SuspendLayout();
            // 
            // alarmGroupTreeViewPanel
            // 
            this.alarmGroupTreeViewPanel.Location = new System.Drawing.Point(13, 13);
            this.alarmGroupTreeViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.alarmGroupTreeViewPanel.Name = "alarmGroupTreeViewPanel";
            this.alarmGroupTreeViewPanel.Size = new System.Drawing.Size(403, 383);
            this.alarmGroupTreeViewPanel.TabIndex = 2;
            // 
            // okCancelButtonsPanel
            // 
            this.okCancelButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.okCancelButtonsPanel.Location = new System.Drawing.Point(424, 13);
            this.okCancelButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.okCancelButtonsPanel.Name = "okCancelButtonsPanel";
            this.okCancelButtonsPanel.Size = new System.Drawing.Size(100, 63);
            this.okCancelButtonsPanel.TabIndex = 7;
            // 
            // modifyButtonsPanel
            // 
            this.modifyButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.modifyButtonsPanel.Location = new System.Drawing.Point(424, 13);
            this.modifyButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButtonsPanel.Name = "modifyButtonsPanel";
            this.modifyButtonsPanel.Size = new System.Drawing.Size(100, 168);
            this.modifyButtonsPanel.TabIndex = 8;
            // 
            // FrmManageAlarmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 395);
            this.ControlBox = false;
            this.Controls.Add(this.modifyButtonsPanel);
            this.Controls.Add(this.okCancelButtonsPanel);
            this.Controls.Add(this.alarmGroupTreeViewPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageAlarmGroups";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarm Groups";
            this.Load += new System.EventHandler(this.FrmManageAlarmGroups_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.AlarmGroupTreeViewPanel alarmGroupTreeViewPanel;
        private UserControls.OkCancelButtonsPanel okCancelButtonsPanel;
        private UserControls.ModifyButtonsPanel modifyButtonsPanel;
    }
}

namespace TagManager.UI.UserControls
{
    partial class IoMsgTagPanel
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
            this.ioPanel = new TagManager.UI.UserControls.IoPanel();
            this.msgPanel = new TagManager.UI.UserControls.MsgPanel();
            this.commonPanel = new TagManager.UI.UserControls.CommonPanel();
            this.SuspendLayout();
            // 
            // ioPanel
            // 
            this.ioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioPanel.Location = new System.Drawing.Point(8, 270);
            this.ioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioPanel.Name = "ioPanel";
            this.ioPanel.Size = new System.Drawing.Size(495, 64);
            this.ioPanel.TabIndex = 11;
            // 
            // msgPanel
            // 
            this.msgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.msgPanel.Location = new System.Drawing.Point(8, 195);
            this.msgPanel.Margin = new System.Windows.Forms.Padding(4);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(495, 67);
            this.msgPanel.TabIndex = 10;
            // 
            // commonPanel
            // 
            this.commonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.commonPanel.Location = new System.Drawing.Point(8, 27);
            this.commonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.commonPanel.Name = "commonPanel";
            this.commonPanel.Size = new System.Drawing.Size(495, 160);
            this.commonPanel.TabIndex = 9;
            // 
            // IoMsgTagPanelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.ioPanel);
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.commonPanel);
            this.Name = "IoMsgTagPanelNew";
            this.Controls.SetChildIndex(this.commonPanel, 0);
            this.Controls.SetChildIndex(this.msgPanel, 0);
            this.Controls.SetChildIndex(this.ioPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IoPanel ioPanel;
        private MsgPanel msgPanel;
        private CommonPanel commonPanel;
    }
}

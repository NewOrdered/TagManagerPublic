
namespace TagManager.UI.UserControls
{
    partial class IoAnalogTagPanel
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
            this.analogPanel = new TagManager.UI.UserControls.AnalogPanel();
            this.commonPanel = new TagManager.UI.UserControls.CommonPanel();
            this.ioPanel = new TagManager.UI.UserControls.IoPanel();
            this.ioAnalogPanel = new TagManager.UI.UserControls.IoAnalogPanel();
            this.SuspendLayout();
            // 
            // analogPanel
            // 
            this.analogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.analogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.analogPanel.Location = new System.Drawing.Point(8, 192);
            this.analogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.analogPanel.Name = "analogPanel";
            this.analogPanel.Size = new System.Drawing.Size(495, 64);
            this.analogPanel.TabIndex = 10;
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
            // ioPanel
            // 
            this.ioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioPanel.Location = new System.Drawing.Point(8, 300);
            this.ioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioPanel.Name = "ioPanel";
            this.ioPanel.Size = new System.Drawing.Size(495, 64);
            this.ioPanel.TabIndex = 12;
            // 
            // ioAnalogPanel
            // 
            this.ioAnalogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioAnalogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioAnalogPanel.Location = new System.Drawing.Point(8, 261);
            this.ioAnalogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioAnalogPanel.Name = "ioAnalogPanel";
            this.ioAnalogPanel.Size = new System.Drawing.Size(495, 33);
            this.ioAnalogPanel.TabIndex = 11;
            // 
            // IoAnalogTagPanelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.ioPanel);
            this.Controls.Add(this.ioAnalogPanel);
            this.Controls.Add(this.analogPanel);
            this.Controls.Add(this.commonPanel);
            this.Name = "IoAnalogTagPanelNew";
            this.Controls.SetChildIndex(this.commonPanel, 0);
            this.Controls.SetChildIndex(this.analogPanel, 0);
            this.Controls.SetChildIndex(this.ioAnalogPanel, 0);
            this.Controls.SetChildIndex(this.ioPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogPanel analogPanel;
        private CommonPanel commonPanel;
        private IoPanel ioPanel;
        private IoAnalogPanel ioAnalogPanel;
    }
}

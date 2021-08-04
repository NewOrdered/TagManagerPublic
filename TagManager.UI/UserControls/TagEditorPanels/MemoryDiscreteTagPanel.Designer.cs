
namespace TagManager.UI.UserControls
{
    partial class MemoryDiscreteTagPanel
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
            this.discretePanel = new TagManager.UI.UserControls.DiscretePanel();
            this.commonPanel = new TagManager.UI.UserControls.CommonPanel();
            this.SuspendLayout();
            // 
            // discretePanel
            // 
            this.discretePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discretePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.discretePanel.Location = new System.Drawing.Point(8, 194);
            this.discretePanel.Margin = new System.Windows.Forms.Padding(4);
            this.discretePanel.Name = "discretePanel";
            this.discretePanel.Size = new System.Drawing.Size(495, 98);
            this.discretePanel.TabIndex = 10;
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
            // MemoryDiscreteTagPanelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.discretePanel);
            this.Controls.Add(this.commonPanel);
            this.Name = "MemoryDiscreteTagPanelNew";
            this.Controls.SetChildIndex(this.commonPanel, 0);
            this.Controls.SetChildIndex(this.discretePanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiscretePanel discretePanel;
        private CommonPanel commonPanel;
    }
}

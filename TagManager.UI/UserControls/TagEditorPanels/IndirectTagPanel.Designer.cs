
namespace TagManager.UI.UserControls
{
    partial class IndirectTagPanel
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
            this.indirectPanel = new TagManager.UI.UserControls.IndirectPanel();
            this.SuspendLayout();
            // 
            // indirectPanel
            // 
            this.indirectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indirectPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.indirectPanel.Location = new System.Drawing.Point(8, 27);
            this.indirectPanel.Margin = new System.Windows.Forms.Padding(4);
            this.indirectPanel.Name = "indirectPanel";
            this.indirectPanel.Size = new System.Drawing.Size(495, 160);
            this.indirectPanel.TabIndex = 9;
            // 
            // IndirectTagPanelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.indirectPanel);
            this.Name = "IndirectTagPanelNew";
            this.Controls.SetChildIndex(this.indirectPanel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IndirectPanel indirectPanel;
    }
}

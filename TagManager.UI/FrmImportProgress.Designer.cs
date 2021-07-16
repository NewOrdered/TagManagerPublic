
namespace TagManager.UI
{
    partial class FrmImportProgress
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
            this.pBarImport = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pBarImport
            // 
            this.pBarImport.Location = new System.Drawing.Point(12, 12);
            this.pBarImport.Name = "pBarImport";
            this.pBarImport.Size = new System.Drawing.Size(390, 53);
            this.pBarImport.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBarImport.TabIndex = 0;
            // 
            // FrmImportProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 77);
            this.ControlBox = false;
            this.Controls.Add(this.pBarImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmImportProgress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.FrmImportProgress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBarImport;
    }
}
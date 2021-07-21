
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblType = new System.Windows.Forms.Label();
            this.indirectPanel = new TagManager.UI.UserControls.IndirectPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 7);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 16);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "<Type>";
            // 
            // indirectPanel
            // 
            this.indirectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indirectPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.indirectPanel.Location = new System.Drawing.Point(8, 27);
            this.indirectPanel.Margin = new System.Windows.Forms.Padding(4);
            this.indirectPanel.Name = "indirectPanel";
            this.indirectPanel.Size = new System.Drawing.Size(495, 160);
            this.indirectPanel.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(404, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IndirectTagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.indirectPanel);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndirectTagPanel";
            this.Size = new System.Drawing.Size(513, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private IndirectPanel indirectPanel;
        private System.Windows.Forms.Button btnSave;
    }
}

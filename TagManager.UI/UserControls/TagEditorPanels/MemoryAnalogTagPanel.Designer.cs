
namespace TagManager.UI.UserControls
{
    partial class MemoryAnalogTagPanel
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
            this.commonPanel = new TagManager.UI.UserControls.CommonPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.analogPanel = new TagManager.UI.UserControls.AnalogPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commonPanel
            // 
            this.commonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.commonPanel.Location = new System.Drawing.Point(8, 27);
            this.commonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.commonPanel.Name = "commonPanel";
            this.commonPanel.Size = new System.Drawing.Size(495, 160);
            this.commonPanel.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 7);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "<Type>";
            // 
            // analogPanel
            // 
            this.analogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.analogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.analogPanel.Location = new System.Drawing.Point(8, 192);
            this.analogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.analogPanel.Name = "analogPanel";
            this.analogPanel.Size = new System.Drawing.Size(495, 64);
            this.analogPanel.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(404, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MemoryIntegerTagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.analogPanel);
            this.Controls.Add(this.commonPanel);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemoryIntegerTagPanel";
            this.Size = new System.Drawing.Size(513, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommonPanel commonPanel;
        private System.Windows.Forms.Label lblType;
        private AnalogPanel analogPanel;
        private System.Windows.Forms.Button btnSave;
    }
}

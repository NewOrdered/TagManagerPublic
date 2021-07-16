
namespace TagManager.UI.UserControls
{
    partial class MsgPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxInitialMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownMaxLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Message:";
            // 
            // tBoxInitialMessage
            // 
            this.tBoxInitialMessage.Location = new System.Drawing.Point(120, 9);
            this.tBoxInitialMessage.MaxLength = 131;
            this.tBoxInitialMessage.Name = "tBoxInitialMessage";
            this.tBoxInitialMessage.Size = new System.Drawing.Size(358, 22);
            this.tBoxInitialMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Length:";
            // 
            // numUpDownMaxLength
            // 
            this.numUpDownMaxLength.Location = new System.Drawing.Point(120, 37);
            this.numUpDownMaxLength.Maximum = new decimal(new int[] {
            131,
            0,
            0,
            0});
            this.numUpDownMaxLength.Name = "numUpDownMaxLength";
            this.numUpDownMaxLength.Size = new System.Drawing.Size(57, 22);
            this.numUpDownMaxLength.TabIndex = 3;
            this.numUpDownMaxLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MsgPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numUpDownMaxLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxInitialMessage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MsgPanel";
            this.Size = new System.Drawing.Size(496, 67);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxInitialMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownMaxLength;
    }
}

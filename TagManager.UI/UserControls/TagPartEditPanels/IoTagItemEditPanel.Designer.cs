
namespace TagManager.UI.UserControls
{
    partial class IoTagItemEditPanel
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
            this.lblTagName = new System.Windows.Forms.Label();
            this.lblTagType = new System.Windows.Forms.Label();
            this.tBoxItemName = new System.Windows.Forms.TextBox();
            this.btnAccessName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Location = new System.Drawing.Point(4, 3);
            this.lblTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(59, 16);
            this.lblTagName.TabIndex = 0;
            this.lblTagName.Text = "<Name>";
            // 
            // lblTagType
            // 
            this.lblTagType.AutoSize = true;
            this.lblTagType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTagType.Location = new System.Drawing.Point(143, 5);
            this.lblTagType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagType.Name = "lblTagType";
            this.lblTagType.Size = new System.Drawing.Size(43, 13);
            this.lblTagType.TabIndex = 1;
            this.lblTagType.Text = "<Type>";
            // 
            // tBoxItemName
            // 
            this.tBoxItemName.HideSelection = false;
            this.tBoxItemName.Location = new System.Drawing.Point(345, 0);
            this.tBoxItemName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxItemName.Name = "tBoxItemName";
            this.tBoxItemName.Size = new System.Drawing.Size(172, 22);
            this.tBoxItemName.TabIndex = 2;
            // 
            // btnAccessName
            // 
            this.btnAccessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAccessName.Location = new System.Drawing.Point(245, 0);
            this.btnAccessName.Name = "btnAccessName";
            this.btnAccessName.Size = new System.Drawing.Size(93, 22);
            this.btnAccessName.TabIndex = 3;
            this.btnAccessName.Text = "<Access Name>";
            this.btnAccessName.UseVisualStyleBackColor = true;
            this.btnAccessName.Click += new System.EventHandler(this.btnAccessName_Click);
            // 
            // IoTagItemEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAccessName);
            this.Controls.Add(this.tBoxItemName);
            this.Controls.Add(this.lblTagType);
            this.Controls.Add(this.lblTagName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IoTagItemEditPanel";
            this.Size = new System.Drawing.Size(581, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.Label lblTagType;
        private System.Windows.Forms.TextBox tBoxItemName;
        private System.Windows.Forms.Button btnAccessName;
    }
}

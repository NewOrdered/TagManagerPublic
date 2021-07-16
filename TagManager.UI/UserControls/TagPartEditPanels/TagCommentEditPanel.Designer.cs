
namespace TagManager.UI.UserControls
{
    partial class TagCommentEditPanel
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
            this.tBoxAlarmComment = new System.Windows.Forms.TextBox();
            this.lblTagType = new System.Windows.Forms.Label();
            this.lblTagName = new System.Windows.Forms.Label();
            this.btnAlarmGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxAlarmComment
            // 
            this.tBoxAlarmComment.HideSelection = false;
            this.tBoxAlarmComment.Location = new System.Drawing.Point(255, 0);
            this.tBoxAlarmComment.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxAlarmComment.Name = "tBoxAlarmComment";
            this.tBoxAlarmComment.Size = new System.Drawing.Size(326, 22);
            this.tBoxAlarmComment.TabIndex = 5;
            // 
            // lblTagType
            // 
            this.lblTagType.AutoSize = true;
            this.lblTagType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTagType.Location = new System.Drawing.Point(143, 5);
            this.lblTagType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagType.Name = "lblTagType";
            this.lblTagType.Size = new System.Drawing.Size(43, 13);
            this.lblTagType.TabIndex = 4;
            this.lblTagType.Text = "<Type>";
            this.lblTagType.Visible = false;
            // 
            // lblTagName
            // 
            this.lblTagName.AutoSize = true;
            this.lblTagName.Location = new System.Drawing.Point(4, 3);
            this.lblTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagName.Name = "lblTagName";
            this.lblTagName.Size = new System.Drawing.Size(59, 16);
            this.lblTagName.TabIndex = 3;
            this.lblTagName.Text = "<Name>";
            // 
            // btnAlarmGroup
            // 
            this.btnAlarmGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAlarmGroup.Location = new System.Drawing.Point(146, 0);
            this.btnAlarmGroup.Name = "btnAlarmGroup";
            this.btnAlarmGroup.Size = new System.Drawing.Size(102, 22);
            this.btnAlarmGroup.TabIndex = 6;
            this.btnAlarmGroup.Text = "<Alarm Group>";
            this.btnAlarmGroup.UseVisualStyleBackColor = true;
            this.btnAlarmGroup.Click += new System.EventHandler(this.btnAlarmGroup_Click);
            // 
            // TagCommentEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlarmGroup);
            this.Controls.Add(this.tBoxAlarmComment);
            this.Controls.Add(this.lblTagType);
            this.Controls.Add(this.lblTagName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TagCommentEditPanel";
            this.Size = new System.Drawing.Size(581, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxAlarmComment;
        private System.Windows.Forms.Label lblTagType;
        private System.Windows.Forms.Label lblTagName;
        private System.Windows.Forms.Button btnAlarmGroup;
    }
}

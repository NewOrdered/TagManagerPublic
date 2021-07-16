
namespace TagManager.UI.Dialogs
{
    partial class FrmAddModifyAlarmGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxGroupName = new System.Windows.Forms.TextBox();
            this.btnSelectParentGroup = new System.Windows.Forms.Button();
            this.lblParentGroup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name:";
            // 
            // tBoxGroupName
            // 
            this.tBoxGroupName.Location = new System.Drawing.Point(112, 8);
            this.tBoxGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxGroupName.MaxLength = 50;
            this.tBoxGroupName.Name = "tBoxGroupName";
            this.tBoxGroupName.Size = new System.Drawing.Size(256, 22);
            this.tBoxGroupName.TabIndex = 1;
            // 
            // btnSelectParentGroup
            // 
            this.btnSelectParentGroup.Location = new System.Drawing.Point(16, 38);
            this.btnSelectParentGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectParentGroup.Name = "btnSelectParentGroup";
            this.btnSelectParentGroup.Size = new System.Drawing.Size(135, 28);
            this.btnSelectParentGroup.TabIndex = 2;
            this.btnSelectParentGroup.Text = "Parent Group...";
            this.btnSelectParentGroup.UseVisualStyleBackColor = true;
            this.btnSelectParentGroup.Click += new System.EventHandler(this.btnSelectParentGroup_Click);
            // 
            // lblParentGroup
            // 
            this.lblParentGroup.AutoSize = true;
            this.lblParentGroup.Location = new System.Drawing.Point(159, 44);
            this.lblParentGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentGroup.Name = "lblParentGroup";
            this.lblParentGroup.Size = new System.Drawing.Size(101, 16);
            this.lblParentGroup.TabIndex = 3;
            this.lblParentGroup.Text = "<Parent Group>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comment:";
            // 
            // tBoxComment
            // 
            this.tBoxComment.Location = new System.Drawing.Point(112, 77);
            this.tBoxComment.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxComment.MaxLength = 130;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(393, 22);
            this.tBoxComment.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(555, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 38);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddModifyAlarmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 109);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblParentGroup);
            this.Controls.Add(this.btnSelectParentGroup);
            this.Controls.Add(this.tBoxGroupName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddModifyAlarmGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "<Add / Modify Alarm Group>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxGroupName;
        private System.Windows.Forms.Button btnSelectParentGroup;
        private System.Windows.Forms.Label lblParentGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
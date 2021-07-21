
namespace TagManager.UI.Dialogs
{
    partial class FrmNewSuperTag
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxParameters = new System.Windows.Forms.GroupBox();
            this.rBtnUseTemplate = new System.Windows.Forms.RadioButton();
            this.rBtnEmpty = new System.Windows.Forms.RadioButton();
            this.cBoxTemplates = new System.Windows.Forms.ComboBox();
            this.gBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(314, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(68, 6);
            this.tBoxName.MaxLength = 50;
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(228, 22);
            this.tBoxName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // gBoxParameters
            // 
            this.gBoxParameters.Controls.Add(this.rBtnUseTemplate);
            this.gBoxParameters.Controls.Add(this.rBtnEmpty);
            this.gBoxParameters.Controls.Add(this.cBoxTemplates);
            this.gBoxParameters.Location = new System.Drawing.Point(16, 40);
            this.gBoxParameters.Name = "gBoxParameters";
            this.gBoxParameters.Size = new System.Drawing.Size(280, 111);
            this.gBoxParameters.TabIndex = 9;
            this.gBoxParameters.TabStop = false;
            this.gBoxParameters.Text = "Parameters";
            // 
            // rBtnUseTemplate
            // 
            this.rBtnUseTemplate.AutoSize = true;
            this.rBtnUseTemplate.Location = new System.Drawing.Point(19, 47);
            this.rBtnUseTemplate.Name = "rBtnUseTemplate";
            this.rBtnUseTemplate.Size = new System.Drawing.Size(109, 20);
            this.rBtnUseTemplate.TabIndex = 12;
            this.rBtnUseTemplate.TabStop = true;
            this.rBtnUseTemplate.Text = "Use template:";
            this.rBtnUseTemplate.UseVisualStyleBackColor = true;
            // 
            // rBtnEmpty
            // 
            this.rBtnEmpty.AutoSize = true;
            this.rBtnEmpty.Location = new System.Drawing.Point(19, 21);
            this.rBtnEmpty.Name = "rBtnEmpty";
            this.rBtnEmpty.Size = new System.Drawing.Size(64, 20);
            this.rBtnEmpty.TabIndex = 11;
            this.rBtnEmpty.TabStop = true;
            this.rBtnEmpty.Text = "Empty";
            this.rBtnEmpty.UseVisualStyleBackColor = true;
            // 
            // cBoxTemplates
            // 
            this.cBoxTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTemplates.FormattingEnabled = true;
            this.cBoxTemplates.Location = new System.Drawing.Point(19, 73);
            this.cBoxTemplates.Name = "cBoxTemplates";
            this.cBoxTemplates.Size = new System.Drawing.Size(202, 24);
            this.cBoxTemplates.TabIndex = 10;
            // 
            // FrmNewSuperTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 161);
            this.Controls.Add(this.gBoxParameters);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewSuperTag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Super Tag";
            this.gBoxParameters.ResumeLayout(false);
            this.gBoxParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxParameters;
        private System.Windows.Forms.ComboBox cBoxTemplates;
        private System.Windows.Forms.RadioButton rBtnUseTemplate;
        private System.Windows.Forms.RadioButton rBtnEmpty;
    }
}
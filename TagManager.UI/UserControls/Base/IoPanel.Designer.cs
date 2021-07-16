
namespace TagManager.UI.UserControls
{
    partial class IoPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxAccessName = new System.Windows.Forms.TextBox();
            this.cBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.btnShowSelectAccessNameDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxItemName
            // 
            this.tBoxItemName.Location = new System.Drawing.Point(52, 35);
            this.tBoxItemName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxItemName.MaxLength = 131;
            this.tBoxItemName.Name = "tBoxItemName";
            this.tBoxItemName.Size = new System.Drawing.Size(397, 22);
            this.tBoxItemName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item:";
            // 
            // tBoxAccessName
            // 
            this.tBoxAccessName.Location = new System.Drawing.Point(143, 6);
            this.tBoxAccessName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxAccessName.MaxLength = 50;
            this.tBoxAccessName.Name = "tBoxAccessName";
            this.tBoxAccessName.Size = new System.Drawing.Size(181, 22);
            this.tBoxAccessName.TabIndex = 0;
            // 
            // cBoxReadOnly
            // 
            this.cBoxReadOnly.AutoSize = true;
            this.cBoxReadOnly.Location = new System.Drawing.Point(341, 8);
            this.cBoxReadOnly.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxReadOnly.Name = "cBoxReadOnly";
            this.cBoxReadOnly.Size = new System.Drawing.Size(91, 20);
            this.cBoxReadOnly.TabIndex = 1;
            this.cBoxReadOnly.Text = "Read Only";
            this.cBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // btnShowSelectAccessNameDialog
            // 
            this.btnShowSelectAccessNameDialog.Location = new System.Drawing.Point(7, 3);
            this.btnShowSelectAccessNameDialog.Name = "btnShowSelectAccessNameDialog";
            this.btnShowSelectAccessNameDialog.Size = new System.Drawing.Size(129, 28);
            this.btnShowSelectAccessNameDialog.TabIndex = 19;
            this.btnShowSelectAccessNameDialog.Text = "Access Name...";
            this.btnShowSelectAccessNameDialog.UseVisualStyleBackColor = true;
            this.btnShowSelectAccessNameDialog.Click += new System.EventHandler(this.btnShowSelectAccessNameDialog_Click);
            // 
            // IoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowSelectAccessNameDialog);
            this.Controls.Add(this.cBoxReadOnly);
            this.Controls.Add(this.tBoxAccessName);
            this.Controls.Add(this.tBoxItemName);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IoPanel";
            this.Size = new System.Drawing.Size(496, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxAccessName;
        private System.Windows.Forms.CheckBox cBoxReadOnly;
        private System.Windows.Forms.Button btnShowSelectAccessNameDialog;
    }
}

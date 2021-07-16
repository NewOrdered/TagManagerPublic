
namespace TagManager.UI.Dialogs
{
    partial class FrmNewTag
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
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.rBtnIoDiscrete = new System.Windows.Forms.RadioButton();
            this.rBtnIoInteger = new System.Windows.Forms.RadioButton();
            this.rBtnIoReal = new System.Windows.Forms.RadioButton();
            this.rBtnIoMsg = new System.Windows.Forms.RadioButton();
            this.rBtnMemoryDiscrete = new System.Windows.Forms.RadioButton();
            this.rBtnMemoryInteger = new System.Windows.Forms.RadioButton();
            this.rBtnMemoryReal = new System.Windows.Forms.RadioButton();
            this.rBtnMemoryMsg = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag Name:";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(99, 8);
            this.tBoxName.MaxLength = 50;
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(200, 22);
            this.tBoxName.TabIndex = 1;
            // 
            // gBoxType
            // 
            this.gBoxType.Controls.Add(this.rBtnMemoryMsg);
            this.gBoxType.Controls.Add(this.rBtnMemoryReal);
            this.gBoxType.Controls.Add(this.rBtnMemoryInteger);
            this.gBoxType.Controls.Add(this.rBtnMemoryDiscrete);
            this.gBoxType.Controls.Add(this.rBtnIoMsg);
            this.gBoxType.Controls.Add(this.rBtnIoReal);
            this.gBoxType.Controls.Add(this.rBtnIoInteger);
            this.gBoxType.Controls.Add(this.rBtnIoDiscrete);
            this.gBoxType.Location = new System.Drawing.Point(12, 36);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Size = new System.Drawing.Size(287, 128);
            this.gBoxType.TabIndex = 2;
            this.gBoxType.TabStop = false;
            this.gBoxType.Text = "Type";
            // 
            // rBtnIoDiscrete
            // 
            this.rBtnIoDiscrete.AutoSize = true;
            this.rBtnIoDiscrete.Location = new System.Drawing.Point(16, 19);
            this.rBtnIoDiscrete.Name = "rBtnIoDiscrete";
            this.rBtnIoDiscrete.Size = new System.Drawing.Size(96, 20);
            this.rBtnIoDiscrete.TabIndex = 0;
            this.rBtnIoDiscrete.TabStop = true;
            this.rBtnIoDiscrete.Text = "I/O Discrete";
            this.rBtnIoDiscrete.UseVisualStyleBackColor = true;
            // 
            // rBtnIoInteger
            // 
            this.rBtnIoInteger.AutoSize = true;
            this.rBtnIoInteger.Location = new System.Drawing.Point(16, 45);
            this.rBtnIoInteger.Name = "rBtnIoInteger";
            this.rBtnIoInteger.Size = new System.Drawing.Size(87, 20);
            this.rBtnIoInteger.TabIndex = 1;
            this.rBtnIoInteger.TabStop = true;
            this.rBtnIoInteger.Text = "I/O Integer";
            this.rBtnIoInteger.UseVisualStyleBackColor = true;
            // 
            // rBtnIoReal
            // 
            this.rBtnIoReal.AutoSize = true;
            this.rBtnIoReal.Location = new System.Drawing.Point(16, 71);
            this.rBtnIoReal.Name = "rBtnIoReal";
            this.rBtnIoReal.Size = new System.Drawing.Size(75, 20);
            this.rBtnIoReal.TabIndex = 2;
            this.rBtnIoReal.TabStop = true;
            this.rBtnIoReal.Text = "I/O Real";
            this.rBtnIoReal.UseVisualStyleBackColor = true;
            // 
            // rBtnIoMsg
            // 
            this.rBtnIoMsg.AutoSize = true;
            this.rBtnIoMsg.Location = new System.Drawing.Point(16, 97);
            this.rBtnIoMsg.Name = "rBtnIoMsg";
            this.rBtnIoMsg.Size = new System.Drawing.Size(103, 20);
            this.rBtnIoMsg.TabIndex = 3;
            this.rBtnIoMsg.TabStop = true;
            this.rBtnIoMsg.Text = "I/O Message";
            this.rBtnIoMsg.UseVisualStyleBackColor = true;
            // 
            // rBtnMemoryDiscrete
            // 
            this.rBtnMemoryDiscrete.AutoSize = true;
            this.rBtnMemoryDiscrete.Location = new System.Drawing.Point(139, 19);
            this.rBtnMemoryDiscrete.Name = "rBtnMemoryDiscrete";
            this.rBtnMemoryDiscrete.Size = new System.Drawing.Size(128, 20);
            this.rBtnMemoryDiscrete.TabIndex = 4;
            this.rBtnMemoryDiscrete.TabStop = true;
            this.rBtnMemoryDiscrete.Text = "Memory Discrete";
            this.rBtnMemoryDiscrete.UseVisualStyleBackColor = true;
            // 
            // rBtnMemoryInteger
            // 
            this.rBtnMemoryInteger.AutoSize = true;
            this.rBtnMemoryInteger.Location = new System.Drawing.Point(139, 45);
            this.rBtnMemoryInteger.Name = "rBtnMemoryInteger";
            this.rBtnMemoryInteger.Size = new System.Drawing.Size(119, 20);
            this.rBtnMemoryInteger.TabIndex = 5;
            this.rBtnMemoryInteger.TabStop = true;
            this.rBtnMemoryInteger.Text = "Memory Integer";
            this.rBtnMemoryInteger.UseVisualStyleBackColor = true;
            // 
            // rBtnMemoryReal
            // 
            this.rBtnMemoryReal.AutoSize = true;
            this.rBtnMemoryReal.Location = new System.Drawing.Point(139, 71);
            this.rBtnMemoryReal.Name = "rBtnMemoryReal";
            this.rBtnMemoryReal.Size = new System.Drawing.Size(107, 20);
            this.rBtnMemoryReal.TabIndex = 6;
            this.rBtnMemoryReal.TabStop = true;
            this.rBtnMemoryReal.Text = "Memory Real";
            this.rBtnMemoryReal.UseVisualStyleBackColor = true;
            // 
            // rBtnMemoryMsg
            // 
            this.rBtnMemoryMsg.AutoSize = true;
            this.rBtnMemoryMsg.Location = new System.Drawing.Point(139, 97);
            this.rBtnMemoryMsg.Name = "rBtnMemoryMsg";
            this.rBtnMemoryMsg.Size = new System.Drawing.Size(135, 20);
            this.rBtnMemoryMsg.TabIndex = 7;
            this.rBtnMemoryMsg.TabStop = true;
            this.rBtnMemoryMsg.Text = "Memory Message";
            this.rBtnMemoryMsg.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(317, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmNewTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gBoxType);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewTag";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Tag";
            this.gBoxType.ResumeLayout(false);
            this.gBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.RadioButton rBtnIoInteger;
        private System.Windows.Forms.RadioButton rBtnIoDiscrete;
        private System.Windows.Forms.RadioButton rBtnIoReal;
        private System.Windows.Forms.RadioButton rBtnIoMsg;
        private System.Windows.Forms.RadioButton rBtnMemoryDiscrete;
        private System.Windows.Forms.RadioButton rBtnMemoryInteger;
        private System.Windows.Forms.RadioButton rBtnMemoryReal;
        private System.Windows.Forms.RadioButton rBtnMemoryMsg;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
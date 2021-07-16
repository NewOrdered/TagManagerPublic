
namespace TagManager.UI.Dialogs
{
    partial class FrmAddModifyAccessName
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
            this.tBoxAccessName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxNodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxApplicationName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxTopicName = new System.Windows.Forms.TextBox();
            this.gBoxProtocol = new System.Windows.Forms.GroupBox();
            this.rBtnSuiteLink = new System.Windows.Forms.RadioButton();
            this.rBtnDDE = new System.Windows.Forms.RadioButton();
            this.gBoxAdvise = new System.Windows.Forms.GroupBox();
            this.rBtnAdviseActiveItems = new System.Windows.Forms.RadioButton();
            this.rBtnAdviseAllItems = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rBtnMessageExchange = new System.Windows.Forms.RadioButton();
            this.gBoxProtocol.SuspendLayout();
            this.gBoxAdvise.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Name: ";
            // 
            // tBoxAccessName
            // 
            this.tBoxAccessName.Location = new System.Drawing.Point(120, 20);
            this.tBoxAccessName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxAccessName.Name = "tBoxAccessName";
            this.tBoxAccessName.Size = new System.Drawing.Size(170, 22);
            this.tBoxAccessName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Node Name: ";
            // 
            // tBoxNodeName
            // 
            this.tBoxNodeName.Location = new System.Drawing.Point(16, 75);
            this.tBoxNodeName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxNodeName.Name = "tBoxNodeName";
            this.tBoxNodeName.Size = new System.Drawing.Size(356, 22);
            this.tBoxNodeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Application Name: ";
            // 
            // tBoxApplicationName
            // 
            this.tBoxApplicationName.Location = new System.Drawing.Point(17, 121);
            this.tBoxApplicationName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxApplicationName.Name = "tBoxApplicationName";
            this.tBoxApplicationName.Size = new System.Drawing.Size(356, 22);
            this.tBoxApplicationName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Topic Name: ";
            // 
            // tBoxTopicName
            // 
            this.tBoxTopicName.Location = new System.Drawing.Point(17, 167);
            this.tBoxTopicName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxTopicName.Name = "tBoxTopicName";
            this.tBoxTopicName.Size = new System.Drawing.Size(356, 22);
            this.tBoxTopicName.TabIndex = 7;
            // 
            // gBoxProtocol
            // 
            this.gBoxProtocol.Controls.Add(this.rBtnMessageExchange);
            this.gBoxProtocol.Controls.Add(this.rBtnSuiteLink);
            this.gBoxProtocol.Controls.Add(this.rBtnDDE);
            this.gBoxProtocol.Location = new System.Drawing.Point(18, 196);
            this.gBoxProtocol.Name = "gBoxProtocol";
            this.gBoxProtocol.Size = new System.Drawing.Size(355, 55);
            this.gBoxProtocol.TabIndex = 8;
            this.gBoxProtocol.TabStop = false;
            this.gBoxProtocol.Text = "Which protocol to use";
            // 
            // rBtnSuiteLink
            // 
            this.rBtnSuiteLink.AutoSize = true;
            this.rBtnSuiteLink.Location = new System.Drawing.Point(92, 21);
            this.rBtnSuiteLink.Name = "rBtnSuiteLink";
            this.rBtnSuiteLink.Size = new System.Drawing.Size(80, 20);
            this.rBtnSuiteLink.TabIndex = 1;
            this.rBtnSuiteLink.TabStop = true;
            this.rBtnSuiteLink.Text = "SuiteLink";
            this.rBtnSuiteLink.UseVisualStyleBackColor = true;
            // 
            // rBtnDDE
            // 
            this.rBtnDDE.AutoSize = true;
            this.rBtnDDE.Location = new System.Drawing.Point(18, 21);
            this.rBtnDDE.Name = "rBtnDDE";
            this.rBtnDDE.Size = new System.Drawing.Size(55, 20);
            this.rBtnDDE.TabIndex = 0;
            this.rBtnDDE.TabStop = true;
            this.rBtnDDE.Text = "DDE";
            this.rBtnDDE.UseVisualStyleBackColor = true;
            // 
            // gBoxAdvise
            // 
            this.gBoxAdvise.Controls.Add(this.rBtnAdviseActiveItems);
            this.gBoxAdvise.Controls.Add(this.rBtnAdviseAllItems);
            this.gBoxAdvise.Location = new System.Drawing.Point(18, 257);
            this.gBoxAdvise.Name = "gBoxAdvise";
            this.gBoxAdvise.Size = new System.Drawing.Size(355, 55);
            this.gBoxAdvise.TabIndex = 9;
            this.gBoxAdvise.TabStop = false;
            this.gBoxAdvise.Text = "When to advise server";
            // 
            // rBtnAdviseActiveItems
            // 
            this.rBtnAdviseActiveItems.AutoSize = true;
            this.rBtnAdviseActiveItems.Location = new System.Drawing.Point(167, 21);
            this.rBtnAdviseActiveItems.Name = "rBtnAdviseActiveItems";
            this.rBtnAdviseActiveItems.Size = new System.Drawing.Size(170, 20);
            this.rBtnAdviseActiveItems.TabIndex = 1;
            this.rBtnAdviseActiveItems.TabStop = true;
            this.rBtnAdviseActiveItems.Text = "Advise only active items";
            this.rBtnAdviseActiveItems.UseVisualStyleBackColor = true;
            // 
            // rBtnAdviseAllItems
            // 
            this.rBtnAdviseAllItems.AutoSize = true;
            this.rBtnAdviseAllItems.Location = new System.Drawing.Point(18, 21);
            this.rBtnAdviseAllItems.Name = "rBtnAdviseAllItems";
            this.rBtnAdviseAllItems.Size = new System.Drawing.Size(120, 20);
            this.rBtnAdviseAllItems.TabIndex = 0;
            this.rBtnAdviseAllItems.TabStop = true;
            this.rBtnAdviseAllItems.Text = "Advise all items";
            this.rBtnAdviseAllItems.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(394, 17);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rBtnMessageExchange
            // 
            this.rBtnMessageExchange.AutoSize = true;
            this.rBtnMessageExchange.Location = new System.Drawing.Point(191, 21);
            this.rBtnMessageExchange.Name = "rBtnMessageExchange";
            this.rBtnMessageExchange.Size = new System.Drawing.Size(146, 20);
            this.rBtnMessageExchange.TabIndex = 2;
            this.rBtnMessageExchange.TabStop = true;
            this.rBtnMessageExchange.Text = "Message Exchange";
            this.rBtnMessageExchange.UseVisualStyleBackColor = true;
            // 
            // FrmAddModifyAccessName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gBoxAdvise);
            this.Controls.Add(this.gBoxProtocol);
            this.Controls.Add(this.tBoxTopicName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxApplicationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxNodeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxAccessName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddModifyAccessName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "< Add / Modify Access Name >";
            this.gBoxProtocol.ResumeLayout(false);
            this.gBoxProtocol.PerformLayout();
            this.gBoxAdvise.ResumeLayout(false);
            this.gBoxAdvise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAccessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxNodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxApplicationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxTopicName;
        private System.Windows.Forms.GroupBox gBoxProtocol;
        private System.Windows.Forms.RadioButton rBtnSuiteLink;
        private System.Windows.Forms.RadioButton rBtnDDE;
        private System.Windows.Forms.GroupBox gBoxAdvise;
        private System.Windows.Forms.RadioButton rBtnAdviseActiveItems;
        private System.Windows.Forms.RadioButton rBtnAdviseAllItems;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rBtnMessageExchange;
    }
}
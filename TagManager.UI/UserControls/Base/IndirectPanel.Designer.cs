
namespace TagManager.UI.UserControls
{
    partial class IndirectPanel
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
            this.tBoxTagName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowSelecAlarmGroupDialog = new System.Windows.Forms.Button();
            this.tBoxGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxRetentive = new System.Windows.Forms.CheckBox();
            this.numUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxEventLogged = new System.Windows.Forms.CheckBox();
            this.tBoxComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxSymbolicName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxTagName
            // 
            this.tBoxTagName.Location = new System.Drawing.Point(85, 7);
            this.tBoxTagName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxTagName.MaxLength = 50;
            this.tBoxTagName.Name = "tBoxTagName";
            this.tBoxTagName.Size = new System.Drawing.Size(213, 22);
            this.tBoxTagName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tagname:";
            // 
            // btnShowSelecAlarmGroupDialog
            // 
            this.btnShowSelecAlarmGroupDialog.Location = new System.Drawing.Point(308, 32);
            this.btnShowSelecAlarmGroupDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowSelecAlarmGroupDialog.Name = "btnShowSelecAlarmGroupDialog";
            this.btnShowSelecAlarmGroupDialog.Size = new System.Drawing.Size(100, 28);
            this.btnShowSelecAlarmGroupDialog.TabIndex = 16;
            this.btnShowSelecAlarmGroupDialog.Text = "Group...";
            this.btnShowSelecAlarmGroupDialog.UseVisualStyleBackColor = true;
            this.btnShowSelecAlarmGroupDialog.Click += new System.EventHandler(this.btnShowSelecAlarmGroupDialog_Click);
            // 
            // tBoxGroup
            // 
            this.tBoxGroup.Location = new System.Drawing.Point(85, 35);
            this.tBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxGroup.MaxLength = 50;
            this.tBoxGroup.Name = "tBoxGroup";
            this.tBoxGroup.Size = new System.Drawing.Size(213, 22);
            this.tBoxGroup.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Group:";
            // 
            // cBoxRetentive
            // 
            this.cBoxRetentive.AutoSize = true;
            this.cBoxRetentive.Location = new System.Drawing.Point(398, 96);
            this.cBoxRetentive.Name = "cBoxRetentive";
            this.cBoxRetentive.Size = new System.Drawing.Size(84, 20);
            this.cBoxRetentive.TabIndex = 26;
            this.cBoxRetentive.Text = "Retentive";
            this.cBoxRetentive.UseVisualStyleBackColor = true;
            // 
            // numUpDownPriority
            // 
            this.numUpDownPriority.Location = new System.Drawing.Point(261, 95);
            this.numUpDownPriority.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownPriority.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownPriority.Name = "numUpDownPriority";
            this.numUpDownPriority.Size = new System.Drawing.Size(67, 22);
            this.numUpDownPriority.TabIndex = 23;
            this.numUpDownPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Priority:";
            // 
            // cBoxEventLogged
            // 
            this.cBoxEventLogged.AutoSize = true;
            this.cBoxEventLogged.Location = new System.Drawing.Point(99, 97);
            this.cBoxEventLogged.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxEventLogged.Name = "cBoxEventLogged";
            this.cBoxEventLogged.Size = new System.Drawing.Size(94, 20);
            this.cBoxEventLogged.TabIndex = 22;
            this.cBoxEventLogged.Text = "Log Events";
            this.cBoxEventLogged.UseVisualStyleBackColor = true;
            // 
            // tBoxComment
            // 
            this.tBoxComment.Location = new System.Drawing.Point(85, 65);
            this.tBoxComment.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxComment.MaxLength = 131;
            this.tBoxComment.Name = "tBoxComment";
            this.tBoxComment.Size = new System.Drawing.Size(398, 22);
            this.tBoxComment.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Comment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Symbolic Name:";
            // 
            // tBoxSymbolicName
            // 
            this.tBoxSymbolicName.Location = new System.Drawing.Point(124, 125);
            this.tBoxSymbolicName.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxSymbolicName.MaxLength = 131;
            this.tBoxSymbolicName.Name = "tBoxSymbolicName";
            this.tBoxSymbolicName.Size = new System.Drawing.Size(359, 22);
            this.tBoxSymbolicName.TabIndex = 27;
            // 
            // IndirectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxSymbolicName);
            this.Controls.Add(this.cBoxRetentive);
            this.Controls.Add(this.numUpDownPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxEventLogged);
            this.Controls.Add(this.tBoxComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowSelecAlarmGroupDialog);
            this.Controls.Add(this.tBoxGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxTagName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndirectPanel";
            this.Size = new System.Drawing.Size(496, 155);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxTagName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowSelecAlarmGroupDialog;
        private System.Windows.Forms.TextBox tBoxGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBoxRetentive;
        private System.Windows.Forms.NumericUpDown numUpDownPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBoxEventLogged;
        private System.Windows.Forms.TextBox tBoxComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxSymbolicName;
    }
}

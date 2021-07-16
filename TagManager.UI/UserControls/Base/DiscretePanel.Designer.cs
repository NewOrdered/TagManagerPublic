
namespace TagManager.UI.UserControls
{
    partial class DiscretePanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxOnMessage = new System.Windows.Forms.TextBox();
            this.tBoxOffMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxAlarmState = new System.Windows.Forms.GroupBox();
            this.rBtnAlarmStateNone = new System.Windows.Forms.RadioButton();
            this.rBtnAlarmStateOff = new System.Windows.Forms.RadioButton();
            this.rBtnAlarmStateOn = new System.Windows.Forms.RadioButton();
            this.numUpDownAlmPriority = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gBoxAlarmState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAlmPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "On Msg:";
            // 
            // tBoxOnMessage
            // 
            this.tBoxOnMessage.Location = new System.Drawing.Point(69, 7);
            this.tBoxOnMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxOnMessage.Name = "tBoxOnMessage";
            this.tBoxOnMessage.Size = new System.Drawing.Size(145, 22);
            this.tBoxOnMessage.TabIndex = 0;
            // 
            // tBoxOffMessage
            // 
            this.tBoxOffMessage.Location = new System.Drawing.Point(316, 7);
            this.tBoxOffMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxOffMessage.Name = "tBoxOffMessage";
            this.tBoxOffMessage.Size = new System.Drawing.Size(145, 22);
            this.tBoxOffMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Off Msg:";
            // 
            // gBoxAlarmState
            // 
            this.gBoxAlarmState.Controls.Add(this.rBtnAlarmStateNone);
            this.gBoxAlarmState.Controls.Add(this.rBtnAlarmStateOff);
            this.gBoxAlarmState.Controls.Add(this.rBtnAlarmStateOn);
            this.gBoxAlarmState.Location = new System.Drawing.Point(8, 39);
            this.gBoxAlarmState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxAlarmState.Name = "gBoxAlarmState";
            this.gBoxAlarmState.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxAlarmState.Size = new System.Drawing.Size(213, 50);
            this.gBoxAlarmState.TabIndex = 4;
            this.gBoxAlarmState.TabStop = false;
            this.gBoxAlarmState.Text = "Alarm State";
            // 
            // rBtnAlarmStateNone
            // 
            this.rBtnAlarmStateNone.AutoSize = true;
            this.rBtnAlarmStateNone.Location = new System.Drawing.Point(127, 22);
            this.rBtnAlarmStateNone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnAlarmStateNone.Name = "rBtnAlarmStateNone";
            this.rBtnAlarmStateNone.Size = new System.Drawing.Size(59, 20);
            this.rBtnAlarmStateNone.TabIndex = 2;
            this.rBtnAlarmStateNone.TabStop = true;
            this.rBtnAlarmStateNone.Tag = "0";
            this.rBtnAlarmStateNone.Text = "None";
            this.rBtnAlarmStateNone.UseVisualStyleBackColor = true;
            // 
            // rBtnAlarmStateOff
            // 
            this.rBtnAlarmStateOff.AutoSize = true;
            this.rBtnAlarmStateOff.Location = new System.Drawing.Point(67, 22);
            this.rBtnAlarmStateOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnAlarmStateOff.Name = "rBtnAlarmStateOff";
            this.rBtnAlarmStateOff.Size = new System.Drawing.Size(42, 20);
            this.rBtnAlarmStateOff.TabIndex = 1;
            this.rBtnAlarmStateOff.TabStop = true;
            this.rBtnAlarmStateOff.Tag = "1";
            this.rBtnAlarmStateOff.Text = "Off";
            this.rBtnAlarmStateOff.UseVisualStyleBackColor = true;
            // 
            // rBtnAlarmStateOn
            // 
            this.rBtnAlarmStateOn.AutoSize = true;
            this.rBtnAlarmStateOn.Location = new System.Drawing.Point(8, 22);
            this.rBtnAlarmStateOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnAlarmStateOn.Name = "rBtnAlarmStateOn";
            this.rBtnAlarmStateOn.Size = new System.Drawing.Size(43, 20);
            this.rBtnAlarmStateOn.TabIndex = 0;
            this.rBtnAlarmStateOn.TabStop = true;
            this.rBtnAlarmStateOn.Tag = "1";
            this.rBtnAlarmStateOn.Text = "On";
            this.rBtnAlarmStateOn.UseVisualStyleBackColor = true;
            // 
            // numUpDownAlmPriority
            // 
            this.numUpDownAlmPriority.Location = new System.Drawing.Point(308, 57);
            this.numUpDownAlmPriority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownAlmPriority.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDownAlmPriority.Name = "numUpDownAlmPriority";
            this.numUpDownAlmPriority.Size = new System.Drawing.Size(67, 22);
            this.numUpDownAlmPriority.TabIndex = 2;
            this.numUpDownAlmPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priority:";
            // 
            // DiscretePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numUpDownAlmPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gBoxAlarmState);
            this.Controls.Add(this.tBoxOffMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxOnMessage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiscretePanel";
            this.Size = new System.Drawing.Size(496, 98);
            this.gBoxAlarmState.ResumeLayout(false);
            this.gBoxAlarmState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAlmPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxOnMessage;
        private System.Windows.Forms.TextBox tBoxOffMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxAlarmState;
        private System.Windows.Forms.RadioButton rBtnAlarmStateNone;
        private System.Windows.Forms.RadioButton rBtnAlarmStateOff;
        private System.Windows.Forms.RadioButton rBtnAlarmStateOn;
        private System.Windows.Forms.NumericUpDown numUpDownAlmPriority;
        private System.Windows.Forms.Label label4;
    }
}

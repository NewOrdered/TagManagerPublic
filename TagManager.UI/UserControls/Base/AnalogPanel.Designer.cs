
namespace TagManager.UI.UserControls
{
    partial class AnalogPanel
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
            this.tBoxEngUnits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownMaxEU = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownMinEU = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxEU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinEU)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxEngUnits
            // 
            this.tBoxEngUnits.Location = new System.Drawing.Point(87, 5);
            this.tBoxEngUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxEngUnits.Name = "tBoxEngUnits";
            this.tBoxEngUnits.Size = new System.Drawing.Size(343, 22);
            this.tBoxEngUnits.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eng Units:";
            // 
            // numUpDownMaxEU
            // 
            this.numUpDownMaxEU.Location = new System.Drawing.Point(312, 36);
            this.numUpDownMaxEU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownMaxEU.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUpDownMaxEU.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUpDownMaxEU.Name = "numUpDownMaxEU";
            this.numUpDownMaxEU.Size = new System.Drawing.Size(117, 22);
            this.numUpDownMaxEU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max EU:";
            // 
            // numUpDownMinEU
            // 
            this.numUpDownMinEU.Location = new System.Drawing.Point(87, 36);
            this.numUpDownMinEU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownMinEU.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUpDownMinEU.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUpDownMinEU.Name = "numUpDownMinEU";
            this.numUpDownMinEU.Size = new System.Drawing.Size(117, 22);
            this.numUpDownMinEU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min EU:";
            // 
            // AnalogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tBoxEngUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDownMaxEU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDownMinEU);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnalogPanel";
            this.Size = new System.Drawing.Size(496, 64);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxEU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinEU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxEngUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDownMaxEU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownMinEU;
        private System.Windows.Forms.Label label1;
    }
}

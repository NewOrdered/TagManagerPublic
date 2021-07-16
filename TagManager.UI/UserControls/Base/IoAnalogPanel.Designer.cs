
namespace TagManager.UI.UserControls
{
    partial class IoAnalogPanel
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
            this.numUpDownMinRaw = new System.Windows.Forms.NumericUpDown();
            this.numUpDownMaxRaw = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min Raw:";
            // 
            // numUpDownMinRaw
            // 
            this.numUpDownMinRaw.Location = new System.Drawing.Point(87, 5);
            this.numUpDownMinRaw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownMinRaw.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUpDownMinRaw.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUpDownMinRaw.Name = "numUpDownMinRaw";
            this.numUpDownMinRaw.Size = new System.Drawing.Size(117, 22);
            this.numUpDownMinRaw.TabIndex = 1;
            // 
            // numUpDownMaxRaw
            // 
            this.numUpDownMaxRaw.Location = new System.Drawing.Point(312, 5);
            this.numUpDownMaxRaw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownMaxRaw.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUpDownMaxRaw.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numUpDownMaxRaw.Name = "numUpDownMaxRaw";
            this.numUpDownMaxRaw.Size = new System.Drawing.Size(117, 22);
            this.numUpDownMaxRaw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Raw:";
            // 
            // IoAnalogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numUpDownMaxRaw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDownMinRaw);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IoAnalogPanel";
            this.Size = new System.Drawing.Size(496, 33);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMinRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMaxRaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownMinRaw;
        private System.Windows.Forms.NumericUpDown numUpDownMaxRaw;
        private System.Windows.Forms.Label label2;
    }
}

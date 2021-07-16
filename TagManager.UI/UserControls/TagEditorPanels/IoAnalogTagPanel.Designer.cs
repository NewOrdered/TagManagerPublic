
namespace TagManager.UI.UserControls
{
    partial class IoAnalogTagPanel
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
            this.lblType = new System.Windows.Forms.Label();
            this.commonPanel = new TagManager.UI.UserControls.CommonPanel();
            this.ioAnalogPanel = new TagManager.UI.UserControls.IoAnalogPanel();
            this.analogPanel = new TagManager.UI.UserControls.AnalogPanel();
            this.ioPanel = new TagManager.UI.UserControls.IoPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 7);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "<Type>";
            // 
            // commonPanel
            // 
            this.commonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commonPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.commonPanel.Location = new System.Drawing.Point(8, 27);
            this.commonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.commonPanel.Name = "commonPanel";
            this.commonPanel.Size = new System.Drawing.Size(495, 160);
            this.commonPanel.TabIndex = 1;
            // 
            // ioAnalogPanel
            // 
            this.ioAnalogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioAnalogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioAnalogPanel.Location = new System.Drawing.Point(8, 261);
            this.ioAnalogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioAnalogPanel.Name = "ioAnalogPanel";
            this.ioAnalogPanel.Size = new System.Drawing.Size(495, 33);
            this.ioAnalogPanel.TabIndex = 3;
            // 
            // analogPanel
            // 
            this.analogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.analogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.analogPanel.Location = new System.Drawing.Point(8, 192);
            this.analogPanel.Margin = new System.Windows.Forms.Padding(4);
            this.analogPanel.Name = "analogPanel";
            this.analogPanel.Size = new System.Drawing.Size(495, 64);
            this.analogPanel.TabIndex = 2;
            // 
            // ioPanel
            // 
            this.ioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioPanel.Location = new System.Drawing.Point(8, 300);
            this.ioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioPanel.Name = "ioPanel";
            this.ioPanel.Size = new System.Drawing.Size(495, 64);
            this.ioPanel.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(404, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IoIntegerTagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ioPanel);
            this.Controls.Add(this.analogPanel);
            this.Controls.Add(this.ioAnalogPanel);
            this.Controls.Add(this.commonPanel);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IoIntegerTagPanel";
            this.Size = new System.Drawing.Size(513, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private CommonPanel commonPanel;
        private IoAnalogPanel ioAnalogPanel;
        private AnalogPanel analogPanel;
        private IoPanel ioPanel;
        private System.Windows.Forms.Button btnSave;
    }
}

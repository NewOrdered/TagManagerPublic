
namespace TagManager.UI.UserControls
{
    partial class IoDiscreteTagPanel
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
            this.discretePanel = new TagManager.UI.UserControls.DiscretePanel();
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
            // discretePanel
            // 
            this.discretePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discretePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.discretePanel.Location = new System.Drawing.Point(8, 194);
            this.discretePanel.Margin = new System.Windows.Forms.Padding(4);
            this.discretePanel.Name = "discretePanel";
            this.discretePanel.Size = new System.Drawing.Size(495, 98);
            this.discretePanel.TabIndex = 2;
            // 
            // ioPanel
            // 
            this.ioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ioPanel.Location = new System.Drawing.Point(8, 300);
            this.ioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ioPanel.Name = "ioPanel";
            this.ioPanel.Size = new System.Drawing.Size(495, 64);
            this.ioPanel.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(404, 372);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IoDiscreteTagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ioPanel);
            this.Controls.Add(this.discretePanel);
            this.Controls.Add(this.commonPanel);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IoDiscreteTagPanel";
            this.Size = new System.Drawing.Size(513, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private CommonPanel commonPanel;
        private DiscretePanel discretePanel;
        private IoPanel ioPanel;
        private System.Windows.Forms.Button btnSave;
    }
}

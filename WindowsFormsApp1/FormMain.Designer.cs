
namespace WindowsFormsApp1
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.markFIO = new System.Windows.Forms.Label();
            this.btnCLME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markFIO
            // 
            this.markFIO.AutoSize = true;
            this.markFIO.Location = new System.Drawing.Point(151, 194);
            this.markFIO.Name = "markFIO";
            this.markFIO.Size = new System.Drawing.Size(161, 13);
            this.markFIO.TabIndex = 0;
            this.markFIO.Text = "Сливков Дмитрий Витальевич";
            // 
            // btnCLME
            // 
            this.btnCLME.Location = new System.Drawing.Point(198, 268);
            this.btnCLME.Name = "btnCLME";
            this.btnCLME.Size = new System.Drawing.Size(75, 23);
            this.btnCLME.TabIndex = 1;
            this.btnCLME.Text = "Click Me";
            this.btnCLME.UseVisualStyleBackColor = true;
            this.btnCLME.Click += new System.EventHandler(this.btnCLME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btnCLME);
            this.Controls.Add(this.markFIO);
            this.Name = "FormMain";
            this.Text = "Example 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label markFIO;
        private System.Windows.Forms.Button btnCLME;
    }
}


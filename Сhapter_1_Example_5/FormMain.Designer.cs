
namespace Сhapter_1_Example_5
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.markShowPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(106, 222);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(168, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Показать пароль";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // markShowPass
            // 
            this.markShowPass.AutoSize = true;
            this.markShowPass.Location = new System.Drawing.Point(103, 173);
            this.markShowPass.Name = "markShowPass";
            this.markShowPass.Size = new System.Drawing.Size(24, 13);
            this.markShowPass.TabIndex = 1;
            this.markShowPass.Text = "text";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(106, 117);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(168, 20);
            this.tbPass.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.markShowPass);
            this.Controls.Add(this.btnEnter);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label markShowPass;
        private System.Windows.Forms.TextBox tbPass;
    }
}


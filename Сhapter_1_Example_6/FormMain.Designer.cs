
namespace Сhapter_1_Example_6
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
            this.chbFontStyle = new System.Windows.Forms.CheckBox();
            this.markFontStyleExamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbFontStyle
            // 
            this.chbFontStyle.AutoSize = true;
            this.chbFontStyle.Location = new System.Drawing.Point(78, 180);
            this.chbFontStyle.Name = "chbFontStyle";
            this.chbFontStyle.Size = new System.Drawing.Size(43, 17);
            this.chbFontStyle.TabIndex = 0;
            this.chbFontStyle.Text = "text";
            this.chbFontStyle.UseVisualStyleBackColor = true;
            this.chbFontStyle.CheckedChanged += new System.EventHandler(this.chbFontStyle_CheckedChanged);
            // 
            // markFontStyleExamp
            // 
            this.markFontStyleExamp.AutoSize = true;
            this.markFontStyleExamp.Location = new System.Drawing.Point(78, 126);
            this.markFontStyleExamp.Name = "markFontStyleExamp";
            this.markFontStyleExamp.Size = new System.Drawing.Size(70, 13);
            this.markFontStyleExamp.TabIndex = 1;
            this.markFontStyleExamp.Text = "TextTextText";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.markFontStyleExamp);
            this.Controls.Add(this.chbFontStyle);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbFontStyle;
        private System.Windows.Forms.Label markFontStyleExamp;
    }
}


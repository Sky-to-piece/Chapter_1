
namespace Сhapter_1_Example_7
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
            this.markFontStyle = new System.Windows.Forms.Label();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.chbOblique = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // markFontStyle
            // 
            this.markFontStyle.AutoSize = true;
            this.markFontStyle.Location = new System.Drawing.Point(72, 101);
            this.markFontStyle.Name = "markFontStyle";
            this.markFontStyle.Size = new System.Drawing.Size(24, 13);
            this.markFontStyle.TabIndex = 0;
            this.markFontStyle.Text = "text";
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Location = new System.Drawing.Point(72, 170);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(43, 17);
            this.chbBold.TabIndex = 1;
            this.chbBold.Text = "text";
            this.chbBold.UseVisualStyleBackColor = true;
            this.chbBold.CheckedChanged += new System.EventHandler(this.chbBold_CheckedChanged);
            // 
            // chbOblique
            // 
            this.chbOblique.AutoSize = true;
            this.chbOblique.Location = new System.Drawing.Point(202, 170);
            this.chbOblique.Name = "chbOblique";
            this.chbOblique.Size = new System.Drawing.Size(43, 17);
            this.chbOblique.TabIndex = 2;
            this.chbOblique.Text = "text";
            this.chbOblique.UseVisualStyleBackColor = true;
            this.chbOblique.CheckedChanged += new System.EventHandler(this.chbOblique_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.chbOblique);
            this.Controls.Add(this.chbBold);
            this.Controls.Add(this.markFontStyle);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label markFontStyle;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.CheckBox chbOblique;
    }
}


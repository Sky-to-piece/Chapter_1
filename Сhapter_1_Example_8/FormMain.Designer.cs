
namespace Сhapter_1_Example_8
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
            this.markForPyrmer = new System.Windows.Forms.Label();
            this.tpColor = new System.Windows.Forms.TabPage();
            this.tpText = new System.Windows.Forms.TabPage();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.rbSecond = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpText.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // markForPyrmer
            // 
            this.markForPyrmer.AutoSize = true;
            this.markForPyrmer.Location = new System.Drawing.Point(17, 266);
            this.markForPyrmer.Name = "markForPyrmer";
            this.markForPyrmer.Size = new System.Drawing.Size(24, 13);
            this.markForPyrmer.TabIndex = 1;
            this.markForPyrmer.Text = "text";
            // 
            // tpColor
            // 
            this.tpColor.Location = new System.Drawing.Point(4, 22);
            this.tpColor.Name = "tpColor";
            this.tpColor.Padding = new System.Windows.Forms.Padding(3);
            this.tpColor.Size = new System.Drawing.Size(552, 187);
            this.tpColor.TabIndex = 1;
            this.tpColor.Text = "text";
            this.tpColor.UseVisualStyleBackColor = true;
            // 
            // tpText
            // 
            this.tpText.Controls.Add(this.rbSecond);
            this.tpText.Controls.Add(this.rbFirst);
            this.tpText.Location = new System.Drawing.Point(4, 22);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(552, 187);
            this.tpText.TabIndex = 0;
            this.tpText.Text = "text";
            this.tpText.UseVisualStyleBackColor = true;
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Checked = true;
            this.rbFirst.Location = new System.Drawing.Point(36, 39);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(42, 17);
            this.rbFirst.TabIndex = 0;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "text";
            this.rbFirst.UseVisualStyleBackColor = true;
            // 
            // rbSecond
            // 
            this.rbSecond.AutoSize = true;
            this.rbSecond.Location = new System.Drawing.Point(36, 122);
            this.rbSecond.Name = "rbSecond";
            this.rbSecond.Size = new System.Drawing.Size(42, 17);
            this.rbSecond.TabIndex = 1;
            this.rbSecond.Text = "text";
            this.rbSecond.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpText);
            this.tabControl.Controls.Add(this.tpColor);
            this.tabControl.Location = new System.Drawing.Point(12, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(560, 213);
            this.tabControl.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.markForPyrmer);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tpText.ResumeLayout(false);
            this.tpText.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label markForPyrmer;
        private System.Windows.Forms.TabPage tpColor;
        private System.Windows.Forms.TabPage tpText;
        private System.Windows.Forms.RadioButton rbSecond;
        private System.Windows.Forms.RadioButton rbFirst;
        private System.Windows.Forms.TabControl tabControl;
    }
}


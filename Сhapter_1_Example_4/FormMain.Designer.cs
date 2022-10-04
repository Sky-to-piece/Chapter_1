
namespace Сhapter_1_Example_4
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
            this.btnFind = new System.Windows.Forms.Button();
            this.markMain = new System.Windows.Forms.Label();
            this.tb_for_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.Location = new System.Drawing.Point(128, 224);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(128, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Извлечь корень";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // markMain
            // 
            this.markMain.AutoSize = true;
            this.markMain.Location = new System.Drawing.Point(125, 169);
            this.markMain.Name = "markMain";
            this.markMain.Size = new System.Drawing.Size(24, 13);
            this.markMain.TabIndex = 1;
            this.markMain.Text = "text";
            // 
            // tb_for_num
            // 
            this.tb_for_num.Location = new System.Drawing.Point(116, 107);
            this.tb_for_num.Name = "tb_for_num";
            this.tb_for_num.Size = new System.Drawing.Size(153, 20);
            this.tb_for_num.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tb_for_num);
            this.Controls.Add(this.markMain);
            this.Controls.Add(this.btnFind);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label markMain;
        private System.Windows.Forms.TextBox tb_for_num;
    }
}


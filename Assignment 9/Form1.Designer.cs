namespace Assignment_9
{
    partial class Form1
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
            this.mostcommonletter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mostcommonletter
            // 
            this.mostcommonletter.Location = new System.Drawing.Point(90, 106);
            this.mostcommonletter.Name = "mostcommonletter";
            this.mostcommonletter.Size = new System.Drawing.Size(147, 41);
            this.mostcommonletter.TabIndex = 0;
            this.mostcommonletter.Text = "Most common letter";
            this.mostcommonletter.UseVisualStyleBackColor = true;
            this.mostcommonletter.Click += new System.EventHandler(this.mostcommonletter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String";
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(126, 69);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(100, 20);
            this.word.TabIndex = 2;
            this.word.TextChanged += new System.EventHandler(this.word_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 256);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostcommonletter);
            this.Name = "Form1";
            this.Text = "Most common letter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostcommonletter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word;
    }
}


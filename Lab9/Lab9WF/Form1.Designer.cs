namespace Lab9WF
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
            this.firstRe = new System.Windows.Forms.TextBox();
            this.firstIm = new System.Windows.Forms.TextBox();
            this.secondRe = new System.Windows.Forms.TextBox();
            this.secondIm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstRe
            // 
            this.firstRe.Location = new System.Drawing.Point(61, 79);
            this.firstRe.Multiline = true;
            this.firstRe.Name = "firstRe";
            this.firstRe.Size = new System.Drawing.Size(365, 90);
            this.firstRe.TabIndex = 0;
            // 
            // firstIm
            // 
            this.firstIm.Location = new System.Drawing.Point(61, 262);
            this.firstIm.Multiline = true;
            this.firstIm.Name = "firstIm";
            this.firstIm.Size = new System.Drawing.Size(365, 87);
            this.firstIm.TabIndex = 1;
            // 
            // secondRe
            // 
            this.secondRe.Location = new System.Drawing.Point(720, 79);
            this.secondRe.Multiline = true;
            this.secondRe.Name = "secondRe";
            this.secondRe.Size = new System.Drawing.Size(334, 78);
            this.secondRe.TabIndex = 2;
            // 
            // secondIm
            // 
            this.secondIm.Location = new System.Drawing.Point(720, 262);
            this.secondIm.Multiline = true;
            this.secondIm.Name = "secondIm";
            this.secondIm.Size = new System.Drawing.Size(334, 87);
            this.secondIm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите действительную часть числа 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(670, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите действительную часть числа 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите мнимую часть числа 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(722, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите мнимую часть числа 2";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(374, 408);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(421, 138);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "НАЧАТЬ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.Location = new System.Drawing.Point(37, 37);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(1057, 545);
            this.mainTextBox.TabIndex = 9;
            this.mainTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 627);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondIm);
            this.Controls.Add(this.secondRe);
            this.Controls.Add(this.firstIm);
            this.Controls.Add(this.firstRe);
            this.Controls.Add(this.mainTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstRe;
        private System.Windows.Forms.TextBox secondRe;
        private System.Windows.Forms.TextBox secondIm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.TextBox firstIm;
    }
}


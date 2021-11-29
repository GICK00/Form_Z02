
namespace Form_Z02_3
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
            this.buttonResultWhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonResultDoWhile = new System.Windows.Forms.Button();
            this.buttonResultFor = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClaer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonResultWhile
            // 
            this.buttonResultWhile.Location = new System.Drawing.Point(60, 169);
            this.buttonResultWhile.Name = "buttonResultWhile";
            this.buttonResultWhile.Size = new System.Drawing.Size(75, 23);
            this.buttonResultWhile.TabIndex = 0;
            this.buttonResultWhile.Text = "While";
            this.buttonResultWhile.UseVisualStyleBackColor = true;
            this.buttonResultWhile.Click += new System.EventHandler(this.buttonResultWhile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вывод чисел в заданном диапазоне с заданным \r\nокончанием.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите диапазон A и B а так же окончание X";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(95, 80);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(63, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите X";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(95, 106);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(63, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите B";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(95, 132);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(63, 20);
            this.textBoxX.TabIndex = 7;
            // 
            // buttonResultDoWhile
            // 
            this.buttonResultDoWhile.Location = new System.Drawing.Point(60, 198);
            this.buttonResultDoWhile.Name = "buttonResultDoWhile";
            this.buttonResultDoWhile.Size = new System.Drawing.Size(75, 23);
            this.buttonResultDoWhile.TabIndex = 9;
            this.buttonResultDoWhile.Text = "DoWhile";
            this.buttonResultDoWhile.UseVisualStyleBackColor = true;
            this.buttonResultDoWhile.Click += new System.EventHandler(this.buttonResultDoWhile_Click);
            // 
            // buttonResultFor
            // 
            this.buttonResultFor.Location = new System.Drawing.Point(60, 227);
            this.buttonResultFor.Name = "buttonResultFor";
            this.buttonResultFor.Size = new System.Drawing.Size(75, 23);
            this.buttonResultFor.TabIndex = 10;
            this.buttonResultFor.Text = "For";
            this.buttonResultFor.UseVisualStyleBackColor = true;
            this.buttonResultFor.Click += new System.EventHandler(this.buttonResultFor_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(311, 57);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(124, 293);
            this.textBoxResult.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Утин Д. С.";
            // 
            // buttonClaer
            // 
            this.buttonClaer.Location = new System.Drawing.Point(60, 284);
            this.buttonClaer.Name = "buttonClaer";
            this.buttonClaer.Size = new System.Drawing.Size(75, 23);
            this.buttonClaer.TabIndex = 13;
            this.buttonClaer.Text = "Очистить ";
            this.buttonClaer.UseVisualStyleBackColor = true;
            this.buttonClaer.Click += new System.EventHandler(this.buttonClaer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 362);
            this.Controls.Add(this.buttonClaer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonResultFor);
            this.Controls.Add(this.buttonResultDoWhile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResultWhile);
            this.Name = "Form1";
            this.Text = "Form Z02.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResultWhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonResultDoWhile;
        private System.Windows.Forms.Button buttonResultFor;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClaer;
    }
}


namespace WindowsFormsApp1
{
    partial class CalculatorForm
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.numerator1 = new System.Windows.Forms.TextBox();
            this.denomerator1 = new System.Windows.Forms.TextBox();
            this.numerator2 = new System.Windows.Forms.TextBox();
            this.denomerator2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(99, 222);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 38);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click_1);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(184, 222);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 38);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(99, 267);
            this.multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(60, 38);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(184, 267);
            this.division.Margin = new System.Windows.Forms.Padding(4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(60, 38);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(301, 267);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 38);
            this.clear.TabIndex = 4;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // numerator1
            // 
            this.numerator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numerator1.Location = new System.Drawing.Point(99, 74);
            this.numerator1.Margin = new System.Windows.Forms.Padding(4);
            this.numerator1.Name = "numerator1";
            this.numerator1.Size = new System.Drawing.Size(59, 37);
            this.numerator1.TabIndex = 5;
            // 
            // denomerator1
            // 
            this.denomerator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.denomerator1.Location = new System.Drawing.Point(99, 155);
            this.denomerator1.Margin = new System.Windows.Forms.Padding(4);
            this.denomerator1.Name = "denomerator1";
            this.denomerator1.Size = new System.Drawing.Size(59, 37);
            this.denomerator1.TabIndex = 6;
            // 
            // numerator2
            // 
            this.numerator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numerator2.Location = new System.Drawing.Point(184, 74);
            this.numerator2.Margin = new System.Windows.Forms.Padding(4);
            this.numerator2.Name = "numerator2";
            this.numerator2.Size = new System.Drawing.Size(59, 37);
            this.numerator2.TabIndex = 7;
            // 
            // denomerator2
            // 
            this.denomerator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.denomerator2.Location = new System.Drawing.Point(184, 155);
            this.denomerator2.Margin = new System.Windows.Forms.Padding(4);
            this.denomerator2.Name = "denomerator2";
            this.denomerator2.Size = new System.Drawing.Size(59, 37);
            this.denomerator2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // resl
            // 
            this.resl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resl.Location = new System.Drawing.Point(301, 74);
            this.resl.Margin = new System.Windows.Forms.Padding(4);
            this.resl.Name = "resl";
            this.resl.Size = new System.Drawing.Size(117, 37);
            this.resl.TabIndex = 9;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resl);
            this.Controls.Add(this.denomerator2);
            this.Controls.Add(this.numerator2);
            this.Controls.Add(this.denomerator1);
            this.Controls.Add(this.numerator1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox numerator1;
        private System.Windows.Forms.TextBox denomerator1;
        private System.Windows.Forms.TextBox numerator2;
        private System.Windows.Forms.TextBox denomerator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resl;
    }
}


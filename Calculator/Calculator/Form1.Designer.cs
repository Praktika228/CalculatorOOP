﻿namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.divx = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.minusx = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(178, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(26, 89);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 30);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Button_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(112, 89);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 30);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(198, 89);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 30);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Button_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(284, 89);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 30);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Button_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.Location = new System.Drawing.Point(112, 125);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(80, 30);
            this.sqrt.TabIndex = 7;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.Button2_Click);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Location = new System.Drawing.Point(26, 125);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 30);
            this.square.TabIndex = 8;
            this.square.Text = "^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.Button2_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.Location = new System.Drawing.Point(26, 161);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(80, 30);
            this.mod.TabIndex = 9;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.Button_Click);
            // 
            // divx
            // 
            this.divx.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divx.Location = new System.Drawing.Point(284, 197);
            this.divx.Name = "divx";
            this.divx.Size = new System.Drawing.Size(80, 30);
            this.divx.TabIndex = 10;
            this.divx.Text = "1/x";
            this.divx.UseVisualStyleBackColor = true;
            this.divx.Click += new System.EventHandler(this.Button2_Click);
            // 
            // abs
            // 
            this.abs.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abs.Location = new System.Drawing.Point(370, 197);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(80, 30);
            this.abs.TabIndex = 11;
            this.abs.Text = "abs";
            this.abs.UseVisualStyleBackColor = true;
            this.abs.Click += new System.EventHandler(this.Button2_Click);
            // 
            // minusx
            // 
            this.minusx.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusx.Location = new System.Drawing.Point(198, 197);
            this.minusx.Name = "minusx";
            this.minusx.Size = new System.Drawing.Size(80, 30);
            this.minusx.TabIndex = 12;
            this.minusx.Text = "-x";
            this.minusx.UseVisualStyleBackColor = true;
            this.minusx.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ln
            // 
            this.ln.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.Location = new System.Drawing.Point(112, 197);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(80, 30);
            this.ln.TabIndex = 13;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.Button2_Click);
            // 
            // e
            // 
            this.e.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.Location = new System.Drawing.Point(26, 197);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(80, 30);
            this.e.TabIndex = 14;
            this.e.Text = "e^";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cos.Location = new System.Drawing.Point(370, 161);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(80, 30);
            this.cos.TabIndex = 15;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.Location = new System.Drawing.Point(284, 161);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(80, 30);
            this.sin.TabIndex = 16;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max.Location = new System.Drawing.Point(198, 161);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(80, 30);
            this.max.TabIndex = 17;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.Button_Click);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(112, 161);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(80, 30);
            this.min.TabIndex = 18;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 494);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.e);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.minusx);
            this.Controls.Add(this.abs);
            this.Controls.Add(this.divx);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.square);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button divx;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button minusx;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button min;
    }
}


namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.logx = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.geometric = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.twopow = new System.Windows.Forms.Button();
            this.tenpow = new System.Windows.Forms.Button();
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
            this.plus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus.BackgroundImage")));
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minus.BackgroundImage")));
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.multiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("multiply.BackgroundImage")));
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.divide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divide.BackgroundImage")));
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.sqrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sqrt.BackgroundImage")));
            this.sqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square.BackgroundImage")));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.mod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mod.BackgroundImage")));
            this.mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.divx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divx.BackgroundImage")));
            this.divx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.abs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("abs.BackgroundImage")));
            this.abs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.minusx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusx.BackgroundImage")));
            this.minusx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.ln.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ln.BackgroundImage")));
            this.ln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.e.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("e.BackgroundImage")));
            this.e.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.cos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cos.BackgroundImage")));
            this.cos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.sin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sin.BackgroundImage")));
            this.sin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("max.BackgroundImage")));
            this.max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min.BackgroundImage")));
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(112, 161);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(80, 30);
            this.min.TabIndex = 18;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Button_Click);
            // 
            // logx
            // 
            this.logx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logx.BackgroundImage")));
            this.logx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logx.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logx.Location = new System.Drawing.Point(26, 232);
            this.logx.Name = "logx";
            this.logx.Size = new System.Drawing.Size(80, 30);
            this.logx.TabIndex = 19;
            this.logx.Text = "logx(y)";
            this.logx.UseVisualStyleBackColor = true;
            this.logx.Click += new System.EventHandler(this.Button_Click);
            // 
            // average
            // 
            this.average.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("average.BackgroundImage")));
            this.average.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.average.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.average.Location = new System.Drawing.Point(112, 232);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(80, 30);
            this.average.TabIndex = 20;
            this.average.Text = "average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.Button_Click);
            // 
            // tan
            // 
            this.tan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tan.BackgroundImage")));
            this.tan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tan.Location = new System.Drawing.Point(284, 233);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(80, 30);
            this.tan.TabIndex = 21;
            this.tan.Text = "tan(x)";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.Button2_Click);
            // 
            // geometric
            // 
            this.geometric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geometric.BackgroundImage")));
            this.geometric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geometric.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.geometric.Location = new System.Drawing.Point(198, 232);
            this.geometric.Name = "geometric";
            this.geometric.Size = new System.Drawing.Size(80, 30);
            this.geometric.TabIndex = 22;
            this.geometric.Text = "geometric";
            this.geometric.UseVisualStyleBackColor = true;
            this.geometric.Click += new System.EventHandler(this.Button_Click);
            // 
            // arcsin
            // 
            this.arcsin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arcsin.BackgroundImage")));
            this.arcsin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arcsin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arcsin.Location = new System.Drawing.Point(370, 232);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(80, 30);
            this.arcsin.TabIndex = 23;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // arccos
            // 
            this.arccos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arccos.BackgroundImage")));
            this.arccos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arccos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arccos.Location = new System.Drawing.Point(26, 268);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(80, 30);
            this.arccos.TabIndex = 24;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ctan
            // 
            this.ctan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctan.BackgroundImage")));
            this.ctan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctan.Location = new System.Drawing.Point(112, 268);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(80, 30);
            this.ctan.TabIndex = 25;
            this.ctan.Text = "ctan(x)";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.Button2_Click);
            // 
            // arctan
            // 
            this.arctan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arctan.BackgroundImage")));
            this.arctan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arctan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arctan.Location = new System.Drawing.Point(198, 268);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(80, 30);
            this.arctan.TabIndex = 26;
            this.arctan.Text = "arctan(x)";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.Button2_Click);
            // 
            // twopow
            // 
            this.twopow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twopow.BackgroundImage")));
            this.twopow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twopow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twopow.Location = new System.Drawing.Point(284, 268);
            this.twopow.Name = "twopow";
            this.twopow.Size = new System.Drawing.Size(80, 30);
            this.twopow.TabIndex = 27;
            this.twopow.Text = "2^x";
            this.twopow.UseVisualStyleBackColor = true;
            this.twopow.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tenpow
            // 
            this.tenpow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tenpow.BackgroundImage")));
            this.tenpow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tenpow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenpow.Location = new System.Drawing.Point(370, 268);
            this.tenpow.Name = "tenpow";
            this.tenpow.Size = new System.Drawing.Size(80, 30);
            this.tenpow.TabIndex = 28;
            this.tenpow.Text = "10^x";
            this.tenpow.UseVisualStyleBackColor = true;
            this.tenpow.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculator.Properties.Resources.hqdefault;
            this.ClientSize = new System.Drawing.Size(475, 324);
            this.Controls.Add(this.tenpow);
            this.Controls.Add(this.twopow);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.geometric);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.average);
            this.Controls.Add(this.logx);
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
        private System.Windows.Forms.Button logx;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button geometric;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button twopow;
        private System.Windows.Forms.Button tenpow;
    }
}


namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBotxtpantalla = new TextBox();
            textBox1 = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDividir = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiplicar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnRestar = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnSumar = new Button();
            btnClear = new Button();
            btnBackspace = new Button();
            btnBinario = new Button();
            btnHex = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBotxtpantalla
            // 
            textBotxtpantalla.Location = new Point(8, 8);
            textBotxtpantalla.Name = "textBotxtpantalla";
            textBotxtpantalla.ReadOnly = true;
            textBotxtpantalla.Size = new Size(380, 31);
            textBotxtpantalla.TabIndex = 2;
            textBotxtpantalla.Text = "0";
            textBotxtpantalla.TextAlign = HorizontalAlignment.Right;
            textBotxtpantalla.TextChanged += textBotxtpantalla_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // btn7
            // 
            btn7.Location = new Point(0, 70);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 34);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(106, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 34);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(213, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 34);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button1_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(316, 70);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(112, 34);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(0, 129);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 34);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button3_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(106, 128);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 34);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button4_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(213, 128);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 34);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button5_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(316, 128);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(112, 34);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = " *";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(0, 185);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 34);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(106, 185);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 34);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button8_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(213, 185);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 34);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button9_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(316, 185);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(112, 34);
            btnRestar.TabIndex = 16;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(0, 242);
            btn0.Name = "btn0";
            btn0.Size = new Size(112, 34);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(106, 242);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(112, 34);
            btnIgual.TabIndex = 18;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(213, 242);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 34);
            btnSumar.TabIndex = 19;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(316, 242);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 20;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button14_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(0, 296);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(112, 34);
            btnBackspace.TabIndex = 21;
            btnBackspace.Text = "🔙";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnBinario
            // 
            btnBinario.BackColor = Color.WhiteSmoke;
            btnBinario.Location = new Point(161, 296);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(112, 34);
            btnBinario.TabIndex = 22;
            btnBinario.Text = "BIN";
            btnBinario.UseVisualStyleBackColor = false;
            // 
            // btnHex
            // 
            btnHex.Location = new Point(316, 296);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(112, 34);
            btnHex.TabIndex = 23;
            btnHex.Text = "HEX";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 544);
            Controls.Add(btnHex);
            Controls.Add(btnBinario);
            Controls.Add(btnBackspace);
            Controls.Add(btnClear);
            Controls.Add(btnSumar);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnRestar);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDividir);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(textBox1);
            Controls.Add(textBotxtpantalla);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBotxtpantalla;
        private TextBox textBox1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDividir;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiplicar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnRestar;
        private Button btn0;
        private Button btnIgual;
        private Button btnSumar;
        private Button btnClear;
        private Button btnBackspace;
        private Button btnBinario;
        private Button btnHex;
    }
}

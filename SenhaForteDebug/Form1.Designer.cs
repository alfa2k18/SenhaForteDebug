namespace SenhaForteDebug
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountLower = new System.Windows.Forms.Label();
            this.labelCountUpper = new System.Windows.Forms.Label();
            this.labelCountControl = new System.Windows.Forms.Label();
            this.labelCountSymbol = new System.Windows.Forms.Label();
            this.labelCountNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPhraseLength = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelContarRepitidos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira alguma palavra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letras maiúsculas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Letras minúsculas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Caracteres especiais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Símbolos:";
            // 
            // labelCountLower
            // 
            this.labelCountLower.AutoSize = true;
            this.labelCountLower.Location = new System.Drawing.Point(123, 48);
            this.labelCountLower.Name = "labelCountLower";
            this.labelCountLower.Size = new System.Drawing.Size(13, 13);
            this.labelCountLower.TabIndex = 6;
            this.labelCountLower.Text = "0";
            // 
            // labelCountUpper
            // 
            this.labelCountUpper.AutoSize = true;
            this.labelCountUpper.Location = new System.Drawing.Point(123, 69);
            this.labelCountUpper.Name = "labelCountUpper";
            this.labelCountUpper.Size = new System.Drawing.Size(13, 13);
            this.labelCountUpper.TabIndex = 7;
            this.labelCountUpper.Text = "0";
            // 
            // labelCountControl
            // 
            this.labelCountControl.AutoSize = true;
            this.labelCountControl.Location = new System.Drawing.Point(123, 90);
            this.labelCountControl.Name = "labelCountControl";
            this.labelCountControl.Size = new System.Drawing.Size(13, 13);
            this.labelCountControl.TabIndex = 8;
            this.labelCountControl.Text = "0";
            // 
            // labelCountSymbol
            // 
            this.labelCountSymbol.AutoSize = true;
            this.labelCountSymbol.Location = new System.Drawing.Point(123, 111);
            this.labelCountSymbol.Name = "labelCountSymbol";
            this.labelCountSymbol.Size = new System.Drawing.Size(13, 13);
            this.labelCountSymbol.TabIndex = 9;
            this.labelCountSymbol.Text = "0";
            // 
            // labelCountNumber
            // 
            this.labelCountNumber.AutoSize = true;
            this.labelCountNumber.Location = new System.Drawing.Point(123, 132);
            this.labelCountNumber.Name = "labelCountNumber";
            this.labelCountNumber.Size = new System.Drawing.Size(13, 13);
            this.labelCountNumber.TabIndex = 11;
            this.labelCountNumber.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Números:";
            // 
            // labelPhraseLength
            // 
            this.labelPhraseLength.AutoSize = true;
            this.labelPhraseLength.Location = new System.Drawing.Point(123, 239);
            this.labelPhraseLength.Name = "labelPhraseLength";
            this.labelPhraseLength.Size = new System.Drawing.Size(13, 13);
            this.labelPhraseLength.TabIndex = 13;
            this.labelPhraseLength.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Comprimento:";
            // 
            // labelContarRepitidos
            // 
            this.labelContarRepitidos.AutoSize = true;
            this.labelContarRepitidos.Location = new System.Drawing.Point(123, 153);
            this.labelContarRepitidos.Name = "labelContarRepitidos";
            this.labelContarRepitidos.Size = new System.Drawing.Size(13, 13);
            this.labelContarRepitidos.TabIndex = 15;
            this.labelContarRepitidos.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repitidos:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(123, 174);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(13, 13);
            this.labelSenha.TabIndex = 17;
            this.labelSenha.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lembrete da senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 20);
            this.textBox2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelContarRepitidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPhraseLength);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelCountNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelCountSymbol);
            this.Controls.Add(this.labelCountControl);
            this.Controls.Add(this.labelCountUpper);
            this.Controls.Add(this.labelCountLower);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountLower;
        private System.Windows.Forms.Label labelCountUpper;
        private System.Windows.Forms.Label labelCountControl;
        private System.Windows.Forms.Label labelCountSymbol;
        private System.Windows.Forms.Label labelCountNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPhraseLength;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelContarRepitidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}


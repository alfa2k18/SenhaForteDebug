using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenhaForteDebug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int compMin = 8;
        static int compMax = 256;
        int minChar = 0;
        int maiChar = 0;
        int carChar = 0;
        int simChar = 0;
        int numChar = 0;
        int repChar = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            minChar = textBox1.Text.Where(c => Char.IsLower(c)).Count();
            maiChar = textBox1.Text.Where(c => Char.IsUpper(c)).Count();
            carChar = textBox1.Text.Where(c => Char.IsPunctuation(c)).Count();
            simChar = textBox1.Text.Where(c => Char.IsSymbol(c)).Count();
            numChar = textBox1.Text.Where(c => Char.IsDigit(c)).Count();
            repChar = textBox1.Text.GroupBy(c => c).Where(c => c.Count() > 1).Count();

            labelCountLower.Text = maiChar.ToString();
            labelCountUpper.Text = minChar.ToString();
            labelCountControl.Text = carChar.ToString();
            labelCountSymbol.Text = simChar.ToString();
            labelCountNumber.Text = numChar.ToString();
            labelPhraseLength.Text = textBox1.TextLength.ToString();
            labelContarRepitidos.Text = repChar.ToString();
            labelSenha.Text = VerificaSenha(textBox1.Text).ToString();
        }

        private static bool VerificaSenha(string senha)
        {
            Regex password = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!#$%&'()*+,-./:;?@[\\\]_`{|}~^]).*$");

            Match passwordMatch = password.Match(senha);

            return passwordMatch.Success;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[!#$%&'()*+,-./:;?@[\\\]_`{|}~^]");
            Match match = regex.Match(textBox1.Text);
            if (match.Success)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Falha");
            }
        }
    }
}

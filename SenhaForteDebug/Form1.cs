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
            labelSenha.Text = IsPasswordStrong(textBox1.Text).ToString();
        }

        private static bool VerificaSenha(string senha)
        {
            Regex password = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!#$%&'()*+,-./:;?@[\\\]_`{|}~^]).*$");

            Match passwordMatch = password.Match(senha);

            return passwordMatch.Success;
        }

        /// <summary>
        /// Valida os requirimentos da senha
        /// </summary>
        /// <param name="senha"></param>
        /// <returns>Verdadeiro ou Falso</returns>
        public static bool verificaSenhaForte(string senha)
        {
            //Listagem 1 – Verifica a quantidade de caracteres existentes na senha digitada.
            if (senha.Length < compMin || senha.Length > compMax)
                return false;

            //Listagem 2 – Verifica se existe pelo menos um número na senha.
            if (!senha.Any(c => char.IsDigit(c)))
                return false;

            //Listagem 3 – Verifica se existe pelo menos uma letra maiúscula.
            if (!senha.Any(c => char.IsUpper(c)))
                return false;

            //Listagem 4 – Verifica se existe pelo menos um caracter minúsculo.
            if (!senha.Any(c => char.IsLower(c)))
                return false;

            //Listagem 5 – Verifica se existe algum caracter especial.
            if (!senha.Any(c => char.IsSymbol(c)))
                return false;

            //Listagem 6 – Verifica se não existe algum caracter especial.
            if (!(senha.Any(c => char.IsLetterOrDigit(c))))
                return false;

            //Listagem 7 – Verifica se existe mais que dois caracteres repetidos.
            var contadorRepetido = 0;
            var ultimoCaracter = '\0';

            foreach (var c in senha)
            {
                if (c == ultimoCaracter)
                    contadorRepetido++;
                else
                    contadorRepetido = 0;
                if (contadorRepetido == 2)
                    return false;
                ultimoCaracter = c;
            }

            return true;
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

        /// <summary>
        /// Função que verifica se a string informada Ex: "Tes123@#$" será aceita.
        /// UMA LETRA MINÚSCULA,
        /// UMA LETRA MAIÚSCULA,
        /// UM NÚMERO,
        /// UM ESPECIAL E
        /// NO MÍNIMO 8 CARACTERES.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsPasswordStrong(string password)
        {
            int tamanhoMinimo = 8;
            int tamanhoMinusculo = 1;
            int tamanhoMaiusculo = 1;
            int tamanhoNumeros = 1;
            int tamanhoCaracteresEspeciais = 1;

            // Definição de letras minusculos
            Regex regTamanhoMinusculo = new Regex("[a-z]");

            // Definição de letras maiusculos
            Regex regTamanhoMaiusculo = new Regex("[A-Z]");

            // Definição de letras números
            Regex regTamanhoNumeros = new Regex("[0-9]");

            // Definição de letras caracteres
            Regex regCaracteresEspeciais = new Regex("[^a-zA-Z0-9]");

            // Verificando tamanho minimo
            if (password.Length < tamanhoMinimo) return false;

            // Verificando caracteres minusculos
            if (regTamanhoMinusculo.Matches(password).Count < tamanhoMinusculo) return false;

            // Verificando caracteres maiusculos
            if (regTamanhoMaiusculo.Matches(password).Count < tamanhoMaiusculo) return false;

            // Verificando numeros
            if (regTamanhoNumeros.Matches(password).Count < tamanhoNumeros) return false;

            // Verificando os diferentes
            if (regCaracteresEspeciais.Matches(password).Count < tamanhoCaracteresEspeciais) return false;

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class lblNumero : Form
    {
        public lblNumero()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2 = 0;
            bool ehValido1 = double.TryParse(txtNumero1.Text, out numero1);
            bool ehValido2 = double.TryParse(txtNumero2.Text, out numero2);
            if (!ehValido1 || !ehValido2)
            {
                MessageBox.Show("Os valores digitados não são um número",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rdbSoma.Checked)
            {
                resultado = numero1 + numero2;
                string mensagem = $"A soma dos números é: " + resultado;
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtracao.Checked == true)
            {
                resultado = numero1 - numero2;
                string mensagem = $"A subtração dos números de {numero1} - {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbDivisao.Checked == true)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("O denomidador não pode ser zero", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = numero1 / numero2;
                    string mensagem = $"A divisão dos números de {numero1} / {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdbPotenciacao.Checked == true)
            {
                resultado = Math.Pow(numero1, numero2);
                string mensagem = $"A potenciação dos números de {numero1} ^ {numero2} = {resultado}";
                MessageBox.Show(mensagem, "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb)
            {

            }
        }
    }
}

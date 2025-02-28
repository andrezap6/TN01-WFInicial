using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFInicial
{
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaSemana_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntEscolher_Click(object sender, EventArgs e)
        {
            byte opcao = byte.Parse(txtDiaSemana.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda-Feira");
                    break;
                case 3:
                    MessageBox.Show("Terça-Feira");
                    break;
                case 4:
                    MessageBox.Show("Quarta-Feira");
                    break;
                case 5:
                    MessageBox.Show("Quinta-Feira");
                    break;
                case 6:
                    MessageBox.Show("Sexta-Feira");
                    break;
                case 7:
                    MessageBox.Show("Sábado");
                    break;
                default:
                    MessageBox.Show("Dia inválido");
                    break;
            }
        }
    }
}

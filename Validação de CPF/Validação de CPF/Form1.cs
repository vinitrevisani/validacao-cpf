using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validação_de_CPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Validacao n = new Validacao();

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            int[] cpf = new int[11];
            int digito1, digito2;

            int valor = int.Parse(txtCPF.Text);

            cpf = n.CPF(valor);

            digito1 = n.DigitoUm(valor);
            digito2 = n.DigitoDois(valor);
            

            txtSituacao.Text = "";

            for (int i = 0; i < 3; i++)
            { 
                txtSituacao.Text += cpf[i].ToString();
            }
            txtSituacao.Text += ".";

            for (int i = 3; i < 6; i++)
            {
                txtSituacao.Text += cpf[i].ToString();
            }
            txtSituacao.Text += ".";

            for (int i = 6; i < 9; i++)
            {
                txtSituacao.Text += cpf[i].ToString();
            }
            txtSituacao.Text += "-";

            txtSituacao.Text += digito1;
            txtSituacao.Text += digito2;

            int digitoUF = cpf[8];

            txtUF.Text = n.UF(digitoUF);
        }
    }
}

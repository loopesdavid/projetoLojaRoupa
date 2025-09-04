using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLojaRoupa
{
    public partial class Pedido : Form
    {
        // instanciando a classe de conexão
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // declarando as variaveis
            double tamanho = 0, valor = 0, valorTotal = 0;

            if (cmbTamanho.SelectedIndex == 0)
            {
                tamanho = 0;
            }
            else if (cmbTamanho.SelectedIndex == 1)
            {
                tamanho = 1;
            }
            else if (cmbTamanho.SelectedIndex == 2)
            {
                tamanho = 2;
            }
            else if (cmbTamanho.SelectedIndex == 3)
            {
                tamanho = 3;
            }
            else if (cmbTamanho.SelectedIndex == 4)
            {
                tamanho = 4;
            }
            else if (cmbTamanho.SelectedIndex == 5)
            {
                tamanho = 5;
            }
            else if (cmbTamanho.SelectedIndex == 6)
            {
                tamanho = 6;
            }
            if (chkAdidas.Checked == true)
            {
                valor = valor + 1000;
            }
            if (chkAsics.Checked == true)
            {
                valor = valor + 900;
            }
            if (chkInitiator.Checked == true)
            {
                valor = valor + 599;
            }
            if (chkNewBalance.Checked == true)
            {
                valor = valor + 1000;
            }
            if (chkNocta.Checked == true)
            {
                valor = valor + 2000;
            }
            if (chkPuma.Checked == true)
            {
                valor = valor + 699;
            }
            else
            {

            }
            valorTotal = valor + tamanho;
            txtValor.Text = Convert.ToString(valor);
            txtQuantidade.Text = Convert.ToString(tamanho);
            txtTotalPagar.Text = Convert.ToString(valorTotal);
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTamanho.Items.Add("N°36");
            cmbTamanho.Items.Add("N°37");
            cmbTamanho.Items.Add("N°38");
            cmbTamanho.Items.Add("N°39");
            cmbTamanho.Items.Add("N°40");
            cmbTamanho.Items.Add("N°41");
            cmbTamanho.Items.Add("N°42");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            chkAdidas.Checked = false;
            chkAsics.Checked = false;
            chkInitiator.Checked = false;
            chkNewBalance.Checked = false;
            chkNocta.Checked = false;
            chkPuma.Checked = false;

            txtQuantidade.Clear();
            txtTotalPagar.Clear();
            txtValor.Clear();
            cmbTamanho.SelectedIndex = 0;
        }
    }
}

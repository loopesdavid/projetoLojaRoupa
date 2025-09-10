using MySql.Data.MySqlClient;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica os campos
            if (txtValor.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValor.Focus();
            }
            else if (txtTotalPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtTotalPagar.Focus();
            }
            else if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtQuantidade.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tamanhoTenis,valorTenis,valorQuantidade,valorTotal) values(@tmtenis,@vtenis,@quantidade,@total");
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tmtenis", MySqlDbType.Text).Value = cmbTamanho.Text;
                    cmd.Parameters.Add("@vtenis", MySqlDbType.Text).Value = txtValor.Text;
                    cmd.Parameters.Add("@quantidade", MySqlDbType.Text).Value = txtQuantidade.Text;
                    cmd.Parameters.Add("total", MySqlDbType.Text).Value = txtTotalPagar.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanho.Text = "";
                    txtValor.Text = "";
                    txtQuantidade.Text = "";
                    txtTotalPagar.Text = "";
                    cmbTamanho.Focus();
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dgvPedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }

        //METODO QUE VAI CARREGAR AS INFORMAÇÕES NO DATA GRID
        public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dgvPedidos.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanho.Text = dgvPedidos.SelectedRows[0].Cells[1].Value.ToString();
                txtValor.Text = dgvPedidos.SelectedRows[0].Cells[2].Value.ToString();
                txtQuantidade.Text = dgvPedidos.SelectedRows[0].Cells[3].Value.ToString();
                txtTotalPagar.Text = dgvPedidos.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao clicar" + error);
            }
        }
    }
}

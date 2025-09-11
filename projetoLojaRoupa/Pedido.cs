using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            int quantidade = 0;

            if (chkAdidas.Checked == true)
            {
                quantidade++;
                valor = valor + 1000;
            }
            if (chkAsics.Checked == true)
            {
                quantidade++;
                valor = valor + 900;
            }
            if (chkInitiator.Checked == true)
            {
                quantidade++;
                valor = valor + 599;
            }
            if (chkNewBalance.Checked == true)
            {
                quantidade++;
                valor = valor + 1000;
            }
            if (chkNocta.Checked == true)
            {
                quantidade++;
                valor = valor + 2000;
            }
            if (chkPuma.Checked == true)
            {
                quantidade++;
                valor = valor + 699;
            }
            else
            {

            }
            valorTotal = valor + tamanho;
            txtValor.Text = Convert.ToString(valor);
            txtQuantidade.Text = Convert.ToString(quantidade);
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
                //inserindo dados no banco de dados
                string sql = "insert into tbPedido(tamanhoTenis,valorTenis,valorQuantidade,valorTotal) values(@tamanho,@vtenis,@vquantidade,@total)";
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.Add("@tamanho", MySqlDbType.Text).Value = cmbTamanho.Text;
                cmd.Parameters.Add("@vtenis", MySqlDbType.Text).Value = txtValor.Text;
                cmd.Parameters.Add("@vquantidade", MySqlDbType.Text).Value = txtQuantidade.Text;
                cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotalPagar.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadstrados com sucesso");
                cmbTamanho.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                txtTotalPagar.Text = "";
                cmbTamanho.Focus();
                con.DesConnectarBD();

                MessageBox.Show("Dados cadastrados com Sucesso !!!");

                cmbTamanho.Text = "";
                txtValor.Clear();
                txtQuantidade.Clear();
                txtTotalPagar.Clear();
                cmbTamanho.Focus();
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedidos.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPedidos.DataSource = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair ?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                Pedido ped = new Pedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void grpEscolhaTenis_Enter(object sender, EventArgs e)
        {

        }
    }
}

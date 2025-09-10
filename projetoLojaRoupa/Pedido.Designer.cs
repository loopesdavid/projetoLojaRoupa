namespace projetoLojaRoupa
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.grpEscolhaTenis = new System.Windows.Forms.GroupBox();
            this.chkNocta = new System.Windows.Forms.CheckBox();
            this.chkPuma = new System.Windows.Forms.CheckBox();
            this.chkNewBalance = new System.Windows.Forms.CheckBox();
            this.picNewBalance = new System.Windows.Forms.PictureBox();
            this.picPuma = new System.Windows.Forms.PictureBox();
            this.picAdidas = new System.Windows.Forms.PictureBox();
            this.chkAdidas = new System.Windows.Forms.CheckBox();
            this.chkAsics = new System.Windows.Forms.CheckBox();
            this.chkInitiator = new System.Windows.Forms.CheckBox();
            this.picAsics = new System.Windows.Forms.PictureBox();
            this.picInitiator = new System.Windows.Forms.PictureBox();
            this.picNocta = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.grpEscolhaTenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInitiator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(419, 170);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(349, 158);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedidos_MouseDoubleClick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(371, 38);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "VALOR";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(489, 38);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(78, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "QUANTIDADE";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(635, 38);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(92, 13);
            this.lblTotalPagar.TabIndex = 3;
            this.lblTotalPagar.Text = "TOTAL A PAGAR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(345, 66);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 4;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(627, 66);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(482, 66);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(419, 357);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 38);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(511, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 38);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(601, 357);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(693, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Location = new System.Drawing.Point(36, 65);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(144, 21);
            this.cmbTamanho.TabIndex = 11;
            this.cmbTamanho.Text = "ESCOLHA O TAMANHO";
            // 
            // grpEscolhaTenis
            // 
            this.grpEscolhaTenis.Controls.Add(this.chkNocta);
            this.grpEscolhaTenis.Controls.Add(this.chkPuma);
            this.grpEscolhaTenis.Controls.Add(this.chkNewBalance);
            this.grpEscolhaTenis.Controls.Add(this.picNewBalance);
            this.grpEscolhaTenis.Controls.Add(this.picPuma);
            this.grpEscolhaTenis.Controls.Add(this.picAdidas);
            this.grpEscolhaTenis.Controls.Add(this.chkAdidas);
            this.grpEscolhaTenis.Controls.Add(this.chkAsics);
            this.grpEscolhaTenis.Controls.Add(this.chkInitiator);
            this.grpEscolhaTenis.Controls.Add(this.picAsics);
            this.grpEscolhaTenis.Controls.Add(this.picInitiator);
            this.grpEscolhaTenis.Controls.Add(this.picNocta);
            this.grpEscolhaTenis.Location = new System.Drawing.Point(12, 137);
            this.grpEscolhaTenis.Name = "grpEscolhaTenis";
            this.grpEscolhaTenis.Size = new System.Drawing.Size(376, 286);
            this.grpEscolhaTenis.TabIndex = 12;
            this.grpEscolhaTenis.TabStop = false;
            this.grpEscolhaTenis.Text = "Escolha seu tênis:";
            // 
            // chkNocta
            // 
            this.chkNocta.AutoSize = true;
            this.chkNocta.Location = new System.Drawing.Point(6, 136);
            this.chkNocta.Name = "chkNocta";
            this.chkNocta.Size = new System.Drawing.Size(109, 17);
            this.chkNocta.TabIndex = 0;
            this.chkNocta.Text = "Nocta Hot Step II";
            this.chkNocta.UseVisualStyleBackColor = true;
            // 
            // chkPuma
            // 
            this.chkPuma.AutoSize = true;
            this.chkPuma.Location = new System.Drawing.Point(281, 136);
            this.chkPuma.Name = "chkPuma";
            this.chkPuma.Size = new System.Drawing.Size(74, 17);
            this.chkPuma.TabIndex = 7;
            this.chkPuma.Text = "Puma 180";
            this.chkPuma.UseVisualStyleBackColor = true;
            // 
            // chkNewBalance
            // 
            this.chkNewBalance.AutoSize = true;
            this.chkNewBalance.Location = new System.Drawing.Point(281, 264);
            this.chkNewBalance.Name = "chkNewBalance";
            this.chkNewBalance.Size = new System.Drawing.Size(68, 17);
            this.chkNewBalance.TabIndex = 6;
            this.chkNewBalance.Text = "NB 1000";
            this.chkNewBalance.UseVisualStyleBackColor = true;
            // 
            // picNewBalance
            // 
            this.picNewBalance.Location = new System.Drawing.Point(281, 159);
            this.picNewBalance.Name = "picNewBalance";
            this.picNewBalance.Size = new System.Drawing.Size(80, 89);
            this.picNewBalance.TabIndex = 5;
            this.picNewBalance.TabStop = false;
            // 
            // picPuma
            // 
            this.picPuma.Location = new System.Drawing.Point(281, 33);
            this.picPuma.Name = "picPuma";
            this.picPuma.Size = new System.Drawing.Size(80, 89);
            this.picPuma.TabIndex = 4;
            this.picPuma.TabStop = false;
            // 
            // picAdidas
            // 
            this.picAdidas.Image = ((System.Drawing.Image)(resources.GetObject("picAdidas.Image")));
            this.picAdidas.Location = new System.Drawing.Point(150, 159);
            this.picAdidas.Name = "picAdidas";
            this.picAdidas.Size = new System.Drawing.Size(80, 89);
            this.picAdidas.TabIndex = 3;
            this.picAdidas.TabStop = false;
            // 
            // chkAdidas
            // 
            this.chkAdidas.AutoSize = true;
            this.chkAdidas.Location = new System.Drawing.Point(140, 264);
            this.chkAdidas.Name = "chkAdidas";
            this.chkAdidas.Size = new System.Drawing.Size(105, 17);
            this.chkAdidas.TabIndex = 3;
            this.chkAdidas.Text = "Adidas Harden 9";
            this.chkAdidas.UseVisualStyleBackColor = true;
            // 
            // chkAsics
            // 
            this.chkAsics.AutoSize = true;
            this.chkAsics.Location = new System.Drawing.Point(143, 136);
            this.chkAsics.Name = "chkAsics";
            this.chkAsics.Size = new System.Drawing.Size(95, 17);
            this.chkAsics.TabIndex = 2;
            this.chkAsics.Text = "Asics NYC Gel";
            this.chkAsics.UseVisualStyleBackColor = true;
            // 
            // chkInitiator
            // 
            this.chkInitiator.AutoSize = true;
            this.chkInitiator.Location = new System.Drawing.Point(12, 262);
            this.chkInitiator.Name = "chkInitiator";
            this.chkInitiator.Size = new System.Drawing.Size(85, 17);
            this.chkInitiator.TabIndex = 1;
            this.chkInitiator.Text = "Nike Initiator";
            this.chkInitiator.UseVisualStyleBackColor = true;
            // 
            // picAsics
            // 
            this.picAsics.Location = new System.Drawing.Point(150, 33);
            this.picAsics.Name = "picAsics";
            this.picAsics.Size = new System.Drawing.Size(80, 89);
            this.picAsics.TabIndex = 2;
            this.picAsics.TabStop = false;
            // 
            // picInitiator
            // 
            this.picInitiator.Location = new System.Drawing.Point(12, 159);
            this.picInitiator.Name = "picInitiator";
            this.picInitiator.Size = new System.Drawing.Size(80, 89);
            this.picInitiator.TabIndex = 1;
            this.picInitiator.TabStop = false;
            // 
            // picNocta
            // 
            this.picNocta.Location = new System.Drawing.Point(12, 33);
            this.picNocta.Name = "picNocta";
            this.picNocta.Size = new System.Drawing.Size(80, 89);
            this.picNocta.TabIndex = 0;
            this.picNocta.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(467, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(627, 137);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(635, 121);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(464, 121);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "CODIGO";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.grpEscolhaTenis);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.grpEscolhaTenis.ResumeLayout(false);
            this.grpEscolhaTenis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInitiator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.GroupBox grpEscolhaTenis;
        private System.Windows.Forms.CheckBox chkAsics;
        private System.Windows.Forms.CheckBox chkInitiator;
        private System.Windows.Forms.CheckBox chkNocta;
        private System.Windows.Forms.CheckBox chkAdidas;
        private System.Windows.Forms.CheckBox chkPuma;
        private System.Windows.Forms.CheckBox chkNewBalance;
        private System.Windows.Forms.PictureBox picNewBalance;
        private System.Windows.Forms.PictureBox picPuma;
        private System.Windows.Forms.PictureBox picAdidas;
        private System.Windows.Forms.PictureBox picAsics;
        private System.Windows.Forms.PictureBox picInitiator;
        private System.Windows.Forms.PictureBox picNocta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblCodigo;
    }
}
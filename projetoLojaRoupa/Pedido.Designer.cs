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
            this.dgvPedidos.Location = new System.Drawing.Point(559, 209);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(465, 194);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedidos_MouseDoubleClick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(495, 47);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(52, 16);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "VALOR";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(652, 47);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 16);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "QUANTIDADE";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(847, 47);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(113, 16);
            this.lblTotalPagar.TabIndex = 3;
            this.lblTotalPagar.Text = "TOTAL A PAGAR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(460, 81);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 22);
            this.txtValor.TabIndex = 4;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(836, 81);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(132, 22);
            this.txtTotalPagar.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(643, 81);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(132, 22);
            this.txtQuantidade.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(559, 439);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 47);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(681, 439);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 47);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(801, 439);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 47);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(924, 439);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 47);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Location = new System.Drawing.Point(90, 79);
            this.cmbTamanho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(180, 24);
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
            this.grpEscolhaTenis.Location = new System.Drawing.Point(16, 169);
            this.grpEscolhaTenis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEscolhaTenis.Name = "grpEscolhaTenis";
            this.grpEscolhaTenis.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEscolhaTenis.Size = new System.Drawing.Size(501, 352);
            this.grpEscolhaTenis.TabIndex = 12;
            this.grpEscolhaTenis.TabStop = false;
            this.grpEscolhaTenis.Text = "Escolha seu tênis:";
            // 
            // chkNocta
            // 
            this.chkNocta.AutoSize = true;
            this.chkNocta.Location = new System.Drawing.Point(8, 167);
            this.chkNocta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNocta.Name = "chkNocta";
            this.chkNocta.Size = new System.Drawing.Size(129, 20);
            this.chkNocta.TabIndex = 0;
            this.chkNocta.Text = "Nocta Hot Step II";
            this.chkNocta.UseVisualStyleBackColor = true;
            // 
            // chkPuma
            // 
            this.chkPuma.AutoSize = true;
            this.chkPuma.Location = new System.Drawing.Point(375, 167);
            this.chkPuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPuma.Name = "chkPuma";
            this.chkPuma.Size = new System.Drawing.Size(88, 20);
            this.chkPuma.TabIndex = 7;
            this.chkPuma.Text = "Puma 180";
            this.chkPuma.UseVisualStyleBackColor = true;
            // 
            // chkNewBalance
            // 
            this.chkNewBalance.AutoSize = true;
            this.chkNewBalance.Location = new System.Drawing.Point(375, 325);
            this.chkNewBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNewBalance.Name = "chkNewBalance";
            this.chkNewBalance.Size = new System.Drawing.Size(79, 20);
            this.chkNewBalance.TabIndex = 6;
            this.chkNewBalance.Text = "NB 1000";
            this.chkNewBalance.UseVisualStyleBackColor = true;
            // 
            // picNewBalance
            // 
            this.picNewBalance.Image = ((System.Drawing.Image)(resources.GetObject("picNewBalance.Image")));
            this.picNewBalance.Location = new System.Drawing.Point(375, 196);
            this.picNewBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNewBalance.Name = "picNewBalance";
            this.picNewBalance.Size = new System.Drawing.Size(107, 110);
            this.picNewBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewBalance.TabIndex = 5;
            this.picNewBalance.TabStop = false;
            // 
            // picPuma
            // 
            this.picPuma.Image = ((System.Drawing.Image)(resources.GetObject("picPuma.Image")));
            this.picPuma.Location = new System.Drawing.Point(375, 41);
            this.picPuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPuma.Name = "picPuma";
            this.picPuma.Size = new System.Drawing.Size(107, 110);
            this.picPuma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPuma.TabIndex = 4;
            this.picPuma.TabStop = false;
            // 
            // picAdidas
            // 
            this.picAdidas.Image = ((System.Drawing.Image)(resources.GetObject("picAdidas.Image")));
            this.picAdidas.Location = new System.Drawing.Point(200, 196);
            this.picAdidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAdidas.Name = "picAdidas";
            this.picAdidas.Size = new System.Drawing.Size(107, 110);
            this.picAdidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdidas.TabIndex = 3;
            this.picAdidas.TabStop = false;
            // 
            // chkAdidas
            // 
            this.chkAdidas.AutoSize = true;
            this.chkAdidas.Location = new System.Drawing.Point(187, 325);
            this.chkAdidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAdidas.Name = "chkAdidas";
            this.chkAdidas.Size = new System.Drawing.Size(130, 20);
            this.chkAdidas.TabIndex = 3;
            this.chkAdidas.Text = "Adidas Harden 9";
            this.chkAdidas.UseVisualStyleBackColor = true;
            // 
            // chkAsics
            // 
            this.chkAsics.AutoSize = true;
            this.chkAsics.Location = new System.Drawing.Point(191, 167);
            this.chkAsics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAsics.Name = "chkAsics";
            this.chkAsics.Size = new System.Drawing.Size(117, 20);
            this.chkAsics.TabIndex = 2;
            this.chkAsics.Text = "Asics NYC Gel";
            this.chkAsics.UseVisualStyleBackColor = true;
            // 
            // chkInitiator
            // 
            this.chkInitiator.AutoSize = true;
            this.chkInitiator.Location = new System.Drawing.Point(16, 322);
            this.chkInitiator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInitiator.Name = "chkInitiator";
            this.chkInitiator.Size = new System.Drawing.Size(102, 20);
            this.chkInitiator.TabIndex = 1;
            this.chkInitiator.Text = "Nike Initiator";
            this.chkInitiator.UseVisualStyleBackColor = true;
            // 
            // picAsics
            // 
            this.picAsics.Image = ((System.Drawing.Image)(resources.GetObject("picAsics.Image")));
            this.picAsics.Location = new System.Drawing.Point(200, 41);
            this.picAsics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAsics.Name = "picAsics";
            this.picAsics.Size = new System.Drawing.Size(107, 110);
            this.picAsics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAsics.TabIndex = 2;
            this.picAsics.TabStop = false;
            // 
            // picInitiator
            // 
            this.picInitiator.Image = ((System.Drawing.Image)(resources.GetObject("picInitiator.Image")));
            this.picInitiator.Location = new System.Drawing.Point(16, 196);
            this.picInitiator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picInitiator.Name = "picInitiator";
            this.picInitiator.Size = new System.Drawing.Size(107, 110);
            this.picInitiator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInitiator.TabIndex = 1;
            this.picInitiator.TabStop = false;
            // 
            // picNocta
            // 
            this.picNocta.Image = ((System.Drawing.Image)(resources.GetObject("picNocta.Image")));
            this.picNocta.Location = new System.Drawing.Point(16, 41);
            this.picNocta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNocta.Name = "picNocta";
            this.picNocta.Size = new System.Drawing.Size(107, 110);
            this.picNocta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNocta.TabIndex = 0;
            this.picNocta.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(623, 169);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(836, 169);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(132, 22);
            this.txtPesquisar.TabIndex = 14;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(847, 149);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(85, 16);
            this.lblPesquisar.TabIndex = 15;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(619, 149);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 16);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "CODIGO";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 673);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
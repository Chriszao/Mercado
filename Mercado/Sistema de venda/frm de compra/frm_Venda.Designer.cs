namespace Sistema_de_venda
{
    partial class frm_Venda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxVendaAVista = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btAddProd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.btLocCli = new System.Windows.Forms.Button();
            this.txtCliCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDataini = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNParcela = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTpagto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtVenCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lProduto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btSalvarFinal = new System.Windows.Forms.Button();
            this.btCancelarFinal = new System.Windows.Forms.Button();
            this.pnFinalizaCompra = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.Label();
            this.cbValidaQtde = new System.Windows.Forms.CheckBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbMsg);
            this.pnDados.Controls.Add(this.cbValidaQtde);
            this.pnDados.Controls.Add(this.cbxVendaAVista);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.txtTotalVenda);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.lCliente);
            this.pnDados.Controls.Add(this.btLocCli);
            this.pnDados.Controls.Add(this.txtCliCodigo);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.dtDataini);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cbNParcela);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbTpagto);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataVenda);
            this.pnDados.Controls.Add(this.txtVenCodigo);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lProduto);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Location = new System.Drawing.Point(4, 2);
            this.pnDados.Size = new System.Drawing.Size(771, 407);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(4, 410);
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(671, 2);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(537, 2);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(403, 2);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Text = "Cancelar Compra";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(0, 2);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Visible = false;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(268, 2);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(134, 2);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbxVendaAVista
            // 
            this.cbxVendaAVista.AutoSize = true;
            this.cbxVendaAVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVendaAVista.Location = new System.Drawing.Point(489, 370);
            this.cbxVendaAVista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxVendaAVista.Name = "cbxVendaAVista";
            this.cbxVendaAVista.Size = new System.Drawing.Size(127, 22);
            this.cbxVendaAVista.TabIndex = 104;
            this.cbxVendaAVista.Text = "Compra a vista";
            this.cbxVendaAVista.UseVisualStyleBackColor = true;
            this.cbxVendaAVista.CheckedChanged += new System.EventHandler(this.cbxVendaAVista_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(626, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 101;
            this.label12.Text = "Valor Unitário";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(514, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 100;
            this.label11.Text = "Quantidade";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.Color.White;
            this.btAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.Location = new System.Drawing.Point(722, 69);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(36, 33);
            this.btAddProd.TabIndex = 99;
            this.btAddProd.Text = "+";
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "Itens da Compra";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(626, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 19);
            this.txtValor.TabIndex = 97;
            this.txtValor.Text = "0.00";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(514, 78);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(80, 19);
            this.txtQtde.TabIndex = 96;
            this.txtQtde.Text = "0";
            // 
            // btLocProd
            // 
            this.btLocProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocProd.Location = new System.Drawing.Point(136, 120);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(37, 23);
            this.btLocProd.TabIndex = 94;
            this.btLocProd.Text = ". . .";
            this.btLocProd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btLocProd.UseVisualStyleBackColor = true;
            this.btLocProd.Click += new System.EventHandler(this.btLocProd_Click);
            // 
            // txtProCod
            // 
            this.txtProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCod.Location = new System.Drawing.Point(28, 120);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(104, 24);
            this.txtProCod.TabIndex = 93;
            this.txtProCod.Leave += new System.EventHandler(this.txtProCod_Leave);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(658, 370);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(98, 24);
            this.txtTotalVenda.TabIndex = 91;
            this.txtTotalVenda.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 90;
            this.label9.Text = "Data da Compra";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.Location = new System.Drawing.Point(178, 72);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(337, 18);
            this.lCliente.TabIndex = 89;
            this.lCliente.Text = "Informe o código do Cliente ou clique em localizar";
            this.lCliente.Click += new System.EventHandler(this.lCliente_Click);
            // 
            // btLocCli
            // 
            this.btLocCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocCli.Location = new System.Drawing.Point(136, 72);
            this.btLocCli.Name = "btLocCli";
            this.btLocCli.Size = new System.Drawing.Size(37, 24);
            this.btLocCli.TabIndex = 88;
            this.btLocCli.Text = ". . .";
            this.btLocCli.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btLocCli.UseVisualStyleBackColor = true;
            this.btLocCli.Click += new System.EventHandler(this.btLocCli_Click);
            // 
            // txtCliCodigo
            // 
            this.txtCliCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliCodigo.Location = new System.Drawing.Point(28, 72);
            this.txtCliCodigo.Name = "txtCliCodigo";
            this.txtCliCodigo.Size = new System.Drawing.Size(103, 24);
            this.txtCliCodigo.TabIndex = 87;
            this.txtCliCodigo.TextChanged += new System.EventHandler(this.txtCliCodigo_TextChanged);
            this.txtCliCodigo.Leave += new System.EventHandler(this.txtCliCodigo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 86;
            this.label7.Text = "Código do Cliente";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.provTotal});
            this.dgvItens.Location = new System.Drawing.Point(28, 167);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(727, 169);
            this.dgvItens.TabIndex = 85;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Código";
            this.proCod.MinimumWidth = 6;
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 80;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.MinimumWidth = 6;
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 250;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.MinimumWidth = 6;
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            this.forQtde.Width = 125;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitário";
            this.provund.MinimumWidth = 6;
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 130;
            // 
            // provTotal
            // 
            this.provTotal.HeaderText = "Valor Total";
            this.provTotal.MinimumWidth = 6;
            this.provTotal.Name = "provTotal";
            this.provTotal.ReadOnly = true;
            this.provTotal.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Data Inicial do Pagamento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtDataini
            // 
            this.dtDataini.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataini.Location = new System.Drawing.Point(328, 370);
            this.dtDataini.Name = "dtDataini";
            this.dtDataini.Size = new System.Drawing.Size(149, 24);
            this.dtDataini.TabIndex = 83;
            this.dtDataini.ValueChanged += new System.EventHandler(this.dtDataini_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "Numero de Parcelas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbNParcela
            // 
            this.cbNParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNParcela.FormattingEnabled = true;
            this.cbNParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNParcela.Location = new System.Drawing.Point(29, 370);
            this.cbNParcela.Name = "cbNParcela";
            this.cbNParcela.Size = new System.Drawing.Size(138, 25);
            this.cbNParcela.TabIndex = 81;
            this.cbNParcela.SelectedIndexChanged += new System.EventHandler(this.cbNParcela_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // cbTpagto
            // 
            this.cbTpagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTpagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTpagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTpagto.FormattingEnabled = true;
            this.cbTpagto.Location = new System.Drawing.Point(183, 370);
            this.cbTpagto.Name = "cbTpagto";
            this.cbTpagto.Size = new System.Drawing.Size(130, 25);
            this.cbTpagto.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(678, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Valor Total";
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataVenda.Location = new System.Drawing.Point(392, 24);
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(214, 24);
            this.dtDataVenda.TabIndex = 77;
            // 
            // txtVenCodigo
            // 
            this.txtVenCodigo.Enabled = false;
            this.txtVenCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenCodigo.Location = new System.Drawing.Point(27, 24);
            this.txtVenCodigo.Name = "txtVenCodigo";
            this.txtVenCodigo.Size = new System.Drawing.Size(104, 24);
            this.txtVenCodigo.TabIndex = 74;
            this.txtVenCodigo.TextChanged += new System.EventHandler(this.txtVenCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Código";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(632, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 18);
            this.label15.TabIndex = 103;
            this.label15.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 92;
            this.label10.Text = "Código do Produto";
            // 
            // lProduto
            // 
            this.lProduto.AutoSize = true;
            this.lProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProduto.Location = new System.Drawing.Point(178, 120);
            this.lProduto.Name = "lProduto";
            this.lProduto.Size = new System.Drawing.Size(343, 18);
            this.lProduto.TabIndex = 95;
            this.lProduto.Text = "Informe o código do produto ou clique em localizar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(599, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 102;
            this.label14.Text = "R$";
            // 
            // btSalvarFinal
            // 
            this.btSalvarFinal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btSalvarFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvarFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFinal.Location = new System.Drawing.Point(447, 358);
            this.btSalvarFinal.Name = "btSalvarFinal";
            this.btSalvarFinal.Size = new System.Drawing.Size(129, 35);
            this.btSalvarFinal.TabIndex = 48;
            this.btSalvarFinal.Text = "Salvar";
            this.btSalvarFinal.UseVisualStyleBackColor = false;
            this.btSalvarFinal.Click += new System.EventHandler(this.btSalvarFinal_Click);
            // 
            // btCancelarFinal
            // 
            this.btCancelarFinal.BackColor = System.Drawing.Color.Coral;
            this.btCancelarFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarFinal.Location = new System.Drawing.Point(447, 399);
            this.btCancelarFinal.Name = "btCancelarFinal";
            this.btCancelarFinal.Size = new System.Drawing.Size(129, 35);
            this.btCancelarFinal.TabIndex = 49;
            this.btCancelarFinal.Text = "Cancelar";
            this.btCancelarFinal.UseVisualStyleBackColor = false;
            this.btCancelarFinal.Click += new System.EventHandler(this.btCancelarFinal_Click);
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.label20);
            this.pnFinalizaCompra.Controls.Add(this.lbTotal);
            this.pnFinalizaCompra.Controls.Add(this.btCancelarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label19);
            this.pnFinalizaCompra.Controls.Add(this.btSalvarFinal);
            this.pnFinalizaCompra.Controls.Add(this.label18);
            this.pnFinalizaCompra.Controls.Add(this.label16);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(779, 2);
            this.pnFinalizaCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(588, 448);
            this.pnFinalizaCompra.TabIndex = 50;
            this.pnFinalizaCompra.Visible = false;
            this.pnFinalizaCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFinalizaCompra_Paint);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(509, 335);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 18);
            this.label20.TabIndex = 38;
            this.label20.Text = "R$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Red;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(538, 335);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 18);
            this.lbTotal.TabIndex = 28;
            this.lbTotal.Text = "0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(388, 335);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "Total da Compra:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 57);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 18);
            this.label18.TabIndex = 3;
            this.label18.Text = "Parcelas da Compra";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Dados do Pagamento";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvParcelas.Location = new System.Drawing.Point(10, 80);
            this.dgvParcelas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersWidth = 51;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.Size = new System.Drawing.Size(566, 241);
            this.dgvParcelas.TabIndex = 0;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.MinimumWidth = 6;
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            this.pco_cod.Width = 125;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor da parcela";
            this.pco_valor.MinimumWidth = 6;
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 125;
            // 
            // pco_datavecto
            // 
            this.pco_datavecto.HeaderText = "Data do vencimento";
            this.pco_datavecto.MinimumWidth = 6;
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.ReadOnly = true;
            this.pco_datavecto.Width = 125;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(544, 18);
            this.label17.TabIndex = 24;
            this.label17.Text = "___________________________________________________________________";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.BackColor = System.Drawing.Color.White;
            this.lbMsg.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(261, 238);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(272, 48);
            this.lbMsg.TabIndex = 51;
            this.lbMsg.Text = "Compra Ativa";
            this.lbMsg.Visible = false;
            // 
            // cbValidaQtde
            // 
            this.cbValidaQtde.AutoSize = true;
            this.cbValidaQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValidaQtde.Location = new System.Drawing.Point(436, 141);
            this.cbValidaQtde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbValidaQtde.Name = "cbValidaQtde";
            this.cbValidaQtde.Size = new System.Drawing.Size(332, 22);
            this.cbValidaQtde.TabIndex = 105;
            this.cbValidaQtde.Text = "Verificar a quantidade de produtos em estoque";
            this.cbValidaQtde.UseVisualStyleBackColor = true;
            this.cbValidaQtde.CheckedChanged += new System.EventHandler(this.cbValidaQtde_CheckedChanged);
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1372, 568);
            this.Controls.Add(this.pnFinalizaCompra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Venda";
            this.Text = "Área de Compras";
            this.Load += new System.EventHandler(this.frm_Venda_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pnFinalizaCompra, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxVendaAVista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button btLocCli;
        private System.Windows.Forms.TextBox txtCliCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn provTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDataini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTpagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataVenda;
        private System.Windows.Forms.TextBox txtVenCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btSalvarFinal;
        private System.Windows.Forms.Button btCancelarFinal;
        private System.Windows.Forms.Panel pnFinalizaCompra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.CheckBox cbValidaQtde;
    }
}

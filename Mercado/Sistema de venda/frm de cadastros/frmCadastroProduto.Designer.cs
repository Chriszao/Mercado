namespace Sistema_de_venda
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.btnAddUmed = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnAddFornecedor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtMarca);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.btnAddFornecedor);
            this.pnDados.Controls.Add(this.cbFornecedor);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.btnAddUmed);
            this.pnDados.Controls.Add(this.btnAddCat);
            this.pnDados.Controls.Add(this.btnRemoverFoto);
            this.pnDados.Controls.Add(this.btnCarregarFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUnidadeMedida);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQuantidade);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(15, 14);
            this.pnDados.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnDados.Size = new System.Drawing.Size(1016, 561);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(15, 593);
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnBotoes.Size = new System.Drawing.Size(1016, 182);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(883, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(707, 0);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(531, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Location = new System.Drawing.Point(355, 0);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizar.Location = new System.Drawing.Point(179, 0);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, -5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor de Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unidade de medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(154, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 30);
            this.txtNome.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(9, 167);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(457, 109);
            this.txtDescricao.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(9, 24);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 30);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(350, 317);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(116, 30);
            this.txtQuantidade.TabIndex = 15;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(10, 317);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(109, 30);
            this.txtValorPago.TabIndex = 13;
            this.txtValorPago.Text = "0.00";
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(149, 317);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(172, 30);
            this.txtValorVenda.TabIndex = 14;
            this.txtValorVenda.Text = "0.00";
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 383);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(269, 33);
            this.cbCategoria.TabIndex = 16;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(12, 453);
            this.cbUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(268, 33);
            this.cbUnidadeMedida.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(597, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 301);
            this.panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(409, 297);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(761, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Foto";
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarFoto.Location = new System.Drawing.Point(597, 346);
            this.btnCarregarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(199, 60);
            this.btnCarregarFoto.TabIndex = 20;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // btnRemoverFoto
            // 
            this.btnRemoverFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFoto.Location = new System.Drawing.Point(831, 346);
            this.btnRemoverFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(181, 60);
            this.btnRemoverFoto.TabIndex = 21;
            this.btnRemoverFoto.Text = "Remover Foto";
            this.btnRemoverFoto.UseVisualStyleBackColor = true;
            this.btnRemoverFoto.Click += new System.EventHandler(this.btnRemoverFoto_Click);
            // 
            // btnAddUmed
            // 
            this.btnAddUmed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUmed.Location = new System.Drawing.Point(289, 453);
            this.btnAddUmed.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUmed.Name = "btnAddUmed";
            this.btnAddUmed.Size = new System.Drawing.Size(33, 34);
            this.btnAddUmed.TabIndex = 19;
            this.btnAddUmed.Text = "+";
            this.btnAddUmed.UseVisualStyleBackColor = true;
            this.btnAddUmed.Click += new System.EventHandler(this.btnAddUmed_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Location = new System.Drawing.Point(289, 382);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(33, 34);
            this.btnAddCat.TabIndex = 17;
            this.btnAddCat.Text = "+";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 491);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(10, 520);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(269, 33);
            this.cbFornecedor.TabIndex = 23;
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFornecedor.Location = new System.Drawing.Point(289, 518);
            this.btnAddFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(33, 34);
            this.btnAddFornecedor.TabIndex = 24;
            this.btnAddFornecedor.Text = "+";
            this.btnAddFornecedor.UseVisualStyleBackColor = true;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Marca do produto";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(9, 100);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(457, 30);
            this.txtMarca.TabIndex = 11;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 786);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAddUmed;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnAddFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label11;
    }
}

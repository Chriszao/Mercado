namespace Sistema_de_venda.frm_de_CadastroFornecedor
{
    partial class frmCadastroFornecedor
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
            this.lbCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbRsocial = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.labCpfCnpj = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btnAddCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtCEP);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtIE);
            this.pnDados.Controls.Add(this.lbRgIe);
            this.pnDados.Controls.Add(this.txtCNPJ);
            this.pnDados.Controls.Add(this.labCpfCnpj);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lbRsocial);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.txtCod);
            this.pnDados.Controls.Add(this.lbCod);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(8, 12);
            this.lbCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(61, 20);
            this.lbCod.TabIndex = 2;
            this.lbCod.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(11, 36);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(139, 26);
            this.txtCod.TabIndex = 8;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(11, 66);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(166, 20);
            this.lbNome.TabIndex = 10;
            this.lbNome.Text = "Nome do Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(11, 90);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(995, 26);
            this.txtNome.TabIndex = 11;
            // 
            // lbRsocial
            // 
            this.lbRsocial.AutoSize = true;
            this.lbRsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRsocial.Location = new System.Drawing.Point(11, 121);
            this.lbRsocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRsocial.Name = "lbRsocial";
            this.lbRsocial.Size = new System.Drawing.Size(108, 20);
            this.lbRsocial.TabIndex = 12;
            this.lbRsocial.Text = "Razão Social";
            // 
            // txtRSocial
            // 
            this.txtRSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSocial.Location = new System.Drawing.Point(11, 144);
            this.txtRSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(995, 26);
            this.txtRSocial.TabIndex = 13;
            // 
            // labCpfCnpj
            // 
            this.labCpfCnpj.AutoSize = true;
            this.labCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCpfCnpj.Location = new System.Drawing.Point(11, 175);
            this.labCpfCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCpfCnpj.Name = "labCpfCnpj";
            this.labCpfCnpj.Size = new System.Drawing.Size(53, 20);
            this.labCpfCnpj.TabIndex = 14;
            this.labCpfCnpj.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(11, 198);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(476, 26);
            this.txtCNPJ.TabIndex = 15;
            // 
            // lbRgIe
            // 
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRgIe.Location = new System.Drawing.Point(531, 175);
            this.lbRgIe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(24, 20);
            this.lbRgIe.TabIndex = 16;
            this.lbRgIe.Text = "IE";
            // 
            // txtIE
            // 
            this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIE.Location = new System.Drawing.Point(529, 198);
            this.txtIE.Margin = new System.Windows.Forms.Padding(4);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(476, 26);
            this.txtIE.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(11, 252);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(139, 26);
            this.txtCEP.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(180, 252);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(307, 26);
            this.txtEstado.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(529, 252);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(476, 26);
            this.txtCidade.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(12, 306);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(816, 26);
            this.txtRua.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(863, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(867, 306);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(139, 26);
            this.txtNumero.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(840, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(11, 361);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(476, 26);
            this.txtBairro.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(524, 361);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(481, 26);
            this.txtEmail.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 402);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(11, 426);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(476, 26);
            this.txtTelefone.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(525, 402);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(524, 426);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(481, 26);
            this.txtCelular.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(267, 34);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(220, 28);
            this.cbCategoria.TabIndex = 9;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategoria.Location = new System.Drawing.Point(493, 34);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(32, 28);
            this.btnAddCategoria.TabIndex = 10;
            this.btnAddCategoria.Text = "+";
            this.btnAddCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedores ";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbRsocial;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label labCpfCnpj;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
    }
}

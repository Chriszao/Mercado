using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;
using Sistema_de_venda.frm_de_cadastros;

namespace Sistema_de_venda.frm_de_CadastroFornecedor
{
    public partial class frmCadastroFornecedor : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {

        public enum CampoT
        {
            Telefone = 1,
        }

        public void FormatarTelefone(CampoT Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case CampoT.Telefone:
                    txtTexto.MaxLength = 13;
                    if (txtTexto.Text.Length == 0)
                    {
                        txtTexto.Text = txtTexto.Text + "(";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ")";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 8)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        public int Cod { get; private set; }

        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtRSocial.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCNPJ.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtNumero.Clear();
            txtIE.Clear();
            txtRua.Clear();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCod.Text = modelo.ForCodigo.ToString();
                txtNome.Text = modelo.ForNome;
                txtRSocial.Text = modelo.ForRSocial;
                txtCNPJ.Text = modelo.ForCnpj;
                txtIE.Text = modelo.ForIe;
                txtCEP.Text = modelo.ForCep;
                txtEstado.Text = modelo.ForEstado;
                txtCidade.Text = modelo.ForCidade;
                txtRua.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForEndNumero;
                txtBairro.Text = modelo.ForBairro;
                txtEmail.Text = modelo.ForEmail;
                txtTelefone.Text = modelo.ForFone;
                txtCelular.Text = modelo.ForCel;
                cbCategoria.SelectedValue = modelo.CatCod;

                alteraBotoes(3);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alternar";
            this.alteraBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registo?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNome.Text;
                modelo.ForRSocial = txtRSocial.Text;
                modelo.ForCnpj = txtCNPJ.Text;
                modelo.ForIe = txtIE.Text;
                modelo.ForCep = txtCEP.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForEndereco = txtRua.Text;
                modelo.ForEndNumero = txtNumero.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForFone = txtTelefone.Text;
                modelo.ForCel = txtCelular.Text;
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);

                //obj para gravar os dados  no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!\nCódigo: " + modelo.ForCodigo.ToString());

                }
                else
                {
                    modelo.ForCodigo = Convert.ToInt32(txtCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!!!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//compara se é numero e habilita o backspace//8 valor da backspace na tabela ask
                e.Handled = true;//volta verdadeiro e não faz nada ou seja não é numero
            if (e.KeyChar != (char)8)
            {
                CampoT edit = CampoT.Telefone;
                edit = CampoT.Telefone;
                FormatarTelefone(edit, txtTelefone);
            }

        }
    }
} 
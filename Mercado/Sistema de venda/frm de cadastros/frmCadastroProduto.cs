using BLL;
using DAL;
using Modelo;
using Sistema_de_venda.frm_de_CadastroFornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_venda
{
    public partial class frmCadastroProduto : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public string foto = "";

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtMarca.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
            //Combo da Categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";

            //Combo da unidade de medida
            BLLUnidadeMedida ubll = new BLLUnidadeMedida(cx);
            cbUnidadeMedida.DataSource = ubll.Localizar("");
            cbUnidadeMedida.DisplayMember = "umed_nome";
            cbUnidadeMedida.ValueMember = "umed_cod";

            //Combo do fornecedor
            BLLFornecedor fbll = new BLLFornecedor(cx);
            cbFornecedor.DataSource = fbll.Localizar("");
            cbFornecedor.DisplayMember = "for_rsocial";
            cbFornecedor.ValueMember = "for_cod";
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToInt32(txtQuantidade.Text);
                modelo.UmedCod = Convert.ToInt32(cbUnidadeMedida.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ForCod = Convert.ToInt32(cbFornecedor.SelectedValue);
                modelo.ProMarca = txtMarca.Text;


                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!\nCódigo: " + modelo.ProCod.ToString());
                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro.\nOregistro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto fcproduto = new frmConsultaProduto();
            fcproduto.ShowDialog();
            if (fcproduto.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(fcproduto.codigo);

                //colocar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao;
                txtNome.Text = modelo.ProNome;
                txtQuantidade.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbUnidadeMedida.SelectedValue = modelo.UmedCod;
                cbFornecedor.SelectedValue = modelo.ForCod;
                txtMarca.Text = modelo.ProMarca;

                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            fcproduto.Dispose();

        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frm = new frmCadastroCategoria();
            frm.ShowDialog();
            frm.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
        }

        private void btnAddUmed_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeMedida frm = new frmCadastroUnidadeMedida();
            frm.ShowDialog();
            frm.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeMedida ubll = new BLLUnidadeMedida(cx);
            cbUnidadeMedida.DataSource = ubll.Localizar("");
            cbUnidadeMedida.DisplayMember = "umed_nome";
            cbUnidadeMedida.ValueMember = "umed_cod";
        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frm = new frmCadastroFornecedor();
            frm.ShowDialog();
            frm.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFornecedor fbll = new BLLFornecedor(cx);
            cbFornecedor.DataSource = fbll.Localizar("");
            cbFornecedor.DisplayMember = "for_rsocial";
            cbFornecedor.ValueMember = "for_cod";
        }
    }
}

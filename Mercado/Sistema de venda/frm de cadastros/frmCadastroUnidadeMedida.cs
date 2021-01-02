using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_venda
{
    public partial class frmCadastroUnidadeMedida : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {
        public frmCadastroUnidadeMedida()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtUnidadeMedida.Clear();
            txtCod.Clear();
        }
        private void frmCadastroUnidadeMedida_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
                modelo.UmedNome = txtUnidadeMedida.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);

                if (this.operacao == "inserir")
                {
                    bll.incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!\nCódigo: " + modelo.UmedCod.ToString());
                }
                else
                {
                    modelo.UmedCod = Convert.ToInt32(txtCod.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
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
                DialogResult d = MessageBox.Show("Deseja excluir o registo?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro.\nO registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(f.codigo);
                txtCod.Text = modelo.UmedCod.ToString();
                txtUnidadeMedida.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void txtUnidadeMedida_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int retorno = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                retorno = bll.VerificaUnidadeMedida(txtUnidadeMedida.Text);
                if(retorno > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com esse valor. Deseja alterar o registo?", "Aviso", MessageBoxButtons.YesNo);
                    if(d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";

                        ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(retorno);
                        txtCod.Text = modelo.UmedCod.ToString();
                        txtUnidadeMedida.Text = modelo.UmedNome;
                    }
                }
            }
        }
    }
}

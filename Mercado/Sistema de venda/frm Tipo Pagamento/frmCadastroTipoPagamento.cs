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
    public partial class frmCadastroTipoPagamento : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {
        public frmCadastroTipoPagamento()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCod.Clear();
            txtNome.Clear();
        }

        private void frmCadastroTipoPagamento_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txtNome.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);

                if (operacao == "inserir")
                {
                    bll.incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!\nCódigo: " + modelo.TpaCod.ToString());
                }
                else
                {
                    modelo.TpaCod = Convert.ToInt32(txtCod.Text);
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
                    BLLTipoPagamento bll = new BLLTipoPagamento(cx);
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
            frmConsultaTipoPagamento fctipopagamento = new frmConsultaTipoPagamento();
            fctipopagamento.ShowDialog();
            if (fctipopagamento.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(fctipopagamento.codigo);
                txtCod.Text = modelo.TpaCod.ToString();
                txtNome.Text = modelo.TpaNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            fctipopagamento.Dispose();
        }
    }
}

using BLL;
using Ferramentas;
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
    public partial class frmCadastroCliente : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
        }

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

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                    /*case Campo.CEP:
                        txtTexto.MaxLength = 9;
                        if (txtTexto.Text.Length == 5)
                        {
                            txtTexto.Text = txtTexto.Text + "-";
                            txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                        }
                        break;*/
            }
        }

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtNumero.Clear();
            txtRG.Clear();
            txtRSocial.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            rbFisica.Checked = true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRSocial = txtRSocial.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliCel = txtCelular.Text;
                modelo.CliCpfCnpj = txtCPF.Text;
                modelo.CliRgIe = txtRG.Text;
                modelo.CliFone = txtTelefone.Text;
                modelo.CliCep = txtCEP.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEndereco = txtRua.Text;
                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "Física"; //fisica
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "Juridica"; //Juridica
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso!!!\nCódigo: " + modelo.CliCod.ToString());
                }
                else
                {
                    modelo.CliCod = Convert.ToInt32(txtCod.Text);
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
                    BLLCliente bll = new BLLCliente(cx);
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
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCod.Text = modelo.CliCod.ToString();
                if (modelo.CliTipo == "Física")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtNome.Text = modelo.CliNome;
                txtRSocial.Text = modelo.CliRSocial;
                txtCPF.Text = modelo.CliCpfCnpj;
                txtRG.Text = modelo.CliRgIe;
                txtCEP.Text = modelo.CliCep;
                txtEstado.Text = modelo.CliEstado;
                txtCidade.Text = modelo.CliCidade;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliEndNumero;
                txtBairro.Text = modelo.CliBairro;
                txtCelular.Text = modelo.CliCel;
                txtTelefone.Text = modelo.CliFone;
                txtEmail.Text = modelo.CliEmail;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
            {
                lbRsocial.Visible = false;
                txtRSocial.Visible = false;
                lbCpfCnpj.Text = "CPF";
                lbRgIe.Text = "RG";
            }
            else
            {
                lbRsocial.Visible = true;
                txtRSocial.Visible = true;
                lbCpfCnpj.Text = "CNPJ";
                lbRgIe.Text = "IE";
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtRua.Text = BuscaEndereco.endereco;
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (rbFisica.Checked == true)
            {
                //Validação para CPF
                if (Validacao.IsCpf(txtCPF.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else
            {
                //Validação CNPJ
                //Validação para CPF
                if (Validacao.IsCnpj(txtCPF.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, txtCPF);
            }
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

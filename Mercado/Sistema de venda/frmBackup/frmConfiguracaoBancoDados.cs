using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_venda
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBD.Text);
                arquivo.WriteLine(txtUser.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBD.Text = arquivo.ReadLine();
                txtUser.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBD.Text;
                DadosDaConexao.usuario = txtUser.Text;
                DadosDaConexao.senha = txtSenha.Text;
                //testar conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso!");
            }
            catch (SqlException )
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados \n" + "Verifique os dados informados");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}

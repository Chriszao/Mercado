using Sistema_de_venda.frm_de_CadastroFornecedor;
using Sistema_de_venda.frm_de_cadastros;
using DAL;
using Sistema_de_venda.frm_de_categorias;
using Sistema_de_venda.frm_Sobre;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frm = new frmCadastroCategoria();
            //Método ShowDialog chama o formulário e não permite que o usuário interaja com outros forms enquanto não fechar o mesmo que foi chamado. 
            frm.ShowDialog();
            //Quando o usuário fechar o forms, elimina o objeto "frm".
            frm.Dispose();
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultaCategoria frm = new frm_ConsultaCategoria();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeMedida frm = new frmCadastroUnidadeMedida();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida frm = new frmConsultaUnidadeMedida();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frm = new frmCadastroCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frm = new frmConsultaProduto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frm = new frmConsultaCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frm = new frmConsultaFornecedor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento frm = new frmCadastroTipoPagamento();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento frm = new frmConsultaTipoPagamento();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frm = new frmCadastroFornecedor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados frm = new frmConfiguracaoBancoDados();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        { 
            try
            {
    
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch (SqlException )
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados \n" + "Acesse as configurações do banco de dados e informe os parâmetros de conexão.");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDados frm = new frmBackupBancoDados();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Venda frm = new frm_Venda();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

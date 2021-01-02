using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferramentas;

namespace Sistema_de_venda
{
    public partial class frmBackupBancoDados : Form
    {
        public frmBackupBancoDados()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files |*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User ID=" + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files |*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" + DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}

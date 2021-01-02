using BLL;
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

namespace Sistema_de_venda
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarCategoria(txtValor.Text);
            }
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código do Produto";
            dgvDados.Columns[1].HeaderText = "Nome do Produto";
            dgvDados.Columns[2].HeaderText = "Marca";
            dgvDados.Columns[3].HeaderText = "Descrição";
            dgvDados.Columns[6].HeaderText = "Valor de venda";
            dgvDados.Columns[6].DefaultCellStyle.Format = "c";
            dgvDados.Columns[7].HeaderText = "Quantidade em estoque";
            dgvDados.Columns[11].HeaderText = "Unidade de Medida";
            dgvDados.Columns[12].HeaderText = "Categoria";
            dgvDados.Columns[13].HeaderText = "Fornecedor";

            //Oculta colunas
            dgvDados.Columns["for_cod"].Visible = false;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
            dgvDados.Columns["pro_foto"].Visible = false;
            dgvDados.Columns["pro_valorpago"].Visible = false;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
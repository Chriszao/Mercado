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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.DataSet1.produto);

            this.reportViewer1.RefreshReport();
        }
    }
}

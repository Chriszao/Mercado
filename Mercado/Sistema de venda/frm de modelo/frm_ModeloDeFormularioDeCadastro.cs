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
    public partial class frm_ModeloDeFormularioDeCadastro : Form
    {
        public String operacao;

        public frm_ModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            /*
            * op = operações que serão feitas com os botoões
            * 1 = Preparar os botões parab inserir e localizar
            * 2 = preparar os botões para inserir/alterar um registro
            * 3 = preparar a tela para excluir ou alterar              
            */

            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if(op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if(op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if(op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void frm_ModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frm_ModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}

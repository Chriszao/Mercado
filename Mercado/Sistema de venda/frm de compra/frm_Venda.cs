﻿using BLL;
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
    public partial class frm_Venda : Sistema_de_venda.frm_ModeloDeFormularioDeCadastro
    {
        public double totalVenda = 0;
        public frm_Venda()
        {
            InitializeComponent();
        }

        private void btLocCli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCodigo.Text = f.codigo.ToString();
                txtCliCodigo_Leave(sender, e);
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();

                txtProCod_Leave(sender, e);

            }
        }

        private void cbxVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVendaAVista.Checked == true)
            {
                cbNParcela.SelectedIndex = 0;
                cbNParcela.Enabled = false;
            }
            else
            {
                cbNParcela.Enabled = true;
            }
        }

        private void txtCliCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbValidaQtde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbNParcela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtVenCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtDataini_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValor);
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",","").Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch
            {

            }
        }

        private void lCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            alteraBotoes(2);
            cbNParcela.SelectedIndex = 0;
            cbxVendaAVista.Checked = false;
        }

        private void txtCliCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCodigo.Text));
                if (modelo.CliCod <= 0)
                {
                    txtCliCodigo.Clear();
                    lCliente.Text = "Informe o código do cliente ou clique em localizar";
                }
                else lCliente.Text = modelo.CliNome;
            }
            catch
            {
                txtCliCodigo.Clear();
                lCliente.Text = "Informe o código do cliente ou clique em localizar";
            }
        }


        private void txtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lProduto.Text = modelo.ProNome;
                txtQtde.Text = " 1";
                double valorVenda = modelo.ProValorVenda * 100;
                txtValor.Text = valorVenda.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lProduto.Text = "Informe o código do produto ou clique em localizar";
            }
        }
        private Double VerificaQtdeProdutos(int ProCod)
        {
            Double QtdEmEstoque = 0;
            try
            {
                //O que tem no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProCod);
                QtdEmEstoque = modelo.ProQtde;
                //verifica produtos na grid
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value) == ProCod)
                    {
                        QtdEmEstoque = QtdEmEstoque - Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                    }
                }
            }
            catch { }
            return QtdEmEstoque;
        }
        private void btAddProd_Click(object sender, EventArgs e)
        {
            Double Qtde = 0;
            try
            {
                if ((txtProCod.Text != "") && (txtQtde.Text != "") && (txtValor.Text != ""))
                {
                    if (cbValidaQtde.Checked == true)
                    {
                        Qtde = VerificaQtdeProdutos(Convert.ToInt32(txtProCod.Text));
                        if (Convert.ToDouble(txtQtde.Text) > Qtde)
                        {
                            MessageBox.Show("Quantidade de produtos indisponível.\n possuimos " + Qtde +
                                " unidades em estoque");
                            return;
                        }
                    }
                    Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);//metodo para calcular o total do produto
                    this.totalVenda = this.totalVenda + TotalLocal;//metodo para somar o total da compra
                    String[] i = new String[] { txtProCod.Text, lProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };//criado vetor de string
                    this.dgvItens.Rows.Add(i);//adicionando o string dentro da datagrid

                    txtProCod.Clear();//limpar o campo
                    lProduto.Text = "Informe o código do produto ou clique em localizar";
                    txtQtde.Clear();//limpar o campo
                    txtValor.Clear();//limpar o campo

                    txtTotalVenda.Text = this.totalVenda.ToString();//atualizar o total da compra

                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referentes ao valor e quantidade do produto");
            }
        }

        private void frm_Venda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";
            cbNParcela.SelectedIndex = 0;
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //validar os dados da venda
            try
            {
                if (Convert.ToInt32(txtCliCodigo.Text) <= 0)
                {
                    MessageBox.Show("Informe um código válido para o cliente");
                    return;
                }
                if (totalVenda <= 0)
                {
                    MessageBox.Show("Insira itens em sua compra para continuar...");
                    return;
                }
                dgvParcelas.Rows.Clear();
                int parcelas = Convert.ToInt32(cbNParcela.Text);
                //Double totallocal = Convert.ToDouble(txtTotalCompra.Text);
                Double totallocal = this.totalVenda;
                double valor = totallocal / parcelas; //valor = this.total/parcelas
                DateTime dt = new DateTime();
                dt = dtDataini.Value;
                lbTotal.Text = this.totalVenda.ToString();
                for (int i = 1; i <= parcelas; i++)
                {
                    String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                    this.dgvParcelas.Rows.Add(k);
                    if (dt.Month != 12)
                    {
                        dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                    }
                    else
                    {
                        dt = new DateTime(dt.Year + 1, 1, dt.Day);
                    }
                }
                pnFinalizaCompra.Visible = true;
            }
            catch
            {
                MessageBox.Show("Verifique os campos da tela de compras");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        public void LimpaTela()
        {
            txtVenCodigo.Clear();
            txtCliCodigo.Clear(); txtProCod.Clear();
            lProduto.Text = "Informe o código do produto ou clique em localizar";
            txtQtde.Clear(); txtValor.Clear(); txtTotalVenda.Clear();
            dgvItens.Rows.Clear(); //limpar as linhas da dataGrid
            cbNParcela.SelectedIndex = 0;
            cbTpagto.SelectedIndex = 0;
            dgvItens.Rows.Clear();
            txtTotalVenda.Text = "0,00";
            lbMsg.Visible = false;
        }


        private void btCancelarFinal_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }
        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VenData = dtDataVenda.Value;
                modeloVenda.VenNParcelas = Convert.ToInt32(cbNParcela.Text);
                modeloVenda.VenStatus = "ativa";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.CliCod = Convert.ToInt32(txtCliCodigo.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);
                if (cbxVendaAVista.Checked == true)
                    modeloVenda.VenAvista = 1;
                else modeloVenda.VenAvista = 0;

                //obj para gravar os dados no banco
                BLLVenda bllVenda = new BLLVenda(cx);

                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

                ModeloParcelasVenda mparcelas = new ModeloParcelasVenda();
                BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra ok
                    bllVenda.Incluir(modeloVenda);

                    //cadastrar os itens da venda

                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                        //alterar a quantidade de produtos vendidos na tabela de produtos
                        //Trigger
                    }

                    // inserir os itens na tabela parcelas venda
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    MessageBox.Show("Compra efetuada: Código " + modeloVenda.VenCod.ToString());

                }

                //this.LimpaTela();
                pnFinalizaCompra.Visible = false;
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();
                this.LimpaTela();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void pnFinalizaCompra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);

                txtVenCodigo.Text = modelo.VenCod.ToString();
                dtDataVenda.Value = modelo.VenData;
                txtCliCodigo.Text = modelo.CliCod.ToString();
                txtCliCodigo_Leave(sender, e); //para escrever o nome do cliente na tela
                cbTpagto.SelectedValue = modelo.TpaCod;
                cbNParcela.Text = modelo.VenNParcelas.ToString();
                if (modelo.VenAvista == 1) cbxVendaAVista.Checked = true;
                else cbxVendaAVista.Checked = false;
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                this.totalVenda = modelo.VenTotal; //armazenar o valor total da compra
                //itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                DataTable tabela = bllItens.Localizar(modelo.VenCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);

                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }
                alteraBotoes(3);
                //lbMsg.Visible = false;
                if (modelo.VenStatus != "ativa")
                {
                    lbMsg.Text = "Compra Cancelada";
                    lbMsg.Visible = true;
                    btnExcluir.Enabled = false;
                }
            }
            else
            {
                this.alteraBotoes(1);
            }
            f.Dispose();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja cancelar o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                if (bll.CancelarVenda(Convert.ToInt32(txtVenCodigo.Text)) == true)
                {
                    MessageBox.Show("Compra Cancelada");
                }
                else
                {
                    MessageBox.Show("Não foi possível cancelar a compra. \nContate o seu desenvolvedor.");
                }
            }

        }
     }
}







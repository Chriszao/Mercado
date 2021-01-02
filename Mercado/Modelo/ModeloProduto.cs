using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            //null
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ProMarca = "";
        }

        public ModeloProduto(int pro_cod, String pro_nome, String pro_descricao, String pro_foto, Double pro_valorpago, Double pro_valorvenda, int pro_qtde, int umed_cod, int cat_cod, string pro_marca)
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.CarregaImagem(pro_foto);
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ProMarca = pro_marca;
         }

        public ModeloProduto(int pro_cod, String pro_nome, String pro_descricao, byte[] pro_foto, Double pro_valorpago, Double pro_valorvenda, int pro_qtde, int umed_cod, int cat_cod, string pro_marca)
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.ProFoto = pro_foto;
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ProMarca = pro_marca;
        }


        private int pro_cod;
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }

        private string pro_nome;
        public string ProNome
        {
            get { return this.pro_nome; }
            set { this.pro_nome = value; }
        }

        private string pro_descricao;
        public string ProDescricao
        {
            get { return this.pro_descricao; }
            set { this.pro_descricao = value; }
        }

        private byte[] pro_foto;
        public byte[] ProFoto
        {
            get { return this.pro_foto; }
            set { this.pro_foto = value; }
        }

        public void CarregaImagem(string imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //Fornece propriedades e métodos de instancia para criar, copiar, excluir, mover, e abrir arquivos. Auxilia na criação de objetos FileStream.
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //Aloca memória para o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Le um bloco de bytes do fluxo e grava os dados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private Double pro_valorpago;
        public Double ProValorPago
        {
            get { return this.pro_valorpago; }
            set { this.pro_valorpago = value; }
        }

        private Double pro_valorvenda;
        public Double ProValorVenda
        {
            get { return this.pro_valorvenda; }
            set { this.pro_valorvenda = value; }
        }

        private int pro_qtde;
        public int ProQtde
        {
            get { return this.pro_qtde; }
            set { this.pro_qtde = value; }
        }
        private int umed_cod;
        public int UmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        private int for_cod;
        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private string pro_marca;
        public string ProMarca
        {
            get { return this.pro_marca; }
            set { this.pro_marca = value; }
        }
    }
}

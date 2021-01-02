using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLLVenda
    {
        private DALConexao conexao;

        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            if(modelo.VenNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O cliente deve ser informado");
            }

            if(modelo.VenTotal <= 0)
            {
                throw new Exception("o valor total da venda deve ser informado");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O cliente deve ser informado");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("o valor total da venda deve ser informado");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O número deve ser maior do que zero");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public Boolean CancelarVenda(int codigo)
        {
            if(codigo <= 0)
            {
                throw new Exception("O número deve ser maior do que zero.");
            }
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CancelarVenda(codigo);
        }
        public DataTable Localizar(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(codigo);
        }
        public DataTable Localizar(String nome)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(nome);
        }
        public DataTable Localizar()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar();
        }
        public DataTable LocalizarPorParcelasEmAberto()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarPorParcelasEmAberto();
        }
        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            if (Codigo <= 0)
            {
                throw new Exception("O número deve ser maior do que zero");
            }
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(Codigo);
        }
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O número deve ser maior do que zero");
            }
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
    }
}

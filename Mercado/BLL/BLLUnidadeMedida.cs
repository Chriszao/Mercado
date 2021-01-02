using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLUnidadeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void incluir(ModeloUnidadeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.incluir(modelo);
        }
        public void Alterar(ModeloUnidadeMedida modelo)
        {
            if(modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }
            
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.Localizar(valor);
        }
        public int VerificaUnidadeMedida(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.VerificaUnidadeMedida(valor);
        }
        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.CarregaModeloUnidadeMedida(codigo);
        }
    }
}

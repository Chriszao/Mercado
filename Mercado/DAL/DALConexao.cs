using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        //Propriedade String armazena a string de conexão
        //Propriedade SqlConnection é a conexão
        private String _stringConexao;
        private SqlConnection _conexao;
        private SqlTransaction _transaction;

        //Construtor que recebe a string de conexão
        public DALConexao(string dadosConexao)
        {
            this._conexao = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        //Propriedade que pegara o dado da propriedade privada
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }

        public SqlTransaction ObjetoTransacao
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }

        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }

        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }

        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }
    }
}

using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUnidadeMedida
    {
        private DALConexao conexao;

        public DALUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void incluir(ModeloUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into undmedida(umed_nome) values (@nome); select @@IDENTITY;";
                cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
                conexao.Conectar();
                modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update undmedida set umed_nome = @nome where umed_cod = @cod;";
                cmd.Parameters.AddWithValue("@nome", modelo.UmedNome);
                cmd.Parameters.AddWithValue("@cod", modelo.UmedCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from undmedida where umed_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from undmedida where umed_nome like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //Se retornar 0 = não existe valor no banco. Se retornar um numero maior que 0 existe um valor no banco.
        public int VerificaUnidadeMedida(String valor)
        {
            int retorno = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_nome = @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                retorno = Convert.ToInt32(registro["umed_cod"]);
            }
            conexao.Desconectar();
            return retorno;
        }
        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from undmedida where umed_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.UmedNome = Convert.ToString(registro["umed_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}

﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategoria
    {
        //Implementar os métodos que serão utilizados para acessar o banco.
        //Operações que o método realiza: INSERIR, ALTERAR, LOCALIZAR E EXCLUIR.

        private DALConexao conexao;

        //construtor da classe DALConexao
        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria(cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            conexao.Conectar();
            //cmd.ExecuteScalar() Usa-se quando quer obter pouca informação do Banco.
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            conexao.Conectar();
            //cmd.ExecuteNonQuery() Usa-se quando não quer obter informação alguma do banco.
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria where cat_nome like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            //cmd.ExecuteReader() quando quer-se obter muitas informações do Banco.
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
            }
            conexao.Desconectar();
            return modelo;

        }
    }
}

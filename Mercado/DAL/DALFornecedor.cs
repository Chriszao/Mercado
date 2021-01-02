using System;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace DAL
{
    public class DALFornecedor
    {
        private DALConexao conexao;

        //consultor da classe DALConexao
        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Fornecedor(For_nome, For_cnpj, For_ie, For_rsocial, For_cep, For_endereco, For_bairro, For_fone, For_cel, For_email, For_endnumero, For_cidade, For_estado, cat_cod) values (@For_nome, @For_cnpj, @For_ie, @For_rsocial, @For_cep, @For_endereco, @For_bairro, @For_fone, @For_cel, @For_email, @For_endnumero, @For_cidade, @For_estado, @cat_cod); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@For_nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@For_cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@For_ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@For_rsocial", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@For_cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@For_endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@For_bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@For_fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@For_cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@For_email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@For_endnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@For_cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@For_estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);

            conexao.Conectar();
            modelo.ForCodigo = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update Fornecedor set For_nome = @For_nome, For_cnpj = @For_cnpj, For_ie = @For_ie, For_rsocial = @For_rsocial, For_cep = @For_cep, For_endereco = @For_endereco, For_bairro = @For_bairro, For_fone = @For_fone, For_cel = @For_cel, For_email = @For_email, For_endnumero = @For_endnumero, For_cidade = @For_cidade, For_estado = @For_estado, cat_cod = @cat_cod where For_cod = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", modelo.ForCodigo);
            cmd.Parameters.AddWithValue("@For_nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@For_cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@For_ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@For_rsocial", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@For_cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@For_endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@For_bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@For_fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@For_cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@For_email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@For_endnumero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@For_cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@For_estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@cat_cod", modelo.CatCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Fornecedor where For_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Fornecedor where For_nome like'%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCategoria(int categoria)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select f.for_cod, f.for_nome, f.cat_cod, c.cat_nome from Fornecedor f inner join categoria c on f.cat_cod = c.cat_cod where For_nome like'%" + categoria + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where For_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCodigo = Convert.ToInt32(registro["For_cod"]);
                modelo.ForNome = Convert.ToString(registro["For_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["For_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["For_ie"]);
                modelo.ForRSocial = Convert.ToString(registro["For_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["For_cep"]); ;
                modelo.ForBairro = Convert.ToString(registro["For_bairro"]);
                modelo.ForFone = Convert.ToString(registro["For_fone"]);
                modelo.ForCel = Convert.ToString(registro["For_cel"]);
                modelo.ForEmail = Convert.ToString(registro["For_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["For_endnumero"]);
                modelo.ForEndereco = Convert.ToString(registro["For_endereco"]);
                modelo.ForCidade = Convert.ToString(registro["For_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["For_estado"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }



        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Fornecedor where For_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCodigo = Convert.ToInt32(registro["For_cod"]);
                modelo.ForNome = Convert.ToString(registro["For_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["For_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["For_ie"]);
                modelo.ForRSocial = Convert.ToString(registro["For_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["For_cep"]); ;
                modelo.ForBairro = Convert.ToString(registro["For_bairro"]);
                modelo.ForFone = Convert.ToString(registro["For_fone"]);
                modelo.ForCel = Convert.ToString(registro["For_cel"]);
                modelo.ForEmail = Convert.ToString(registro["For_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["For_endnumero"]);
                modelo.ForEndereco = Convert.ToString(registro["For_endereco"]);
                modelo.ForCidade = Convert.ToString(registro["For_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["For_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
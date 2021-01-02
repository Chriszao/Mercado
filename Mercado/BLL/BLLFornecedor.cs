using System;
using System.Data;
using DAL;
using Modelo;


public class BLLFornecedor
{
    private DALConexao conexao;

    public BLLFornecedor(DALConexao cx)
    {
        this.conexao = cx;
    }

    public void Incluir(ModeloFornecedor modelo)
    {
        if (modelo.ForNome.Trim().Length == 0)
        {
            throw new Exception("O nome do Fornecedor é obrigatório.");
        }
        if (modelo.ForCnpj.Trim().Length == 0)
        {
            throw new Exception("O CNPJ do Fornecedor é obrigatório.");
        }

        //Verificar CNPJ

        if (modelo.ForIe.Trim().Length == 0)
        {
            throw new Exception("O IE do Fornecedor é obrigatório.");
        }
        if (modelo.ForFone.Trim().Length == 0)
        {
            throw new Exception("O telefone do Fornecedor é obrigatório.");
        }


        DALFornecedor DALobj = new DALFornecedor(conexao);
        DALobj.Incluir(modelo);
    }

    public void Alterar(ModeloFornecedor modelo)
    {
        if (modelo.ForNome.Trim().Length == 0)
        {
            throw new Exception("O nome do Fornecedor é obrigatório.");
        }
        if (modelo.ForCnpj.Trim().Length == 0)
        {
            throw new Exception("O CNPJ do Fornecedor é obrigatório.");
        }

        //Verificar CNPJ

        if (modelo.ForIe.Trim().Length == 0)
        {
            throw new Exception("O IE do Fornecedor é obrigatório.");
        }
        if (modelo.ForFone.Trim().Length == 0)
        {
            throw new Exception("O telefone do Fornecedor é obrigatório.");
        }

        DALFornecedor DALobj = new DALFornecedor(conexao);
        DALobj.Alterar(modelo);
    }

    public void Excluir(int codigo)
    {
        DALFornecedor DALobj = new DALFornecedor(conexao);
        DALobj.Excluir(codigo);
    }

    public DataTable Localizar(string valor)
    {
        DALFornecedor DALobj = new DALFornecedor(conexao);
        return DALobj.Localizar(valor);
    }

    public DataTable LocalizarPorCategoria(int categoria)
    {
        DALFornecedor DALobj = new DALFornecedor(conexao);
        return DALobj.LocalizarPorCategoria(categoria);
    }

    public ModeloFornecedor CarregaModeloFornecedor(int codigo)
    {
        DALFornecedor DALobj = new DALFornecedor(conexao);
        return DALobj.CarregaModeloFornecedor(codigo);
    }

    public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
    {
        DALFornecedor DALobj = new DALFornecedor(conexao);
        return DALobj.CarregaModeloFornecedor(cnpj);
    }

    
}

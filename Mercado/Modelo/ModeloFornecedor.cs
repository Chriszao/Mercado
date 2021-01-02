
using System;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.ForCodigo = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRSocial = "";
            this.ForCep = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndNumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
            this.CatCod = 0;
        }

        public ModeloFornecedor(int For_cod, string For_nome, string For_cnpj, string For_ie, string For_rsocial, string For_cep, string For_bairro, string For_fone, string For_cel, string For_email, string For_endnumero, string For_cidade, string For_estado, int cat_cod)
        {
            this.ForCodigo = For_cod;
            this.ForNome = For_nome;
            this.ForCnpj = For_cnpj;
            this.ForIe = For_ie;
            this.ForRSocial = For_rsocial;
            this.ForCep = For_cep;
            this.ForBairro = For_bairro;
            this.ForFone = For_fone;
            this.ForCel = For_cel;
            this.ForEmail = For_email;
            this.ForEndNumero = For_endnumero;
            this.ForCidade = For_cidade;
            this.ForEstado = For_estado;
            this.CatCod = cat_cod;
        }

        private int For_cod;
        public int ForCodigo
        {
            get { return this.For_cod; }
            set { this.For_cod = value; }
        }

        private string For_nome;
        public string ForNome
        {
            get { return this.For_nome; }
            set { this.For_nome = value; }
        }

        private string For_cnpj;
        public string ForCnpj
        {
            get { return this.For_cnpj; }
            set { this.For_cnpj = value; }
        }

        private string For_ie;
        public string ForIe
        {
            get { return this.For_ie; }
            set { this.For_ie = value; }
        }

        private string For_rsocial;
        public string ForRSocial
        {
            get { return this.For_rsocial; }
            set { this.For_rsocial = value; }
        }

        private string For_cep;
        public string ForCep
        {
            get { return this.For_cep; }
            set { this.For_cep = value; }
        }

        private string For_endereco;
        public string ForEndereco
        {
            get { return this.For_endereco; }
            set { this.For_endereco = value; }
        }

        private string For_bairro;
        public string ForBairro
        {
            get { return this.For_bairro; }
            set { this.For_bairro = value; }
        }

        private string For_fone;
        public string ForFone
        {
            get { return this.For_fone; }
            set { this.For_fone = value; }
        }

        private string For_cel;
        public string ForCel
        {
            get { return this.For_cel; }
            set { this.For_cel = value; }
        }

        private string For_email;
        public string ForEmail
        {
            get { return this.For_email; }
            set { this.For_email = value; }
        }

        private string For_endnumero;
        public string ForEndNumero
        {
            get { return this.For_endnumero; }
            set { this.For_endnumero = value; }
        }

        private string For_cidade;
        public string ForCidade
        {
            get { return this.For_cidade; }
            set { this.For_cidade = value; }
        }

        private string For_estado;
        public string ForEstado
        {
            get { return this.For_estado; }
            set { this.For_estado = value; }
        }

        private int cat_cod;
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
    }
}

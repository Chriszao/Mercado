using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        //clitipo 0 -> pessoa fisisca; 1 -> pessoa juridica; 
        //Construtores
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRSocial = "";
            this.CliTipo = "Física";
            this.CliCep = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
            this.CliEndereco = "";
        }

        public ModeloCliente(int cli_cod, string cli_nome, string cli_cpfcnpj, string cli_rgie, string cli_rsocial, string cli_tipo, string cli_cep, string cli_bairro, string cli_fone, string cli_cel, string cli_email, string cli_endnumero, string cli_cidade, string cli_estado, string cli_endereco)
        {
            this.CliCod = cli_cod;
            this.CliNome = cli_nome;
            this.CliCpfCnpj = cli_cpfcnpj;
            this.CliRgIe = cli_rgie;
            this.CliRSocial = cli_rsocial;
            this.CliTipo = cli_tipo;
            this.CliCep = cli_cep;
            this.CliBairro = cli_bairro;
            this.CliFone = cli_fone;
            this.CliCel = cli_cel;
            this.CliEmail = cli_email;
            this.CliEndNumero = cli_endnumero;
            this.CliCidade = cli_cidade;
            this.CliEstado = cli_estado;
            this.CliEndereco = cli_endereco;
        }

        //Propriedades da classe
        private int cli_cod;
        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private string cli_nome;
        public string CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private string cli_cpfcnpj;
        public string CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private string cli_rgie;
        public string CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private string cli_rsocial;
        public string CliRSocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }

        private string cli_tipo;
        public string CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }
        private string cli_cep;
        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private string cli_endereco;
        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private string cli_bairro;
        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private string cli_fone;
        public string CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }

        private string cli_cel;
        public string CliCel
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }

        private string cli_email;
        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private string cli_endnumero;
        public string CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }

        private string cli_cidade;
        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private string cli_estado;
        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }

        public object CliCPFCNPJ { get; set; }
        public string Clirg { get; set; }
        public string CliCEP { get; set; }
        public string CliCelular { get; set; }
        public string CliCPF { get; set; }
    }
}

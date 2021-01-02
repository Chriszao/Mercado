using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"CHRISZÃO\SQLEXPRESS";
        public static String banco = "SistemaDeVendas";
        public static String usuario = "sa";
        public static String senha = "123456";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}

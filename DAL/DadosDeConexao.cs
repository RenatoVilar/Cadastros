using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDeConexao
    {
        public static String strConexao
        {
            get
            {
                return "Data Source=HOME;Initial Catalog=Cadastros;User ID=sa;Password=icm402";
            }
        }
    }
}

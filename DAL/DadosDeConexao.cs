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
                //return "Data Source=HOME;Initial Catalog=Cadastros;User ID=sa;Password=icm402";
                return @"Data Source=SVR_ALEGRA\ALTERDATAERP;Initial Catalog=Cadastros;Persist Security Info=True;User ID=SUPERVISOR;Password=#abc123#";
            }
        }
    }
}

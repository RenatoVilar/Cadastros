using System;

namespace DAL
{
    public class DadosDeConexao
    {
        public static String strConexao
        {
            get
            {
                return @"Data Source = C:\Users\Renato.ALEGRANAUTICA\Documents\Visual Studio 2015\Projects\Cadastros\DAL\CadastrosDB.sdf; Password = icm402";
                //return "Data Source=HOME;Initial Catalog=Cadastros;User ID=sa;Password=icm402";
                //return @"Data Source=SVR_ALEGRA\ALTERDATAERP;Initial Catalog=Cadastros;Persist Security Info=True;User ID=SUPERVISOR;Password=#abc123#";
            }
        }
    }
}

using System;
using System.Configuration;

namespace DAL
{
    public class DadosDeConexao
    {
        public static String strConexao
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CadastrosDBConexao"].ConnectionString;
                //return @"Data Source = C:\Users\Renato.ALEGRANAUTICA\Documents\Visual Studio 2015\Projects\Cadastros\DAL\CadastrosDB.sdf; Password = icm402";
        
            }
        }
    }
}

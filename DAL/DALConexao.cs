using System;
using System.Data.SqlServerCe;

namespace DAL
{
    public class DALConexao
    {
        public String StrConexao { get; set; }
        public SqlCeConnection SqlConexao { get; set; }
        

        public DALConexao(String dadosConexao)
        {
            this.SqlConexao = new SqlCeConnection();
            this.StrConexao = dadosConexao;
            this.SqlConexao.ConnectionString = StrConexao;
        }

        public void Conectar()
        {
            try
            {
                this.SqlConexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }

        public void Desconectar()
        {
            this.SqlConexao.Close();
        }


    }
}

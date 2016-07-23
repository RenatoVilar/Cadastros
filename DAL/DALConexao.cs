using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConexao
    {
        public String StrConexao { get; set; }
        public SqlConnection SqlConexao { get; set; }

        public DALConexao(String dadosConexao)
        {
            this.SqlConexao = new SqlConnection();
            this.StrConexao = dadosConexao;
            this.SqlConexao.ConnectionString = StrConexao;
        }

        public void Conectar()
        {
            this.SqlConexao.Open();
        }

        public void Desconectar()
        {
            this.SqlConexao.Close();
        }


    }
}

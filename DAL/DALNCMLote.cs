using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALNCMLote
    {
        private DALConexao dalConexao;

        

        public DALNCMLote(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            //sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, SitST, SitAuto, SitSemSimilar, Cest FROM NCMs WHERE CodNCM LIKE '" + valor + "%'";

            //1   MATÉRIA PRIMA   1
            //2   OUTROS INSUMOS  2
            //6   BARRACAS    3
            //5   ELETRONICOS 3
            //sqlCmd.CommandText = "SELECT CAST(IIF(SitST = 1, 1, 0) AS BIT) FROM NCMs WHERE CodNCM LIKE '" + valor + "%'";
            da.SelectCommand = sqlCmd;
            dalConexao.Conectar();
            da.Fill(tabela);
            dalConexao.Desconectar();
            return tabela;

        }
    }
}

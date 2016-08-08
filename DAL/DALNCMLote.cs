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

        public DataTable Localizar(string valor, string index)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;

            switch (index)
            {
                case "Subs. Tributária":
                    sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, SitST, FROM NCMs WHERE CodNCM LIKE " + valor + "%'";
                    break;
                case "Autopeças":
                    sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, SitAuto, FROM NCMs WHERE CodNCM LIKE " + valor + "%'";
                    break;
                case "Sem Similar Nac":
                    sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, SitSemSimilar, FROM NCMs WHERE CodNCM LIKE " + valor + "%'";
                    break;
                case "CEST":
                    sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, Cest, FROM NCMs WHERE CodNCM LIKE " + valor + "%'";
                    break;
            }

            da.SelectCommand = sqlCmd;
            dalConexao.Conectar();
            da.Fill(tabela);
            dalConexao.Desconectar();
            return tabela;

        }
    }
}

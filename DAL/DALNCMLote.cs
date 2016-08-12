using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

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
            sqlCmd.CommandText = "SELECT CodNCM, NomeNCM, CAST(SitST AS BIT), CAST(SitAuto AS BIT), CAST(SitSemSimilar AS BIT), Cest FROM NCMs WHERE CodNCM LIKE '" + valor + "%'";
            da.SelectCommand = sqlCmd;
            dalConexao.Conectar();
            da.Fill(tabela);
            dalConexao.Desconectar();
            return tabela;
        }

        public void Alterar(ModeloNCM modelo, int apagar)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            string strCmd;
            if (apagar == 1)
            {
                if (modelo.SitST == 1)
                    { strCmd = "UPDATE NCMs SET SitST = 0 WHERE CodNCM LIKE @CodNCM"; }
                else if (modelo.SitAuto == 1)
                    { strCmd = "UPDATE NCMs SET SitAuto = 0 WHERE CodNCM LIKE @CodNCM"; }
                else if (modelo.SitSemSimilar == 1)
                    { strCmd = "UPDATE NCMs SET SitSemSimilar = 0 WHERE CodNCM LIKE @CodNCM"; }
                else
                    { strCmd = "UPDATE NCMs SET Cest = NULL WHERE CodNCM LIKE @CodNCM"; }
            }
            else
            {
                if (modelo.SitST == 1)
                    { strCmd = "UPDATE NCMs SET SitST = @SitST WHERE CodNCM LIKE @CodNCM"; }
                else if (modelo.SitAuto == 1)
                    { strCmd = "UPDATE NCMs SET SitAuto = @SitAuto WHERE CodNCM LIKE @CodNCM"; }
                else if (modelo.SitSemSimilar == 1)
                    { strCmd = "UPDATE NCMs SET SitSemSimilar = @SitSemSimilar WHERE CodNCM LIKE @CodNCM"; }
                else
                    { strCmd = "UPDATE NCMs SET Cest = @Cest WHERE CodNCM LIKE @CodNCM"; }

            }
            sqlCmd.CommandText = strCmd;
            sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM + "%");
            sqlCmd.Parameters.AddWithValue("@SitST", modelo.SitST);
            sqlCmd.Parameters.AddWithValue("@SitAuto", modelo.SitAuto);
            sqlCmd.Parameters.AddWithValue("@SitSemsimilar", modelo.SitSemSimilar);
            sqlCmd.Parameters.AddWithValue("@Cest", modelo.Cest);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }
    }
}

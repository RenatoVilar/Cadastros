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

        public void Alterar(ModeloNCM modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            //sqlCmd.CommandText = "UPDATE NCMs SET SitST = @SitST, SitAuto = @SitAuto, SitSemSimilar = @SitSemSimilar, Cest = @Cest WHERE CodNCM = @CodNCM";
            sqlCmd.CommandText = "UPDATE NCMs SET SitST = @SitST WHERE CodNCM LIKE '" + "@CodNCM " + "'";
            sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);
            sqlCmd.Parameters.AddWithValue("@SitST", modelo.SitST);
            //sqlCmd.Parameters.AddWithValue("@SitAuto", modelo.SitAuto);
            //sqlCmd.Parameters.AddWithValue("@SitSemSimilar", modelo.SitSemSimilar);
            //sqlCmd.Parameters.AddWithValue("@Cest", modelo.Cest);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }
    }
}

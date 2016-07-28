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
    public class DALNCM
    {
        private DALConexao dalConexao;

        public DALNCM(DALConexao dalconexao)
        {
            this.dalConexao = dalconexao;
        }

        public void Inserir(ModeloNCM modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "INSERT INTO NCMs(CodNCM, NomeNCM, SitST, SitAuto, SitSemSimilar, Cest) values (@CodNCM, @NomeNCM, @SitST, @SitAuto, @SitSemSimilar, @Cest);" +
                                 "SELECT @@IDENTITY;";
            sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);
            sqlCmd.Parameters.AddWithValue("@NomeNCM", modelo.NomeNCM);
            sqlCmd.Parameters.AddWithValue("@SitST", modelo.SitST);
            sqlCmd.Parameters.AddWithValue("@SitAuto", modelo.SitAuto);
            sqlCmd.Parameters.AddWithValue("@SitSemSimilar", modelo.SitSemSimilar);
            sqlCmd.Parameters.AddWithValue("@Cest", modelo.Cest);
            dalConexao.Conectar();
            modelo.NCMID = Convert.ToInt32(sqlCmd.ExecuteScalar());
            dalConexao.Desconectar();
        }

        public void Alterar(ModeloNCM modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "UPDATE NCMs SET NomeNCM = @NomeNCM, SitST = @SitST, SitAuto = @SitAuto, SitSemSimilar = @SitSemSimilar, Cest = @Cest WHERE CodNCM = @CodNCM";
            sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);
            sqlCmd.Parameters.AddWithValue("@NomeNCM", modelo.NomeNCM);
            sqlCmd.Parameters.AddWithValue("@SitST", modelo.SitST);
            sqlCmd.Parameters.AddWithValue("@SitAuto", modelo.SitAuto);
            sqlCmd.Parameters.AddWithValue("@SitSemSimilar", modelo.SitSemSimilar);
            sqlCmd.Parameters.AddWithValue("@Cest", modelo.Cest);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public void Excluir(int CodNCM)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "DELETE FROM NCMs WHERE CodNCM = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", CodNCM);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public DataTable Localizar(string valor, int index)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            
            if (index == 0)
            {
                sqlCmd.CommandText = "SELECT CodNCM, NomeNCM FROM NCMs WHERE CodNCM LIKE '%" + valor + "%'";
            }
            else
            {
                sqlCmd.CommandText = "SELECT CodNCM, NomeNCM FROM NCMs WHERE NomeNCM LIKE '%" + valor + "%'";
            }
            da.SelectCommand = sqlCmd;
            dalConexao.Conectar();
            da.Fill(tabela);
            dalConexao.Desconectar();
            return tabela;
        }

        public ModeloNCM CarregaModeloNCM(int CodNCM)
        {
            ModeloNCM modelo = new ModeloNCM();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT * FROM NCMs WHERE CodNCM = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", CodNCM);
            dalConexao.Conectar();
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                modelo.NCMID = Convert.ToInt32(dr["NCMID"]);
                modelo.CodNCM = Convert.ToString(dr["CodNCM"]);
                modelo.NomeNCM = Convert.ToString(dr["NomeNCM"]);
                modelo.SitST = Convert.ToInt32(dr["SitST"]);
                modelo.SitAuto = Convert.ToInt32(dr["SitAuto"]);
                modelo.SitSemSimilar = Convert.ToInt32(dr["SitSemSimilar"]);
                modelo.Cest = Convert.ToString(dr["Cest"]);
            }

            dalConexao.Desconectar();
            return modelo;
        }
    }
}

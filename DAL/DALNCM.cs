using System;
using System.Data;
using System.Data.SqlServerCe;
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
            SqlCeCommand sqlCmd = new SqlCeCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            dalConexao.Conectar();
            sqlCmd.CommandText = "SELECT (CodNCM) from NCMs WHERE CodNCM=@CodNCM";
            sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);
            SqlCeDataReader result = sqlCmd.ExecuteResultSet(ResultSetOptions.Scrollable);
            if(result.HasRows)
            {
                throw new Exception("A NCM já existe !");
            }
            else
            {
                sqlCmd.CommandText = "INSERT INTO NCMs(CodNCM, NomeNCM, SitST, SitAuto, SitSemSimilar, Cest) values (@CodNCM, @NomeNCM, @SitST, @SitAuto, @SitSemSimilar, @Cest);";
                
            }
         
            //sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);
            sqlCmd.Parameters.AddWithValue("@NomeNCM", modelo.NomeNCM);
            sqlCmd.Parameters.AddWithValue("@SitST", modelo.SitST);
            sqlCmd.Parameters.AddWithValue("@SitAuto", modelo.SitAuto);
            sqlCmd.Parameters.AddWithValue("@SitSemSimilar", modelo.SitSemSimilar);
            sqlCmd.Parameters.AddWithValue("@Cest", modelo.Cest);
            sqlCmd.ExecuteNonQuery();
            sqlCmd.CommandText = "SELECT @@IDENTITY;";
            modelo.NCMID = Convert.ToInt32(sqlCmd.ExecuteScalar());
            dalConexao.Desconectar();
        }

        public void Alterar(ModeloNCM modelo)
        {
            SqlCeCommand sqlCmd = new SqlCeCommand();
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
            SqlCeCommand sqlCmd = new SqlCeCommand();
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
            SqlCeDataAdapter da = new SqlCeDataAdapter();
            SqlCeCommand sqlCmd = new SqlCeCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            
            if (index == 0) // NCM = 0 Descrição = 1
            {
                sqlCmd.CommandText = "SELECT CodNCM, NomeNCM FROM NCMs WHERE CodNCM LIKE '"  + valor + "%'";
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
            SqlCeCommand sqlCmd = new SqlCeCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT * FROM NCMs WHERE CodNCM = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", CodNCM);
            dalConexao.Conectar();
            SqlCeDataReader dr = sqlCmd.ExecuteResultSet(ResultSetOptions.Scrollable);
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

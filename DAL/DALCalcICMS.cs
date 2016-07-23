using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Modelo;

namespace DAL
{
    public class DALCalcICMS
    {
        private DALConexao dalConexao;

        public DALCalcICMS(DALConexao dalconexao)
        {
            this.dalConexao = dalconexao;
        }

        public void Inserir(ModeloCalcICMS modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "INSERT INTO CalcICMS(NomeCalc) VALUES (@NomeCalc); SELECT @@IDENTITY;";
            sqlCmd.Parameters.AddWithValue("@NomeCalc", modelo.NomeCalc);
            dalConexao.Conectar();
            modelo.CalcID = Convert.ToInt32(sqlCmd.ExecuteScalar());
            dalConexao.Desconectar();
        }

        public void Alterar(ModeloCalcICMS modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "UPDATE CalcICMS SET NomeCalc = @NomeCalc WHERE CalcID = @Codigo";
            sqlCmd.Parameters.AddWithValue("@NomeCalc", modelo.NomeCalc);
            sqlCmd.Parameters.AddWithValue("@Codigo", modelo.CalcID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public void Excluir(int CalcID)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "DELETE FROM CalcICMS WHERE CalcID = @Codigo";
            sqlCmd.Parameters.AddWithValue("@Codigo", CalcID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CalcICMS WHERE NomeCalc LIKE '%" +
                                                    valor + "%'", dalConexao.SqlConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCalcICMS CarregaModeloCalcICMS(int CalcID)
        {
            ModeloCalcICMS modelo = new ModeloCalcICMS();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT * FROM CalcICMS WHERE CalcID = @Codigo";
            sqlCmd.Parameters.AddWithValue("@Codigo", CalcID);
            dalConexao.Conectar();
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                modelo.CalcID = Convert.ToInt32(dr["CalcID"]);
                modelo.NomeCalc = Convert.ToString(dr["NomeCalc"]);
            }
            dalConexao.Desconectar();
            return modelo;
        }
    }
}

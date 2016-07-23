using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALTpProduto
    {
        private DALConexao dalConexao;

        public DALTpProduto(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public void Inserir(ModeloTpProduto modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "INSERT INTO TpProdutos(NomeTipo) values (@nome); SELECT @@IDENTITY;";
            sqlCmd.Parameters.AddWithValue("@nome", modelo.NomeTipo);
            dalConexao.Conectar();
            modelo.TipoID  = Convert.ToInt32(sqlCmd.ExecuteScalar());
            dalConexao.Desconectar();
        }

        public void Alterar(ModeloTpProduto modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "UPDATE TpProdutos SET NomeTipo = @nome WHERE TipoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@nome", modelo.NomeTipo);
            sqlCmd.Parameters.AddWithValue("@codigo", modelo.TipoID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public void Excluir(int TipoID)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "DELETE FROM TpProdutos WHERE TipoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", TipoID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TpProdutos WHERE NomeTipo LIKE '%" +
                                                    valor + "%'", dalConexao.SqlConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloTpProduto CarregaModeloTpProduto(int TipoID)
        {
            ModeloTpProduto modelo = new ModeloTpProduto();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT * FROM TpProdutos WHERE TipoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", TipoID);
            dalConexao.Conectar();
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                modelo.TipoID = Convert.ToInt32(dr["TipoID"]);
                modelo.NomeTipo = Convert.ToString(dr["NomeTipo"]);
            }
            dalConexao.Desconectar();
            return modelo;
        }
     }
}

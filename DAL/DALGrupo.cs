using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALGrupo
    {
        private DALConexao dalConexao;

        public DALGrupo (DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }
        
        public void Inserir(ModeloGrupo modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "INSERT INTO Grupos (NomeGrupo, TipoID) values (@nome, @TipoID); SELECT @@IDENTITY;";
            sqlCmd.Parameters.AddWithValue("@nome", modelo.NomeGrupo);
            sqlCmd.Parameters.AddWithValue("TipoID", modelo.TipoID);
            dalConexao.Conectar();
            modelo.GrupoID = Convert.ToInt32(sqlCmd.ExecuteScalar());
            dalConexao.Desconectar();
        }

        public void Alterar(ModeloGrupo modelo)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "UPDATE Grupos SET NomeGrupo = @nome, TipoID = @TipoID WHERE GrupoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@nome", modelo.NomeGrupo);
            sqlCmd.Parameters.AddWithValue("@TipoID", modelo.TipoID);
            sqlCmd.Parameters.AddWithValue("@codigo", modelo.GrupoID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();

        }

        public void Excluir(int GrupoID)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "DELETE FROM Grupos WHERE GrupoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", GrupoID);
            dalConexao.Conectar();
            sqlCmd.ExecuteNonQuery();
            dalConexao.Desconectar();

        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Grupos WHERE NomeGrupo LIKE '%" + valor + "%'", dalConexao.SqlConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloGrupo CarregaModeloGrupo(int GrupoID)
        {
            ModeloGrupo modelo = new ModeloGrupo();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = dalConexao.SqlConexao;
            sqlCmd.CommandText = "SELECT * FROM Grupos WHERE GrupoID = @codigo";
            sqlCmd.Parameters.AddWithValue("@codigo", GrupoID);
            dalConexao.Conectar();
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                modelo.GrupoID = Convert.ToInt32(dr["GrupoID"]);
                modelo.NomeGrupo = Convert.ToString(dr["NomeGrupo"]);
                modelo.TipoID = Convert.ToInt32(dr["TipoID"]);
            }
            dalConexao.Desconectar();
            return modelo;
        }
    }
}

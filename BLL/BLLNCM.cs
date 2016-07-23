using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BLLNCM
    {
        private DALConexao dalconexao;

        public BLLNCM(DALConexao dalconexao)
        {
            this.dalconexao = dalconexao;
        }

        public void Incluir(ModeloNCM modelo)
        {
            if (modelo.CodNCM.Trim().Length == 0 || modelo.CodNCM.Trim().Length > 8)
            {
                throw new Exception("O código da NCM deve conter 8 números");
            }

            if (modelo.CodNCM.Where(c => char.IsLetter(c)).Count() > 0)
            {
                throw new Exception("A NCM deve conter apenas números");
            }

            if (modelo.NomeNCM.Trim().Length == 0)
            {
                throw new Exception("O nome da NCM é obrigatório");
            }

            dalconexao.Conectar();

            using (SqlCommand sqlCmd = new SqlCommand("SELECT (CodNCM) from NCMs WHERE CodNCM=@CodNCM", dalconexao.SqlConexao))
            {
                sqlCmd.Parameters.AddWithValue("@CodNCM", modelo.CodNCM);

                SqlDataReader read = sqlCmd.ExecuteReader();

                if (read.Read())
                {
                    throw new Exception("A NCM já existe !");
                }
            }

            dalconexao.Desconectar();

            modelo.NomeNCM = modelo.NomeNCM.ToUpper();
            DALNCM dalNCM = new DALNCM(dalconexao);
            dalNCM.Inserir(modelo);
        }

        public void Alterar(ModeloNCM modelo)
        {
            if (modelo.CodNCM.Trim().Length == 0 || modelo.CodNCM.Trim().Length > 8)
            {
                throw new Exception("O código da NCM deve conter 8 números");
            }

            if (modelo.CodNCM.Where(c => char.IsLetter(c)).Count() > 0)
            {
                throw new Exception("A NCM deve conter apenas números");
            }

            if (modelo.NomeNCM.Trim().Length == 0)
            {
                throw new Exception("O nome da NCM é obrigatório");
            }

            modelo.NomeNCM = modelo.NomeNCM.ToUpper();
            DALNCM dalNCM = new DALNCM(dalconexao);
            dalNCM.Alterar(modelo);
        }

        public void Excluir(int NCMID)
        {
            DALNCM dalNCM = new DALNCM(dalconexao);
            dalNCM.Excluir(NCMID);
        }

        public DataTable Localizar(string valor, int index)
        {
            DALNCM dalNCM = new DALNCM(dalconexao);
            return dalNCM.Localizar(valor, index);
        }

        public ModeloNCM CarregaModeloNCM(int NCMID)
        {
            DALNCM dalNCM = new DALNCM(dalconexao);
            return dalNCM.CarregaModeloNCM(NCMID);
           
        }
        



            

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Modelo;
using System.Data.SqlClient;


namespace BLL
{
    public class BLLNCMLote
    {
        private DALConexao dalConexao;

        public BLLNCMLote(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public DataTable Localizar(string valor)
        {
            DALNCMLote dalNCMLote = new DALNCMLote(dalConexao);
            return dalNCMLote.Localizar(valor);
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
            
            DALNCMLote dalNCM = new DALNCMLote(dalConexao);
            dalNCM.Alterar(modelo);
        }

    }


}

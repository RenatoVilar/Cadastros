using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

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
    }
}

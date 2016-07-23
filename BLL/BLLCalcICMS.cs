using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLCalcICMS
    {
        private DALConexao dalConexao;

        public BLLCalcICMS(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public void Incluir(ModeloCalcICMS modelo)
        {
            if(modelo.NomeCalc.Trim().Length == 0)
            {
                throw new Exception("O nome do Cálculo de ICMS é obrigatório");
            }

            modelo.NomeCalc = modelo.NomeCalc.ToUpper();

            DALCalcICMS dalCalCICMS = new DALCalcICMS(dalConexao);
            dalCalCICMS.Inserir(modelo);
        }

        public void Alterar(ModeloCalcICMS modelo)
        {
            if (modelo.CalcID < 0)
            {
                throw new Exception("O código do Cálculo de ICMS é obrigatório");
            }

            if(modelo.NomeCalc.Trim().Length == 0)
            {
                throw new Exception("O nome do Cálculo de ICMS é obrigatório");
            }

            modelo.NomeCalc = modelo.NomeCalc.ToUpper();
            DALCalcICMS dalCalcICMS = new DALCalcICMS(dalConexao);
            dalCalcICMS.Alterar(modelo);
        }

        public void Excluir(int CalcID)
        {
            DALCalcICMS dalCalcICMS = new DALCalcICMS(dalConexao);
            dalCalcICMS.Excluir(CalcID);
        }

        public DataTable Localizar(string valor)
        {
            DALCalcICMS dalCalcICMS = new DALCalcICMS(dalConexao);
            return dalCalcICMS.Localizar(valor);
        }

        public ModeloCalcICMS CarregaModeloCalcICMS(int CalcID)
        {
            DALCalcICMS dalCalcICMS = new DALCalcICMS(dalConexao);
            return dalCalcICMS.CarregaModeloCalcICMS(CalcID);
        }
       
    }
}

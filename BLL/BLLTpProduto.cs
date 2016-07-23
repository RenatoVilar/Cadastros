using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTpProduto
    {
        private DALConexao dalConexao;

        public BLLTpProduto(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public void Incluir(ModeloTpProduto modelo)
        {
            if (modelo.NomeTipo.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo é obrigatório!");
            }

            modelo.NomeTipo = modelo.NomeTipo.ToUpper();

            DALTpProduto dalTpProduto = new DALTpProduto(dalConexao);
            dalTpProduto.Inserir(modelo);
           
        }

        public void Alterar(ModeloTpProduto modelo)
        {
            if(modelo.TipoID <= 0)
            {
                throw new Exception("O Código do Tipo é obrigtório");
            }

            if (modelo.NomeTipo.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo é Obrigatório!");
            }

            modelo.NomeTipo = modelo.NomeTipo.ToUpper();
            DALTpProduto dalTpProduto = new DALTpProduto(dalConexao);
            dalTpProduto.Alterar(modelo);
            
        }

        public void Excluir(int TipoID)
        {
            DALTpProduto dalTpProduto = new DALTpProduto(dalConexao);
            dalTpProduto.Excluir(TipoID);
        }

        public DataTable Localizar(string valor)
        {
            DALTpProduto dalTpProduto = new DALTpProduto(dalConexao);
            return dalTpProduto.Localizar(valor);
        }

        public ModeloTpProduto CarregaModeloTpProduto(int TipoID)
        {
            DALTpProduto dalTpProduto = new DALTpProduto(dalConexao);
            return dalTpProduto.CarregaModeloTpProduto(TipoID);
        }


    }
}

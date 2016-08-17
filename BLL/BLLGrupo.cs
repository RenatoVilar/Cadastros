using System;
using System.Data;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLGrupo
    {
        private DALConexao dalConexao;

        public BLLGrupo(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public void Incluir(ModeloGrupo modelo)
        {
            if(modelo.NomeGrupo.Trim().Length == 0)
            {
                throw new Exception("O Nome do Grupo é obrigatório");
            }

            modelo.NomeGrupo = modelo.NomeGrupo.ToUpper();
           
            DALGrupo dalGrupo = new DALGrupo(dalConexao);
            dalGrupo.Inserir(modelo);
           
        }

        public void Alterar(ModeloGrupo modelo)
        {
            if (modelo.GrupoID <= 0)
            {
                throw new Exception("O Código do Grupo é obrigatório");
            }

            if (modelo.NomeGrupo.Trim().Length == 0)
            {
                throw new Exception("O Nome do Grupo é obrigatório");
            }

            modelo.NomeGrupo = modelo.NomeGrupo.ToUpper();

            DALGrupo dalGrupo = new DALGrupo(dalConexao);
            dalGrupo.Alterar(modelo);
        }

        public void Excluir(int GrupoID)
        {
            if (GrupoID == 1 || GrupoID == 2)
            {
                throw new Exception("Esse Grupo não pode ser excluído!");
                
            }

            DALGrupo dalGrupo = new DALGrupo(dalConexao);
            dalGrupo.Excluir(GrupoID);
        }

        public DataTable Localizar(string valor)
        {
            DALGrupo dalGrupo = new DALGrupo(dalConexao);
            return dalGrupo.Localizar(valor);
        }

        public ModeloGrupo CarregaModeloGrupo(int GrupoID)
        {
            DALGrupo dalGrupo = new DALGrupo(dalConexao);
            return dalGrupo.CarregaModeloGrupo(GrupoID);
        }
    }
}

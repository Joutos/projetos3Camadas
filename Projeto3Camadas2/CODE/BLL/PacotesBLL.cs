using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas2.CODE.DTO;
using Projeto3Camadas2.CODE.DAL;
using System.Data;

namespace Projeto3Camadas2.CODE.BLL
{
    class PacotesBLL
    {
        AcessoBancoDeDados conexao = new AcessoBancoDeDados();
        string tabela = "tbl_pacotes";
        public void Inserir(PacotesDTO pacdto)
        {
            string Inserir = $"INSERT INTO {tabela} VALUES(NULL, '{pacdto.Preco}', '{pacdto.Desc}', '{pacdto.Nome}')";
            conexao.ExecutarComando(Inserir);

        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id; ";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(PacotesDTO pacdto)
        {
            string editar = $"UPDATE {tabela} SET `preco` = '{pacdto.Preco}',`nome` = '{pacdto.Nome}', `descricao` = '{pacdto.Desc}' WHERE `id` = {pacdto.Id};";
            conexao.ExecutarComando(editar);
        }

        public void Excluir (PacotesDTO pacdto)
        {
            string excluir = $"delete from {tabela} where id = '{pacdto.Id}';";
            conexao.ExecutarComando(excluir);
        }


    }
}

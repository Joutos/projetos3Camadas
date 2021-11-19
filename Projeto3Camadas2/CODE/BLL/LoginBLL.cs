using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto3Camadas2.CODE.DTO;
using Projeto3Camadas2.CODE.DAL;


namespace Projeto3Camadas2.CODE.BLL
{
    class LoginBLL
    {
        AcessoBancoDeDados conexao = new AcessoBancoDeDados();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"SELECT * FROM tbl_login WHERE email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0) return true; else return false;
        }

    }
}

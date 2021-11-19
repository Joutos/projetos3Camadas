using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas2.CODE.DTO
{
    class PacotesDTO
    {

        private int _id;
        private string _preco;
        private string _desc;
        private string _nome;

        public int Id { get => _id; set => _id = value; }
        public string Preco { get => _preco; set => _preco = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}

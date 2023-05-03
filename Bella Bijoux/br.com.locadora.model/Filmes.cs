using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_locadora.br.com.locadora.model
{
    public class Filmes
    {
        public int id { get; set; }

        public int Categoria_id{get;set;}

        public string nome_filme { get; set; }

        public string diretor { get; set; }

        public decimal valor_locacao { get; set; }
    }
}

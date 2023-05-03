using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_locadora.br.com.locadora.model
{
    public class Produtos
    {
        public int id { get; set; }

        public int codigo{get;set;}

        public string descricao { get; set; }

        public int quantidade { get; set; }

        public int estoque { get; set; }

        public decimal valor_compra { get; set; }

        public decimal valor_venda { get; set; }
    }
}

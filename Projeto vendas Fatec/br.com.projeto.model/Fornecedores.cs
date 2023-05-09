using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_vendas_Fatec.br.com.projeto.model
{
    class Fornecedores:Clientes
    {
        private string cnpj;

        public string Cnpj { get => cnpj; set => cnpj = value; }
    }
}

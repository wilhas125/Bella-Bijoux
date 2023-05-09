using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_vendas_Fatec.br.com.projeto.model
{
    class Funcionarios : Clientes
    {

        //Atributo
        //getter e setter
        private string senha;
        private string cargo;
        private string nivel;

        public string Senha { get => senha; set => senha = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}

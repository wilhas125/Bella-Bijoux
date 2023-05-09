using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_vendas_Fatec.br.com.projeto.model
{
    public class CupomF
    {
        public string NomeEstabelecimento { get; set; }
        public string CnpjEstabelecimento { get; set; }
        public DateTime DataHoraEmissao { get; set; }
        public string ItensVendidos { get; set; }
        public double ValorTotal { get; set; }
        public string FormaPagamento { get; set; }
    }
}

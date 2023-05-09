using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_vendas_Fatec.br.com.projeto.dao;
using Projeto_vendas_Fatec.br.com.projeto.model;

namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    public partial class Cupom : Form
    {
        public Cupom()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
        // Ler os dados inseridos pelo usuário
        string nomeEstabelecimento = txtNomeEstabelecimento.Text;
                string cnpjEstabelecimento = txtCnpjEstabelecimento.Text;
                DateTime dataHoraEmissao = DateTime.Now;
                string itensVendidos = txtItensVendidos.Text;
                double valorTotal = Convert.ToDouble(txtValorTotal.Text);
                string formaPagamento = txtFormaPagamento.Text;

                // Criar uma instância da classe Cupom e preencher com os dados do cupom
                CupomF cupom = new CupomF();
                cupom.NomeEstabelecimento = nomeEstabelecimento;
                cupom.CnpjEstabelecimento = cnpjEstabelecimento;
                cupom.DataHoraEmissao = dataHoraEmissao;
                cupom.ItensVendidos = itensVendidos;
                cupom.ValorTotal = valorTotal;
                cupom.FormaPagamento = formaPagamento;

            // Chamar o método para gerar o cupom
            string codigoCupom = GerarCodigoCupom(cupom);

                // Exibir o código do cupom para o usuário
                txtCodigoCupom.Text = codigoCupom;
            }

            private string GerarCodigoCupom(CupomF cupom)
            {
                // Criar uma string com as informações do cupom no formato adequado
                string codigoCupom = "";
                codigoCupom += "Nome do estabelecimento: " + cupom.NomeEstabelecimento + "\n";
                codigoCupom += "CNPJ do estabelecimento: " + cupom.CnpjEstabelecimento + "\n";
                codigoCupom += "Data e hora da emissão: " + cupom.DataHoraEmissao.ToString() + "\n";
                codigoCupom += "Itens vendidos: " + cupom.ItensVendidos + "\n";
                codigoCupom += "Valor total: R$" + cupom.ValorTotal.ToString("F2") + "\n";
                codigoCupom += "Forma de pagamento: " + cupom.FormaPagamento + "\n";

                // Retornar o código do cupom
                return codigoCupom;
            }

        }
    }

    

 

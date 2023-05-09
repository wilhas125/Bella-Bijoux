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
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    public partial class frmCupom : Form
    {
        public frmCupom()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
        // Ler os dados inseridos pelo usuário
        string nomeEstabelecimento = txtNomeEstabelecimento.Text;
                string cnpjEstabelecimento = txtCnpjEstabelecimento.Text;
                DateTime dataHoraEmissao = DateTime.Now;
                string itensVendidos = listBoxItensVendidos.Text;
                //decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                string formaPagamento = txtFormaPagamento.Text;

                // Criar uma instância da classe Cupom e preencher com os dados do cupom
                CupomF cupom = new CupomF();
                cupom.NomeEstabelecimento = nomeEstabelecimento;
                cupom.CnpjEstabelecimento = cnpjEstabelecimento;
                cupom.DataHoraEmissao = dataHoraEmissao;
                cupom.ItensVendidos = itensVendidos;
                //cupom.ValorTotal = valorTotal;
                cupom.FormaPagamento = formaPagamento;

            // Chamar o método para gerar o cupom
            string codigoCupom = GerarCodigoCupom(cupom);

            // Exibir o código do cupom para o usuário
            textCodCupom.Text = codigoCupom;
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

        private void button1_Click_1(object sender, EventArgs e)
        {// Criar um bitmap com o tamanho do formulário
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Desenhar o conteúdo do formulário no bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Criar um objeto PrintDocument e definir o manipulador de impressão
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) =>
            {
                // Desenhar o bitmap na página de impressão
                ev.Graphics.DrawImage(bitmap, ev.PageBounds);
            };

            // Exibir a janela de impressão e imprimir o documento
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void dgCupom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "server=localhost;database=bdfatec;uid=root;password=Ww@53375507;";
            MySqlConnection conexao = new MySqlConnection(connectionString);


            {
                conexao.Open();
                string consulta = "SELECT * FROM tb_fornecedores";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexao))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgCupom.DataSource = dt;
                    }
                    conexao.Close();
                }

            }



        }
    }
    }

    

 

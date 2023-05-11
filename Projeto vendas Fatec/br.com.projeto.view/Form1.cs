using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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



        private void Cupom_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=bdfatec;uid=root;password=Ww@53375507;";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string consulta = "SELECT nome, endereco, cidade, estado, cep, telefone FROM tb_fornecedores";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexao))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgCupom.DataSource = dt;

                        // Oculta a coluna do ID
                        dgCupom.Columns[0].Visible = false;

                        // Define as propriedades para ajustar ao tamanho da tela
                        // dgCupom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        //  dgCupom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dgCupom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgCupom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                }
            }


        }




        private void button1_Click_1(object sender, EventArgs e)

        {
            string connectionString = "server=localhost;database=bd_bellabijoux;uid=root;password=Ww@53375507;";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "SELECT nome_loja, endereco_loja, cnpj_loja, data_hora, descricao_produto, quantidade, preco_unitario, subtotal, desconto, total, forma_pagamento FROM tb_cupom_fiscal";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                MySqlDataReader reader = command.ExecuteReader();

                // Cria o documento para impressão
                PrintDocument printDoc = new PrintDocument();

                // Define a orientação da página
                printDoc.DefaultPageSettings.Landscape = false;

                // Define o tamanho da página
                printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

                // Adiciona o evento de impressão
                printDoc.PrintPage += (s, ev) =>
                {
                // Define a fonte e as margens
                Font fonteTitulos = new Font("Arial", 14, FontStyle.Bold);
                    Font fonteDados = new Font("Arial", 12, FontStyle.Regular);
                    int margemEsquerda = 50;
                    int margemSuperior = 100;

                // Define os títulos das colunas
                string[] titulos = { "Nome da loja", "Endereço da loja", "CNPJ da loja", "Data e hora da venda", "Descrição do produto", "Quantidade", "Preço unitário", "Subtotal", "Desconto", "Total a pagar", "Forma de pagamento" };

                // Imprime os títulos
                for (int i = 0; i < titulos.Length; i++)
                    {
                        ev.Graphics.DrawString(titulos[i], fonteTitulos, Brushes.Black, margemEsquerda + i * 100, margemSuperior);
                    }

                // Define a altura da linha de dados
                int alturaLinha = 20;

                // Imprime os dados coletados do banco de dados
                int linhaAtual = margemSuperior + alturaLinha;
                    while (reader.Read())
                    {
                        string nomeLoja = reader.GetString("nome_loja");
                        string enderecoLoja = reader.GetString("endereco_loja");
                        string cnpjLoja = reader.GetString("cnpj_loja");
                        DateTime dataHoraVenda = reader.GetDateTime("data_hora");
                        string descricaoProduto = reader.GetString("descricao_produto");
                        int quantidade = reader.GetInt32("quantidade");
                        decimal precoUnitario = reader.GetDecimal("preco_unitario");
                        decimal subtotal = reader.GetDecimal("subtotal");
                        decimal desconto = reader.GetDecimal("desconto");
                        decimal total = reader.GetDecimal("total");
                        string formaPagamento = reader.GetString("forma_pagamento");
                        ev.Graphics.DrawString(nomeLoja, fonteDados, Brushes.Black, margemEsquerda, linhaAtual);
                        ev.Graphics.DrawString(enderecoLoja, fonteDados, Brushes.Black, margemEsquerda + 100, linhaAtual);
                        ev.Graphics.DrawString(cnpjLoja, fonteDados, Brushes.Black, margemEsquerda + 200, linhaAtual);
                        ev.Graphics.DrawString(dataHoraVenda.ToString("dd/MM/yyyy HH:mm:ss"), fonteDados, Brushes.Black, margemEsquerda + 400, linhaAtual);
                        ev.Graphics.DrawString(descricaoProduto, fonteDados, Brushes.Black, margemEsquerda + 600, linhaAtual);
                        ev.Graphics.DrawString(quantidade.ToString(), fonteDados, Brushes.Black, margemEsquerda + 800, linhaAtual);
                        ev.Graphics.DrawString(precoUnitario.ToString("C"), fonteDados, Brushes.Black, margemEsquerda + 900, linhaAtual);
                        ev.Graphics.DrawString(subtotal.ToString("C"), fonteDados, Brushes.Black, margemEsquerda + 1000, linhaAtual);
                        ev.Graphics.DrawString(desconto.ToString("C"), fonteDados, Brushes.Black, margemEsquerda + 1100, linhaAtual);
                        ev.Graphics.DrawString(total.ToString("C"), fonteDados, Brushes.Black, margemEsquerda + 1200, linhaAtual);
                        ev.Graphics.DrawString(formaPagamento, fonteDados, Brushes.Black, margemEsquerda + 1300, linhaAtual);
                        linhaAtual += alturaLinha;
                    }
                };
                reader.Close();


                // Abre a janela de diálogo de impressão
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;
                if (printDlg.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
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





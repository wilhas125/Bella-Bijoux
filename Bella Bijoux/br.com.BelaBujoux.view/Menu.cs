using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bella_Bijoux
{
    public partial class Menu : Form
    {
        private MySqlConnection connection;

        public Menu()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user id=root;password=Ww@53375507;database=BellaBijoux";
            connection = new MySqlConnection(connectionString);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa(connection); // passa a conexão como parâmetro para o novo formulário
            caixa.Show();
            // this.Hide(); 
        }
        private void TestarConexao()
        {
            string connectionString = "server=localhost;database=BellaBijoux;uid=root;password=Ww@53375507;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios(connection);
            relatorios.Show();
            // this.Hide(); 
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(connection);
            cadastro.Show();
            // this.Hide(); 
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque(connection);
            estoque.Show();
            // this.Hide(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho(connection);
            carrinho.Show();
            // this.Hide(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                TestarConexao();
            
        }
    }
}


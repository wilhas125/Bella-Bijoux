using MySql.Data.MySqlClient;
using Projeto_vendas_Fatec.br.com.projeto.con;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao;
                conexao = new ConnectionFactory().getConnection();
                conexao.Open();
                MessageBox.Show("Conectado com Sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Desconectado! Erro:" + erro);
            }
        }
    }
}

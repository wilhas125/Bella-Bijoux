using Sistema_locadora.br.com.locadora.dao;
using Sistema_locadora.br.com.locadora.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_locadora.br.com.locadora.view
{
    public partial class frmfilme : Form
    {
        public frmfilme()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //1 Passo - receber os dados da tela no objeto model de cliente
                Filmes obj = new Filmes();

                obj.Categoria_id =int.Parse(txtcategoria.Text);
                obj.nome_filme = txtnome.Text;
                obj.diretor=txtdiretor.Text;
                obj.valor_locacao =decimal.Parse(txtvalor.Text);




                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FilmesDao dao = new FilmesDao();
                dao.CadastrarFilmes(obj);



                //MEtodos para limpar a tela de entrada de dados
                txtcategoria.Text = "";
                txtnome.Text = "";
                txtdiretor.Text = "";
                txtvalor.Text = "";
                txtnome.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcategoria.Text = "";
            txtnome.Text = "";
            txtdiretor.Text = "";
            txtvalor.Text = "";
            txtnome.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

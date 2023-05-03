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
    public partial class frmconsultafilmes : Form
    {
        public frmconsultafilmes()
        {
            InitializeComponent();
        }

        private void frmconsultafilmes_Load(object sender, EventArgs e)
        {
            FilmesDao dao = new FilmesDao();
            tabelaconsultafilmes.DataSource = dao.listarFilmes();
        }

        private void tabelaconsultafilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaconsultafilmes.CurrentRow.Cells[0].Value.ToString();
            txtcategoria.Text = tabelaconsultafilmes.CurrentRow.Cells[1].Value.ToString();
            txtnome.Text = tabelaconsultafilmes.CurrentRow.Cells[2].Value.ToString();
            txtdiretor.Text = tabelaconsultafilmes.CurrentRow.Cells[3].Value.ToString();
            txtvalor.Text = tabelaconsultafilmes.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Filmes obj = new Filmes();
                obj.id = int.Parse(txtcodigo.Text);
                obj.Categoria_id =int.Parse(txtcategoria.Text);
                obj.nome_filme = txtnome.Text;
                obj.diretor = txtdiretor.Text;
                obj.valor_locacao =decimal.Parse(txtvalor.Text);
                txtnome.Clear();
                txtcategoria.Text = "";
                txtdiretor.Text = "";
                txtvalor.Text = "";
                txtnome.Focus();

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FilmesDao dao = new FilmesDao();
                dao.alterarFilmes(obj);


                tabelaconsultafilmes.DataSource = dao.listarFilmes();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Filmes obj = new Filmes();
            obj.id=int.Parse(txtcodigo.Text);

            FilmesDao dao = new FilmesDao();
            dao.excluirFilmes(obj);

            txtcategoria.Text = "";
            txtnome.Text = "";
            txtdiretor.Text = "";
            txtvalor.Text = "";
            txtnome.Focus();

        tabelaconsultafilmes.DataSource = dao.listarFilmes();
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisar.Text + "%";


            FilmesDao dao = new FilmesDao();

            tabelaconsultafilmes.DataSource = dao.ConsultarFilmePorNome(nome);
        }
    }
}

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
    public partial class frmconsultacategorias : Form
    {
        public frmconsultacategorias()
        {
            InitializeComponent();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria obj = new Categoria();
                obj.id = int.Parse(txtcodigo.Text);
                obj.nome = txtnome.Text;
                txtnome.Clear();
                txtnome.Focus();

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                CategoriaDao dao = new CategoriaDao();
                dao.alterarCategoria(obj);

                tabelaconsultacategorias.DataSource = dao.listarCategoria();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }

        private void frmconsultacategorias_Load(object sender, EventArgs e)
        {
            CategoriaDao dao = new CategoriaDao();
            tabelaconsultacategorias.DataSource = dao.listarCategoria();
        }

        private void tabelaconsultacategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaconsultacategorias.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaconsultacategorias.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisar.Text + "%";


            CategoriaDao dao = new CategoriaDao();

            tabelaconsultacategorias.DataSource = dao.ConsultarCategoriaNome(nome);
        }

        
        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            obj.id = int.Parse(txtcodigo.Text);

            CategoriaDao dao = new CategoriaDao();
            dao.excluirCategoria(obj);
            txtnome.Clear();
            txtnome.Focus();
            tabelaconsultacategorias.DataSource = dao.listarCategoria();

        }
    }
}

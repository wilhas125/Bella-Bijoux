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
    public partial class frmconsultausuario : Form
    {
        public frmconsultausuario()
        {
            InitializeComponent();
        }

        private void tabelaconsultausuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaconsultausuario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaconsultausuario.CurrentRow.Cells[1].Value.ToString();
            txtemail.Text = tabelaconsultausuario.CurrentRow.Cells[2].Value.ToString();
            txtsenha.Text = tabelaconsultausuario.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void frmconsultausuario_Load(object sender, EventArgs e)
        {
            UsuarioDao dao = new UsuarioDao();
            tabelaconsultausuario.DataSource = dao.listarUsuario();
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            

            string nome = "%" + txtpesquisar.Text + "%";

           
            UsuarioDao dao = new UsuarioDao();

            tabelaconsultausuario.DataSource = dao.ConsultarUsuarioPorNome(nome);


            //tabelaconsultausuario.DataSource = dao.listarUsuario();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            // Receber o nome do campo de texto

            string nome = "%" + txtpesquisar.Text + "%"; ;

            //Criar o objeto ClienteDAO
            UsuarioDao dao = new UsuarioDao();

            tabelaconsultausuario.DataSource = dao.ConsultarUsuarioPorNome(nome);

            if (tabelaconsultausuario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!!");
                tabelaconsultausuario.DataSource = dao.listarUsuario();
            }
           
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuários obj = new Usuários();
                obj.id = int.Parse(txtcodigo.Text);
                obj.nome = txtnome.Text;
                obj.email = txtemail.Text;
                obj.senha = txtsenha.Text;
                txtnome.Clear();
                txtemail.Text = "";
                txtsenha.Text = "";
                txtnome.Focus();

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                UsuarioDao dao = new UsuarioDao();
                dao.alterarUsuario(obj);


                tabelaconsultausuario.DataSource = dao.listarUsuario();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }

        private void tabelaconsultausuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            Usuários obj = new Usuários();
            obj.id = int.Parse(txtcodigo.Text);

            UsuarioDao dao = new UsuarioDao();
            dao.excluirUsuario(obj);
            txtnome.Clear();
            txtemail.Text = "";
            txtsenha.Text = "";
            txtnome.Focus();
            tabelaconsultausuario.DataSource = dao.listarUsuario();
        }
    }
}

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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir outra tela dentro do menu

            frmusuario tela = new frmusuario();
            
            tela.Show();

     
        }

        private void consultarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultausuario tela = new frmconsultausuario();

            tela.Show();
        }

        private void consultarFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultafilmes tela = new frmconsultafilmes();
            tela.Show();
        }

        private void cadastrarFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfilme tela = new frmfilme();
            tela.Show();
        }

        private void cadastrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategoria tela = new frmcategoria();
            tela.Show();
        }

        private void consultarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultacategorias tela = new frmconsultacategorias();
            tela.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

            frmAcesso login = new frmAcesso();
            login.ShowDialog();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAcesso();
            this.Close();

           
            
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

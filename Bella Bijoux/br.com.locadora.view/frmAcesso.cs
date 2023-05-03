using MySql.Data.MySqlClient;
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
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();
        }
        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
                
           
            Usuários obj = new Usuários();
             obj.email = txtEmail.Text;
             obj.senha  = txtSenha.Text;
            LoginDao dao = new LoginDao();

            dao.verfificarLogin(obj);
            if (dao.messagem.Equals(""))
            {
                if (dao.tem)
                {
                     MessageBox.Show("Logado com sucesso ");

                    this.Dispose();

                }
                else
                {
                     MessageBox.Show("Dados não encontrados!! Verifique o email e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtSenha.Text = "";
                    frmAcesso tela = new frmAcesso();
                    tela.ShowDialog();
                }
               
            }
            else 
            {
                MessageBox.Show(dao.messagem);
            }
           
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Principal tela = new Menu_Principal();
            Application.ExitThread();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            frmusuario tela = new frmusuario();
            tela.ShowDialog();
        }
    }
}

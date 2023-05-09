using Bella_Bijoux;
using Projeto_vendas_Fatec;
using Sistema_locadora.br.com.locadora.dao;
using Sistema_locadora.br.com.locadora.model;
using System;
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
            // Controle  controle = new Controle();
            Usuários obj = new Usuários();
            obj.email = txtEmail.Text;
            obj.senha  = txtSenha.Text;
            //dao.acessar(txtEmail.Text,txtSenha.Text);
            LoginDao dao = new LoginDao();

            dao.verfificarLogin(obj);
            if (dao.messagem.Equals(""))
            {
                if (dao.tem)
                {
                    MessageBox.Show("Logado com sucesso ", "Entrando ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmenu menu = new frmenu();
                    menu.Show();
                    txtEmail.Text = ("");
                    txtSenha.Text = ("");
                   
                }
                else
                {
                    MessageBox.Show("Dados não encontrados!! Verifique o email e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void frmAcesso_Load(object sender, EventArgs e)
        {

        }
    }
}

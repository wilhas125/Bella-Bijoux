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
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            frmAcesso tela = new frmAcesso();
            tela.ShowDialog();
            this.Dispose();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            #region //Botão cadastrar
            try
            {

                //1 Passo - receber os dados da tela no objeto model de cliente
                Usuários obj = new Usuários();


                obj.nome = txtnome.Text;
                obj.email = txtemail.Text;
                obj.senha = txtsenha.Text;
                


                #endregion
                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                UsuarioDao dao = new UsuarioDao();
                dao.CadastrarUsuario(obj);

                

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
                txtemail.Text = "";
                txtsenha.Text = "";           
                txtnome.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtemail.Text = "";
            txtsenha.Text = "";
            txtnome.Focus();
        }
    }
    
}

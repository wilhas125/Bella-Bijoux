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
    public partial class frmcategoria : Form
    {
        public frmcategoria()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //1 Passo - receber os dados da tela no objeto model de cliente
                Categoria obj = new Categoria();

                obj.nome = txtnome.Text;
     
                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                CategoriaDao dao = new CategoriaDao();
                dao.CadastrarCategoria(obj);



                //MEtodos para limpar a tela de entrada de dados
                
                txtnome.Text = "";
                txtnome.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtnome.Focus();
        }
    }
}

using Projeto_vendas_Fatec.br.com.projeto.dao;
using Projeto_vendas_Fatec.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        #region //Botão Cadastrar
        private void  btnCadastrar_Click(object sender, EventArgs e)
        {
            //Botão cadastrar
            try
            {
                //1 Passo - receber os dados da tela no objeto model de cliente
                Fornecedores obj = new Fornecedores();
              

                obj.Nome = txtnome.Text;
                obj.Cnpj = 
                obj.Cpf = masktxtCnpj.Text;
                obj.Email = txtemail.Text;
                obj.Telefone = masktxttelefone.Text;
                obj.Celular = masktxtcelular.Text;
                obj.Cep = masktxtcep.Text;
                obj.Endereco = txtendereco.Text;
                obj.Numero = int.Parse(txtnumero.Text);
                obj.Complemento = txtcodigo.Text;
                obj.Bairro = txtbairro.Text;
                obj.Cidade = txtcidade.Text;
                obj.Estado = comboestado.Text;


                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FornecedorDao dao = new FornecedorDao();
                dao.cadastrarFornecedor(obj);
                dgFornecedores.DataSource = dao.listarFornecedores();
               // dgclientes.DataSource = dao.lista();

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
               
                masktxtCnpj.Text = "";
                masktxtCnpj.Text = "";
                txtemail.Text = "";
                masktxttelefone.Text = "";
                masktxtcelular.Text = "";
                masktxtcep.Text = "";
                txtendereco.Text = "";
                txtnumero.Text = "";
                txtcodigo.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                comboestado.Text = "";
                txtcomplemento.Text = "";

                txtnome.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }
        #endregion

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void dgFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        
        }

        private void btncusultar_Click(object sender, EventArgs e)
        {

            // Receber o nome do campo de texto

            string nome = txtPesquisa.Text;

            //Criar o objeto ClienteDAO
            FornecedorDao dao = new FornecedorDao();

            dgFornecedores.DataSource = dao.ConsultarFornecedorPorNome(nome);

            if (dgFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!!");
                dgFornecedores.DataSource = dao.listarFornecedores();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Receber o nome do campo de texto

            string nome = "%" + txtPesquisa.Text + "%";

            //Criar o objeto ClienteDAO
            FornecedorDao dao = new FornecedorDao();

            dgFornecedores.DataSource = dao.ListarFornecedorPorNome(nome);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Botão Pesquisar

            try
            {
                string cep = masktxtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                comboestado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!!" + erro);

            }
        }

        private void combPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDao dao = new FornecedorDao();
            dgFornecedores.DataSource = dao.listarFornecedores();


        }

        private void dgFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada
            txtcodigo.Text = dgFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgFornecedores.CurrentRow.Cells[1].Value.ToString();
            masktxtCnpj.Text = dgFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgFornecedores.CurrentRow.Cells[3].Value.ToString();
            masktxttelefone.Text = dgFornecedores.CurrentRow.Cells[4].Value.ToString();
            masktxtcelular.Text = dgFornecedores.CurrentRow.Cells[5].Value.ToString();
            masktxtcep.Text = dgFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = dgFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = dgFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = dgFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = dgFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = dgFornecedores.CurrentRow.Cells[11].Value.ToString();
            comboestado.Text = dgFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            FornecedorDao dao = new FornecedorDao();   
            dgFornecedores.DataSource = dao.listarFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão Excluir
                //1 Passo- criar o comando sql
                Fornecedores obj = new Fornecedores();
                obj.Id = int.Parse(txtcodigo.Text);

                //2º passo rxecutar o metodo excluirCliente
                FornecedorDao dao = new FornecedorDao();
                dao.excluir(obj);
                dgFornecedores.DataSource = dao.listarFornecedores();
         
                
                txtnome.Text = "";
                masktxtCnpj.Text = "";
                txtemail.Text = "";
                masktxttelefone.Text = "";
                masktxtcelular.Text = "";
                masktxtcep.Text = "";
                txtendereco.Text = "";
                txtnumero.Text = "";
                txtcodigo.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                comboestado.Text = "";
                txtcomplemento.Text = "";

                txtnome.Focus();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedores obj = new Fornecedores();
                obj.Nome = txtnome.Text;
                obj.Cnpj = masktxtCnpj.Text;
                obj.Email = txtemail.Text;
                obj.Telefone = masktxttelefone.Text;
                obj.Celular = masktxtcelular.Text;
                obj.Cep = masktxtcep.Text;
                obj.Endereco = txtendereco.Text;
                obj.Numero = int.Parse(txtnumero.Text);
                obj.Complemento = txtcomplemento.Text;
                obj.Bairro = txtbairro.Text;
                obj.Cidade = txtcidade.Text;
                obj.Estado = comboestado.Text;
                obj.Id = int.Parse(txtcodigo.Text);

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FornecedorDao dao = new FornecedorDao();
                dao.alterarFornecedor(obj);


                dgFornecedores.DataSource = dao.listarFornecedores();

                txtnome.Clear();

                masktxtCnpj.Text = "";
                masktxtCnpj.Text = "";
                txtemail.Text = "";
                masktxttelefone.Text = "";
                masktxtcelular.Text = "";
                masktxtcep.Text = "";
                txtendereco.Text = "";
                txtnumero.Text = "";
                txtcodigo.Text = "";
                txtbairro.Text = "";
                txtcidade.Text = "";
                comboestado.Text = "";
                txtcomplemento.Text = "";

                txtnome.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
    


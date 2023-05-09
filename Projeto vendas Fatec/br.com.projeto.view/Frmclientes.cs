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

namespace Projeto_vendas_Fatec.br.com.pvf.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {



        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            #region //Botão cadastrar
            try
            {
             
                //1 Passo - receber os dados da tela no objeto model de cliente
                Clientes obj = new Clientes();
                
                
                obj.Nome     = txtnome.Text;
                obj.Rg       = masktxtrg.Text;
                obj.Cpf      = masktxtcpf.Text;
                obj.Email    = txtemail.Text;
                obj.Telefone = masktxttelefone.Text;
                obj.Celular  = masktxtcelular.Text;
                obj.Cep      = masktxtcep.Text;
                obj.Endereco = txtendereco.Text;
                obj.Numero   = int.Parse(txtnumero.Text);
                obj.Complemento = txtcodigo.Text;
                obj.Bairro   = txtbairro.Text;
                obj.Cidade   = txtcidade.Text;
                obj.Estado   = comboestado.Text;
               

                #endregion
                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                ClientesDao dao = new ClientesDao();
                dao.cadastrarClientes(obj);

                dgclientes.DataSource = dao.listarClientes();

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
                masktxtrg.Text = "";
                masktxtcpf.Text = "";
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

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes obj = new Clientes();
                obj.Nome = txtnome.Text;
                obj.Rg = masktxtrg.Text;
                obj.Cpf = masktxtcpf.Text;
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
                ClientesDao dao = new ClientesDao();
                dao.alterarCliente(obj);
                    
                    
                dgclientes.DataSource = dao.listarClientes();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!"+erro);
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
        #region //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão Excluir
                //1 Passo- criar o comando sql
                Clientes obj = new Clientes();
                obj.Id = int.Parse(txtcodigo.Text);

                //2º passo rxecutar o metodo excluirCliente
                ClientesDao dao = new ClientesDao();
                dao.excluir(obj);
                dgclientes.DataSource = dao.listarClientes();
                //dgclientes.DataSource = dao.listarClientes();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }
        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClientesDao dao = new ClientesDao();
            dgclientes.DataSource = dao.listarClientes();
                
                
                }
        #region //Pegando os dados da linha selecionada
        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada
            txtcodigo.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
            masktxtrg.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
            masktxtcpf.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
            masktxttelefone.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
            masktxtcelular.Text = dgclientes.CurrentRow.Cells[6].Value.ToString();
            masktxtcep.Text = dgclientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = dgclientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = dgclientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = dgclientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = dgclientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = dgclientes.CurrentRow.Cells[12].Value.ToString();
            comboestado.Text = dgclientes.CurrentRow.Cells[13].Value.ToString();

            tabControl1.SelectedTab = tabPage1;

        }
        #endregion
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btncusultar_Click(object sender, EventArgs e)
        {
            // Receber o nome do campo de texto

            string nome = "%" + txtPesquisa.Text + "%"; ;

            //Criar o objeto ClienteDAO
            ClientesDao dao = new ClientesDao();

            dgclientes.DataSource = dao.ConsultarClientePorNome(nome);

            if (dgclientes.Rows.Count ==0 )
            {
                MessageBox.Show("Nenhum cliente encontrado!!");
                dgclientes.DataSource = dao.listarClientes();
            }
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Receber o nome do campo de texto

            string nome = "%"+ txtPesquisa.Text + "%";

            //Criar o objeto ClienteDAO
            ClientesDao dao = new ClientesDao();

            dgclientes.DataSource = dao.ListarClientesPorNome(nome);
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

                txtendereco.Text = dados.Tables[0].Rows[0]["endereco"].ToString();
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

        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

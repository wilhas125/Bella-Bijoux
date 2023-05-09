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
    public partial class FrmFucionario : Form
    {
        public FrmFucionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            #region //Botão cadastrar
            try
            {

                //1 Passo - receber os dados da tela no objeto model de cliente
                Funcionarios obj = new Funcionarios();


                obj.Nome = txtnome.Text;
                obj.Rg = masktxtrg.Text;
                obj.Cpf = masktxtcpf.Text;
                obj.Email = txtemail.Text;
                obj.Senha = txtSenha.Text;
                obj.Cargo = txtCargo.Text;
                obj.Nivel = cbNivel.Text;
                obj.Telefone = masktxttelefone.Text;
                obj.Celular = masktxtcelular.Text;
                obj.Cep = masktxtcep.Text;
                obj.Endereco = txtendereco.Text;
                obj.Numero = int.Parse(txtnumero.Text);
                obj.Complemento = txtcodigo.Text;
                obj.Bairro = txtbairro.Text;
                obj.Cidade = txtcidade.Text;
                obj.Estado = comboestado.Text;

               
                #endregion
                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FuncionarioDao dao = new FuncionarioDao();
                dao.cadastrarFuncionarios(obj);

                dgFuncionarios.DataSource = dao.listarFuncionarios();

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
                masktxtrg.Text = "";
                masktxtcpf.Text = "";
                txtemail.Text = "";
                txtSenha.Text ="";
                txtCargo.Text="";
                cbNivel.Text="";              
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCep_Click(object sender, EventArgs e)
        {

        }

        private void masktxtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbComplem_Click(object sender, EventArgs e)
        {

        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Funcionarios obj = new Funcionarios();
                obj.Nome = txtnome.Text;
                obj.Rg = masktxtrg.Text;
                obj.Cpf = masktxtcpf.Text;
                obj.Email = txtemail.Text;
                obj.Senha = txtSenha.Text;
                obj.Cargo = txtCargo.Text;
                obj.Nivel = cbNivel.Text;
                obj.Telefone = masktxttelefone.Text;
                obj.Celular = masktxtcelular.Text;
                obj.Cep = masktxtcep.Text;
                obj.Endereco = txtendereco.Text;
                obj.Numero = int.Parse(txtnumero.Text);
                obj.Complemento = txtcodigo.Text;
                obj.Bairro = txtbairro.Text;
                obj.Cidade = txtcidade.Text;
                obj.Estado = comboestado.Text;
                obj.Id = int.Parse(txtcodigo.Text);

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                FuncionarioDao dao = new FuncionarioDao();
                dao.alterarFucionario(obj);


                dgFuncionarios.DataSource = dao.listarFuncionarios();

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
                masktxtrg.Text = "";
                masktxtcpf.Text = "";
                txtemail.Text = "";
                txtSenha.Text = "";
                txtCargo.Text = "";
                cbNivel.Text = "";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão Excluir
                //1 Passo- criar o comando sql
                Funcionarios obj = new Funcionarios();
                obj.Id = int.Parse(txtcodigo.Text);

                //2º passo rxecutar o metodo excluirCliente
                FuncionarioDao dao = new FuncionarioDao();
                dao.excluir(obj);
                dgFuncionarios.DataSource = dao.listarFuncionarios();

                //MEtodos para limpar a tela de entrada de dados
                txtnome.Clear();
                masktxtrg.Text = "";
                masktxtcpf.Text = "";
                txtemail.Text = "";
                txtSenha.Text = "";
                txtCargo.Text = "";
                cbNivel.Text = "";
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            // Receber o nome do campo de texto

            string nome = "%" + txtPesquisa.Text + "%";

            //Criar o objeto ClienteDAO
            FuncionarioDao dao = new FuncionarioDao();

            dgFuncionarios.DataSource = dao.ConsultarFucionarioPorNome(nome);

            if (dgFuncionarios.Rows.Count == 0)
            {
                
                MessageBox.Show("Nenhum funcionario com este nome foi encontrado!!");
                dgFuncionarios.DataSource = dao.listarFuncionarios();
                
            }


        }

        private void btncusultar_Click(object sender, EventArgs e)
        {
            // Receber o nome do campo de texto

            string nome = "%" + txtPesquisa.Text + "%";

            //Criar o objeto ClienteDAO
            FuncionarioDao dao = new FuncionarioDao();

            dgFuncionarios.DataSource = dao.ListarFucionariosPorNome(nome);

            if (dgFuncionarios.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!!");
                dgFuncionarios.DataSource = dao.listarFuncionarios();
            }
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

        private void dgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //Pegando os dados da linha selecionada
            txtcodigo.Text = dgFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgFuncionarios.CurrentRow.Cells[1].Value.ToString();
            masktxtrg.Text = dgFuncionarios.CurrentRow.Cells[2].Value.ToString();
            masktxtcpf.Text = dgFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgFuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtCargo.Text = dgFuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = dgFuncionarios.CurrentRow.Cells[7].Value.ToString();
            masktxttelefone.Text = dgFuncionarios.CurrentRow.Cells[8].Value.ToString();
            masktxtcelular.Text = dgFuncionarios.CurrentRow.Cells[9].Value.ToString();
            masktxtcep.Text = dgFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = dgFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = dgFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = dgFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = dgFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = dgFuncionarios.CurrentRow.Cells[15].Value.ToString();
            comboestado.Text = dgFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            
            FuncionarioDao dao = new FuncionarioDao();
            dgFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void FrmFucionario_Load(object sender, EventArgs e)
        {
            FuncionarioDao dao = new FuncionarioDao();
            dgFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void txtcodigo_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace agenSystem
{
    public partial class frm_cadastroFuncionario : Form
    {
        public frm_cadastroFuncionario()
        {
            InitializeComponent();
        }

        void limparFormulario()
        {
            txtNomeFun.Text = "";
            mkCpfFun.Text = "";
            txtFuncaoFun.Text = "";
            txtEmailFun.Text = "";
            mkNascimentoFun.Text = "";
            mkCepFun.Text = "";
            txtEnderecoFun.Text = "";
            txtComplementoFun.Text = "";
            txtBairroFun.Text = "";
            txtCidadeFun.Text = "";
            cbEstadoFun.Text = "";
            mkTelefoneFun.Text = "";
            mkCelularFun.Text = "";
            txtLoginFun.Text = "";
            txtSenhaFun.Text = "";
        }

        private void btSalvarFun_Click(object sender, EventArgs e)
        {
            if (txtNomeFun.Text != "" && mkCpfFun.Text != "" && txtFuncaoFun.Text != "")
            {
                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoInsert = "INSERT INTO Funcionario (nome,cpffuncionario,funcao,email,nascimento,cep,endereco,complemento,bairro,cidade,estado,telefone,celular,login,senha)" +
                    "values(@nome,@cpffuncionario,@funcao,@email,@nascimento,@cep,@endereco,@complemento,@bairro,@cidade,@estado,@telefone,@celular,@login,@senha)";
                string comandoSelect = "select * from Funcionario where cpffuncionario=@cpffuncionario";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoInsert, conexao);
                OleDbCommand comandoConsultaBanco = new OleDbCommand(comandoSelect, conexao);

                // ADICIONANDO VALORES NO BANCO DE DADOS
                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeFun.Text;
                comando.Parameters.Add("@cpffuncionario", OleDbType.VarChar).Value = mkCpfFun.Text;
                comando.Parameters.Add("@funcao", OleDbType.VarChar).Value = txtFuncaoFun.Text;
                comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmailFun.Text;
                comando.Parameters.Add("@nascimento", OleDbType.VarChar).Value = mkNascimentoFun.Text;
                comando.Parameters.Add("@cep", OleDbType.VarChar).Value = mkCepFun.Text;
                comando.Parameters.Add("@endereco", OleDbType.VarChar).Value = txtEnderecoFun.Text;
                comando.Parameters.Add("@complemento", OleDbType.VarChar).Value = txtComplementoFun.Text;
                comando.Parameters.Add("@bairro", OleDbType.VarChar).Value = txtBairroFun.Text;
                comando.Parameters.Add("@cidade", OleDbType.VarChar).Value = txtCidadeFun.Text;
                comando.Parameters.Add("@estado", OleDbType.VarChar).Value = cbEstadoFun.Text;
                comando.Parameters.Add("@telefone", OleDbType.VarChar).Value = mkTelefoneFun.Text;
                comando.Parameters.Add("@celular", OleDbType.VarChar).Value = mkCelularFun.Text;
                comando.Parameters.Add("@login", OleDbType.VarChar).Value = txtLoginFun.Text;
                comando.Parameters.Add("@senha", OleDbType.VarChar).Value = txtSenhaFun.Text;

                try
                {

                    if (mkCpfFun.Text == "")
                    {
                        throw new Exception("Não é possivel cadastrar o campo CPF vazio!");
                    }
                
                    conexao.Open();

                    // VALIDANDO SE O CPF POSSUI CADASTRO
                    comandoConsultaBanco.Parameters.Add("@cpffuncionario", OleDbType.VarChar).Value = mkCpfFun.Text;
                    OleDbDataReader cs = comandoConsultaBanco.ExecuteReader();

                    if (cs.HasRows == true)
                    {
                        throw new Exception("CPF já cadastrado!");
                    }
                    else
                    {
                        // CADASTRANDO NOVO FUNCIONÁRIO
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();
                }

                limparFormulario();
                carregarGrid();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }

        private void btSairFun_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        void renomearCampo()
        {
            dgvListaFun.Columns[0].HeaderText = "Codigo";
            dgvListaFun.Columns[1].HeaderText = "Nome";
            dgvListaFun.Columns[2].HeaderText = "CPF/CNPJ";
            dgvListaFun.Columns[3].HeaderText = "Função";
            dgvListaFun.Columns[4].HeaderText = "E-mail";
            dgvListaFun.Columns[5].HeaderText = "Nascimento";
            dgvListaFun.Columns[6].HeaderText = "CEP";
            dgvListaFun.Columns[7].HeaderText = "Endereço";
            dgvListaFun.Columns[8].HeaderText = "Complemento";
            dgvListaFun.Columns[9].HeaderText = "Bairro";
            dgvListaFun.Columns[10].HeaderText = "Cidade";
            dgvListaFun.Columns[11].HeaderText = "Estado";
            dgvListaFun.Columns[12].HeaderText = "Telefone";
            dgvListaFun.Columns[13].HeaderText = "Celular";            
        }

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS AGENDAMENTOS PARA A DATA SELECIONADA
        void carregarGrid()
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectGrid = "select " +
                "codigoFuncionario," +
                "nome," +
                "cpfFuncionario," +
                "funcao," +
                "email," +
                "nascimento," +
                "cep," +
                "endereco," +
                "complemento," +
                "bairro," +
                "cidade," +
                "estado," +
                "telefone," +
                "celular " +
                "from Funcionario order by nome";
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);

            try
            {
                conexao.Open();
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvListaFun.DataSource = carregandoDataGridView;
                renomearCampo();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void frm_cadastroFuncionario_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
    }
}

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
    public partial class frm_cadastroServico : Form
    {
        public frm_cadastroServico()
        {
            InitializeComponent();
        }

        // LIMPAR CAMPOS DO FORMULÁRIO
        void limparFormulario()
        {
            txtNomeServico.Text = "";
            txtDescricaoServico.Text = "";
            txtDificuldadeServico.Text = "";
            txtDuracaoServico.Text = "";
        }


        private void btSalvarServico_Click(object sender, EventArgs e)
        {
            //VALIDAÇÃO DOS CAMPOS
            if (txtNomeServico.Text != "" && txtDificuldadeServico.Text != "" && txtDuracaoServico.Text != "")
            {            

            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoInsert = "INSERT INTO Servico (nome,descricao,duracao,dificuldade)" +
                "values(@nome,@descricao,@duracao,@dificuldade)";
            string comandoSelect = "select * from Servico where nome=@nome";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoInsert, conexao);
            OleDbCommand comandoConsultaBanco = new OleDbCommand(comandoSelect, conexao);

            comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeServico.Text;
            comando.Parameters.Add("@descricao", OleDbType.VarChar).Value = txtDescricaoServico.Text;
            comando.Parameters.Add("@duracao", OleDbType.VarChar).Value = txtDuracaoServico.Text;
            comando.Parameters.Add("@dificuldade", OleDbType.VarChar).Value = txtDificuldadeServico.Text;

            try
            {

                if (txtNomeServico.Text == "")
                {
                    throw new Exception("Não é possivel cadastrar o campo nome vazio!");
                }
                
                conexao.Open();

                //VALIDANDO SE O NOME DO SERVIÇO JA ESTA CADASTRADO
                comandoConsultaBanco.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeServico.Text;
                OleDbDataReader cs = comandoConsultaBanco.ExecuteReader();

                if (cs.HasRows == true)
                {
                    throw new Exception("Nome de serviço já cadastrado!");
                }
                else
                {
                    // CADASTRANDO NOVO SERVIÇO
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Serviço cadastrado com sucesso!");
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

        private void btSairServico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        void renomearCampo()
        {
            dgvListaServico.Columns[0].HeaderText = "Codigo";
            dgvListaServico.Columns[1].HeaderText = "Nome";
            dgvListaServico.Columns[2].HeaderText = "Descrição";
            dgvListaServico.Columns[3].HeaderText = "Duração";
            dgvListaServico.Columns[4].HeaderText = "Dificuldade";                        
        }

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS AGENDAMENTOS PARA A DATA SELECIONADA
        void carregarGrid()
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectGrid = "select * from Servico order by nome";
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);

            try
            {
                conexao.Open();
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvListaServico.DataSource = carregandoDataGridView;
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

        private void frm_cadastroServico_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
    }
}

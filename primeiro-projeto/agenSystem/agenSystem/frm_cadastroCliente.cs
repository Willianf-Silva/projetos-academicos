using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace agenSystem
{
    public partial class frm_cadastroCliente : Form
    {
        public frm_cadastroCliente()
        {
            InitializeComponent();
        }

        // PROCEDIMENTO PARA LIMPAR OS CAMPOS DO FORMULÁRIO
        void limparFormulario()
        {
            txtNomeCli.Text = "";
            mkCNPJeCPFCli.Text = "";
            mkCepCli.Text = "";
            txtEnderecoCli.Text = "";
            txtComplementoCli.Text = "";
            txtBairroCli.Text = "";
            txtCidadeCli.Text = "";
            cbEstadoCli.Text = "";            
            mktTelefoneCli.Text = "";
            mkNascimentoCli.Text = "";
            cbGeneroCli.Text = "";
            cbEstadocivilCli.Text = "";
            txtProfissaoCli.Text = "";
            txtEmailCli.Text = "";
            txtResponsavelCli.Text = "";
            txtConvenioCli.Text = "";
            txtObservacoesCli.Text = "";
            txtAvisoCli.Text = "";

        }

        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        void renomearCampo()
        {
            dgvListaCli.Columns[0].HeaderText = "Codigo";
            dgvListaCli.Columns[1].HeaderText = "Nome";
            dgvListaCli.Columns[2].HeaderText = "CPF/CNPJ";
            dgvListaCli.Columns[3].HeaderText = "CEP";
            dgvListaCli.Columns[4].HeaderText = "Endereço";
            dgvListaCli.Columns[5].HeaderText = "Complemento";
            dgvListaCli.Columns[6].HeaderText = "Bairro";
            dgvListaCli.Columns[7].HeaderText = "Cidade";
            dgvListaCli.Columns[8].HeaderText = "Estado";
            dgvListaCli.Columns[9].HeaderText = "Telefone";
            dgvListaCli.Columns[10].HeaderText = "Nascimento";
            dgvListaCli.Columns[11].HeaderText = "Genero";
            dgvListaCli.Columns[12].HeaderText = "Estado Civil";
            dgvListaCli.Columns[13].HeaderText = "Profissão";
            dgvListaCli.Columns[14].HeaderText = "E-mail";
            dgvListaCli.Columns[15].HeaderText = "Responsável";
            dgvListaCli.Columns[16].HeaderText = "Convênio";
            dgvListaCli.Columns[17].HeaderText = "Observações";
            dgvListaCli.Columns[18].HeaderText = "Aviso";
        }

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS AGENDAMENTOS PARA A DATA SELECIONADA
        void carregarGrid()
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectGrid = "select * from Cliente order by nome";
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);

            try
            {
                conexao.Open();
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvListaCli.DataSource = carregandoDataGridView;
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

        private void btSalvarCli_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text != "" && mkCNPJeCPFCli.Text != "" && mktTelefoneCli.Text != "")
            {

                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoInsert = "INSERT INTO Cliente (nome,cpfoucnpj,cep,endereco,complemento,bairro,cidade,estado,telefone,nascimento,genero,estadoCivil,profissao,email,responsavel,convenio,observacoes,aviso)" +
                    "values(@nome,@cpfoucnpj,@cep,@endereco,@complemento,@bairro,@cidade,@estado,@telefone,@nascimento,@genero,@estadoCivil,@profissao,@email,@responsavel,@convenio,@observacoes,@aviso)";
                string comandoSelect = "select * from Cliente where cpfoucnpj=@cpfoucnpj";

                mktTelefoneCli.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoInsert, conexao);
                OleDbCommand comandoConsultaBanco = new OleDbCommand(comandoSelect, conexao);

                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeCli.Text;
                comando.Parameters.Add("@cpfoucnpj", OleDbType.VarChar).Value = mkCNPJeCPFCli.Text;
                comando.Parameters.Add("@cep", OleDbType.VarChar).Value = mkCepCli.Text;
                comando.Parameters.Add("@endereco", OleDbType.VarChar).Value = txtEnderecoCli.Text;
                comando.Parameters.Add("@complemento", OleDbType.VarChar).Value = txtComplementoCli.Text;
                comando.Parameters.Add("@bairro", OleDbType.VarChar).Value = txtBairroCli.Text;
                comando.Parameters.Add("@cidade", OleDbType.VarChar).Value = txtCidadeCli.Text;
                comando.Parameters.Add("@estado", OleDbType.VarChar).Value = cbEstadoCli.Text;
                comando.Parameters.Add("@telefone", OleDbType.VarChar).Value = mktTelefoneCli.Text;
                comando.Parameters.Add("@nascimento", OleDbType.VarChar).Value = mkNascimentoCli.Text;
                comando.Parameters.Add("@genero", OleDbType.VarChar).Value = cbGeneroCli.Text;
                comando.Parameters.Add("@estadoCivil", OleDbType.VarChar).Value = cbEstadocivilCli.Text;
                comando.Parameters.Add("@profissao", OleDbType.VarChar).Value = txtProfissaoCli.Text;
                comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmailCli.Text;
                comando.Parameters.Add("@responsavel", OleDbType.VarChar).Value = txtResponsavelCli.Text;
                comando.Parameters.Add("@convenio", OleDbType.VarChar).Value = txtConvenioCli.Text;
                comando.Parameters.Add("@observacoes", OleDbType.VarChar).Value = txtObservacoesCli.Text;
                comando.Parameters.Add("@aviso", OleDbType.VarChar).Value = txtAvisoCli.Text;

                try
                {

                    if (mkCNPJeCPFCli.Text == "")
                    {
                        throw new Exception("Não é possivel cadastrar o campo CPF ou CNPJ vazio!");
                    }

                    conexao.Open();

                    // VERIFICANDO SE O CPF JA POSSUI CADASTRO
                    comandoConsultaBanco.Parameters.Add("@cpfoucnpj", OleDbType.VarChar).Value = mkCNPJeCPFCli.Text;
                    OleDbDataReader cs = comandoConsultaBanco.ExecuteReader();

                    if (cs.HasRows == true)
                    {
                        throw new Exception("CPF ou CNPJ já cadastrado!");
                    }
                    else
                    {
                        // CADASTRANDO NOVO USUÁRIO
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!");
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
                     

        private void frm_cadastroCliente_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void btSairCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

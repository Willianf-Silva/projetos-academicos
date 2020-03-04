using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace agenSystem
{
    public partial class frm_cadastroAgendamento : Form
    {
        public frm_cadastroAgendamento()
        {
            InitializeComponent();
        }

        private void frm_cadastroAgendamento_Load(object sender, EventArgs e)
        {
            // BLOQUEANDO OS CAMPOS E BOTÕES

            dtpDataAgendamentoCliAgen.Enabled = true;
            mkCpfFunAgen.ReadOnly = true;
            txtCodigoFunAgen.ReadOnly = true;
            txtNomeFunAgen.ReadOnly = false;
            txtFuncaoFunAgen.ReadOnly = true;
            dgvAgendamentoCli.Enabled = true;
            mkCNPJeCPFCliAgen.ReadOnly = true;
            txtCodigoCliAgen.ReadOnly = true;
            txtNomeCliAgen.ReadOnly = false;
            mkCepCliAgen.Enabled = false;
            txtEnderecoCliAgen.ReadOnly = true;
            txtComplementoCliAgen.ReadOnly = true;
            txtBairroCliAgen.ReadOnly = true;
            txtCidadeCliAgen.ReadOnly = true;
            cbEstadoCliAgen.Enabled = false;
            mktTelefoneCliAgen.Enabled = false;
            txtProfissaoCliAgen.ReadOnly = true;
            txtEmailCliAgen.ReadOnly = true;
            txtResponsavelCliAgen.ReadOnly = true;
            txtConvenioCliAgen.ReadOnly = true;
            txtCodServicoCliAgen.ReadOnly = true;
            txtNomeServicoCliAgen.ReadOnly = false;
            txtDuracaoServicoCliAgen.ReadOnly = true;
            txtDificuldadeServicoCliAgen.ReadOnly = true;
            cbHorarioAgendamentoCliAgen.Enabled = true;
            cbHorarioAgendamentoCliAgen.Enabled = true;
            cbHorarioAgendamentoCliAgen.Enabled = true;
            cbHorarioAgendamentoCliAgen.Enabled = true;
            btSalvarAgendamento.Enabled = true;
            btSairAgendamento.Enabled = true;
            btVerificarAgendamento.Enabled = true;



            // ADICIONANDO HORAS NO CAMPO HORÁRIO
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(00); _time < time.AddHours(24); _time = _time.AddMinutes(30)) // Adiciona 30 minutos no combobox
            {
                cbHorarioAgendamentoCliAgen.Items.Add(_time.ToShortTimeString());
            }


        }

        private void btSairAgendamento_Click(object sender, EventArgs e) => this.Close();

        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        void renomearCampo()
        {
            dgvAgendamentoCli.Columns[0].HeaderText = "Codigo";
            dgvAgendamentoCli.Columns[1].HeaderText = "Data";
            dgvAgendamentoCli.Columns[2].HeaderText = "Hora";
            dgvAgendamentoCli.Columns[3].HeaderText = "Nome Cliente";
            dgvAgendamentoCli.Columns[4].HeaderText = "CPF / CNPJ";
            dgvAgendamentoCli.Columns[5].HeaderText = "Telefone";
            dgvAgendamentoCli.Columns[6].HeaderText = "Convênio";
            dgvAgendamentoCli.Columns[7].HeaderText = "Observações";
            dgvAgendamentoCli.Columns[8].HeaderText = "Aviso";
            dgvAgendamentoCli.Columns[9].HeaderText = "Nome Serviço";
            dgvAgendamentoCli.Columns[10].HeaderText = "Duração (Minutos)";
            
            /*
            int tamanho = 100;
            dgvAgendamentoCli.Columns[0].Width = tamanho;
            dgvAgendamentoCli.Columns[1].Width = tamanho;
            dgvAgendamentoCli.Columns[2].Width = tamanho;
            dgvAgendamentoCli.Columns[3].Width = tamanho;
            dgvAgendamentoCli.Columns[4].Width = tamanho;
            dgvAgendamentoCli.Columns[5].Width = tamanho;
            dgvAgendamentoCli.Columns[6].Width = tamanho;
            dgvAgendamentoCli.Columns[7].Width = tamanho;
            dgvAgendamentoCli.Columns[8].Width = tamanho;
            dgvAgendamentoCli.Columns[9].Width = tamanho;
            dgvAgendamentoCli.Columns[10].Width = tamanho;            
            */
        }

        private void btVerificarAgendamento_Click(object sender, EventArgs e)
        {

            // DECLARANDO AS VARIÁVEIS NECESSÁRIAS            
            string dataAgendamento = Convert.ToString(Convert.ToDateTime(dtpDataAgendamentoCliAgen.Value).ToShortDateString());
            string nomeFuncionario = txtNomeFunAgen.Text;            
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectFuncionario = "select * from Funcionario where nome like '" + nomeFuncionario + "%'";
            int referenciaAgendamento = dtpDataAgendamentoCliAgen.Value.Day + dtpDataAgendamentoCliAgen.Value.Month + dtpDataAgendamentoCliAgen.Value.Year;
            
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelectFuncionario, conexao);
            

            try
            {
                // VALIDANDO SE FOI PREENCHIDO O CAMPO CPF FUNCIONARIO
                if (txtNomeFunAgen.Text == "")
                {
                    txtCodigoFunAgen.Text = "";
                    mkCpfFunAgen.Text = "";
                    txtFuncaoFunAgen.Text = "";

                    throw new Exception("Digite o nome do funcionário para consultar");
                }

                conexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();

                // VERIFICANDO SE O FUNCIONARIO POSSUI CADASTRO
                if (cs.HasRows == false)
                {
                    txtCodigoFunAgen.Text = "";
                    mkCpfFunAgen.Text = "";
                    txtFuncaoFunAgen.Text = "";

                    throw new Exception("Não existe cadastro para esse funcionário");
                }
                else // PREENCHENDO OS CAMPOS FUNCIONARIO
                {
                    cs.Read();
                    txtCodigoFunAgen.Text = Convert.ToString(cs["codigoFuncionario"]);
                    txtNomeFunAgen.Text = Convert.ToString(cs["nome"]);
                    txtFuncaoFunAgen.Text = Convert.ToString(cs["funcao"]);
                    mkCpfFunAgen.Text = Convert.ToString(cs["cpfFuncionario"]);
                }

                int codFuncionario = Convert.ToInt32(txtCodigoFunAgen.Text);
                
                // PREENCHENDO DATAGRIDVIEW
                string comandoSelectGrid = "select Agendamento.codigoAgendamento, " +
                                            "Agendamento.dataAgendamento, " +
                                            "Agendamento.horaAgendamento, " +                                            
                                            "Cliente.nome, " +
                                            "Cliente.cpfoucnpj, " +
                                            "Cliente.telefone, " +
                                            "Cliente.convenio, " +
                                            "Cliente.observacoes, " +
                                            "Cliente.aviso, " +                                            
                                            "Servico.nome, " +
                                            "Servico.duracao " +
                                            "from (((Agendamento " +
                                            "inner join Funcionario " +
                                            "on Agendamento.codigoFuncionario = Funcionario.codigoFuncionario) " +
                                            "inner join Cliente " +
                                            "on Agendamento.codigoCliente = Cliente.codigo) " +
                                            "inner join Servico " +
                                            "on Agendamento.codigoServico = Servico.codigoServico)" +
                                            "where Agendamento.codigoFuncionario = " + codFuncionario +
                                            " and Agendamento.referenciaAgendamento = " + referenciaAgendamento +
                                            " order by Agendamento.dataAgendamento, Agendamento.horaAgendamento";
                //MessageBox.Show(comandoSelectGrid); // analisando o comandoSelectGrid

                OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);

                try
                {
                    //conexao.Open();

                    // PREENCHER O DATA GRID VIEW COM OS AGENDAMENTOS
                    DataTable carregandoDataGridView = new DataTable();
                    OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                    carregandoDataGridView.Load(preencherGrid);
                    dgvAgendamentoCli.DataSource = carregandoDataGridView;
                    renomearCampo();
                }

                // EM CASO DE ERRO É EXIBIDO A MENSAGEM CONTENDO O ERRO
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }

                // FECHA O BANCO DE DADOS
                finally
                {
                    conexao.Close();                    
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


        }

        private void btPesquisarServicoAgendamento_Click(object sender, EventArgs e)
        {
            string nomePesquisaServico = txtNomeServicoCliAgen.Text;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectServico = "select * from Servico where nome like '" + nomePesquisaServico + "%'";
            

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelectServico, conexao);
            

            try
            {
                if (txtNomeServicoCliAgen.Text == "")
                {
                    txtCodServicoCliAgen.Text = "";
                    txtDuracaoServicoCliAgen.Text = "";
                    txtDificuldadeServicoCliAgen.Text = "";

                    throw new Exception("Digite o nome do serviço para consultar");
                }

                conexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == false)
                {
                    txtCodServicoCliAgen.Text = "";
                    txtDuracaoServicoCliAgen.Text = "";
                    txtDificuldadeServicoCliAgen.Text = "";

                    throw new Exception("Não existe cadastro para esse serviço");
                }
                else
                {
                    cs.Read();
                    txtCodServicoCliAgen.Text = Convert.ToString(cs["codigoServico"]);
                    txtDuracaoServicoCliAgen.Text = Convert.ToString(cs["duracao"]);
                    txtDificuldadeServicoCliAgen.Text = Convert.ToString(cs["dificuldade"]);
                    txtNomeServicoCliAgen.Text = Convert.ToString(cs["nome"]);
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
        }

        private void btPesquisarClienteAgendamento_Click_1(object sender, EventArgs e)
        {
            string nomePesquisaCliente = txtNomeCliAgen.Text;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectCliente = "select * from Cliente where nome like '" + nomePesquisaCliente + "%'";
            

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelectCliente, conexao);
            

            try
            {
                // VALIDANDO SE FOI PREENCHIDO O CAMPO CPF FUNCIONARIO
                if (nomePesquisaCliente == "")
                {
                    mkCNPJeCPFCliAgen.Text = "";
                    txtCodigoCliAgen.Text = "";
                    txtNomeCliAgen.Text = "";
                    mkCepCliAgen.Text = "";
                    txtEnderecoCliAgen.Text = "";
                    txtComplementoCliAgen.Text = "";
                    txtBairroCliAgen.Text = "";
                    txtCidadeCliAgen.Text = "";
                    cbEstadoCliAgen.Text = "";
                    mktTelefoneCliAgen.Text = "";
                    txtProfissaoCliAgen.Text = "";
                    txtEmailCliAgen.Text = "";
                    txtResponsavelCliAgen.Text = "";
                    txtConvenioCliAgen.Text = "";

                    throw new Exception("Digite o nome do cliente para consultar");
                }

                conexao.Open();
                OleDbDataReader cs = comando.ExecuteReader();

                // VERIFICANDO SE O FUNCIONARIO POSSUI CADASTRO
                if (cs.HasRows == false)
                {
                    mkCNPJeCPFCliAgen.Text = "";
                    txtCodigoCliAgen.Text = "";
                    txtNomeCliAgen.Text = "";
                    mkCepCliAgen.Text = "";
                    txtEnderecoCliAgen.Text = "";
                    txtComplementoCliAgen.Text = "";
                    txtBairroCliAgen.Text = "";
                    txtCidadeCliAgen.Text = "";
                    cbEstadoCliAgen.Text = "";
                    mktTelefoneCliAgen.Text = "";
                    txtProfissaoCliAgen.Text = "";
                    txtEmailCliAgen.Text = "";
                    txtResponsavelCliAgen.Text = "";
                    txtConvenioCliAgen.Text = "";

                    throw new Exception("Não existe cadastro para esse cliente");
                }
                else // PREENCHENDO OS CAMPOS FUNCIONARIO
                {
                    cs.Read();
                    mkCNPJeCPFCliAgen.Text = Convert.ToString(cs["cpfoucnpj"]);
                    txtNomeCliAgen.Text = Convert.ToString(cs["nome"]);
                    mkCepCliAgen.Text = Convert.ToString(cs["cep"]);
                    txtEnderecoCliAgen.Text = Convert.ToString(cs["endereco"]);
                    txtComplementoCliAgen.Text = Convert.ToString(cs["complemento"]);
                    txtBairroCliAgen.Text = Convert.ToString(cs["bairro"]);
                    txtCidadeCliAgen.Text = Convert.ToString(cs["cidade"]);
                    cbEstadoCliAgen.Text = Convert.ToString(cs["estado"]);
                    mktTelefoneCliAgen.Text = Convert.ToString(cs["telefone"]);
                    txtProfissaoCliAgen.Text = Convert.ToString(cs["profissao"]);
                    txtEmailCliAgen.Text = Convert.ToString(cs["email"]);
                    txtResponsavelCliAgen.Text = Convert.ToString(cs["responsavel"]);
                    txtConvenioCliAgen.Text = Convert.ToString(cs["convenio"]);
                    txtCodigoCliAgen.Text = Convert.ToString(cs["codigo"]);
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
        }

        private void btSalvarAgendamento_Click(object sender, EventArgs e)
        {
            if (dtpDataAgendamentoCliAgen.Text != "" && txtNomeFunAgen.Text != "" && cbHorarioAgendamentoCliAgen.Text != "" && txtNomeServicoCliAgen.Text != "" && txtNomeCliAgen.Text != "")
            {
                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                int referenciaAgendamento = dtpDataAgendamentoCliAgen.Value.Day + dtpDataAgendamentoCliAgen.Value.Month + dtpDataAgendamentoCliAgen.Value.Year;
                string dataSelecionada = Convert.ToString(Convert.ToDateTime(dtpDataAgendamentoCliAgen.Value).ToShortDateString());
                string comandoInsert = "INSERT INTO Agendamento (codigoFuncionario,codigoCliente,codigoServico,dataAgendamento,horaAgendamento,referenciaAgendamento)" +
                    "values(@codigoFuncionario,@codigoCliente,@codigoServico,@dataAgendamento,@horaAgendamento,@referenciaAgendamento)";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoInsert, conexao);

                comando.Parameters.Add("@codigoFuncionario", OleDbType.Integer).Value = Convert.ToInt32(txtCodigoFunAgen.Text);
                comando.Parameters.Add("@codigoCliente", OleDbType.Integer).Value = Convert.ToInt32(txtCodigoCliAgen.Text);
                comando.Parameters.Add("@codigoServico", OleDbType.Integer).Value = Convert.ToInt32(txtCodServicoCliAgen.Text);
                comando.Parameters.Add("@dataAgendamento", OleDbType.VarChar).Value = dataSelecionada;
                comando.Parameters.Add("@horaAgendamento", OleDbType.VarChar).Value = cbHorarioAgendamentoCliAgen.Text;
                comando.Parameters.Add("@referenciaAgendamento", OleDbType.Integer).Value = referenciaAgendamento;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Agendamento cadastrado com sucesso!");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenSystem
{
    public partial class frm_alterarAgendamento : Form
    {
        public frm_alterarAgendamento()
        {
            InitializeComponent();
        }

        private void btSairAlterarAgendamento_Click(object sender, EventArgs e) => this.Close();

        private void btSalvarAlterarAgendamento_Click(object sender, EventArgs e)
        {

            if (dtpDataAlterarAgendamento.Text != "" && cbHorarioAlterarAgendamento.Text != "" && txtFuncionarioAlterarAgendamento.Text != "" && txtClienteAlterarAgendamento.Text != "" && txtServicoAlterarAgendamento.Text != "")
            {
                int codigoFun = Convert.ToInt32(codigo_Fun(txtFuncionarioAlterarAgendamento.Text));
                int codServico = Convert.ToInt32(codigo_Servico(txtServicoAlterarAgendamento.Text));
                int referenciaAgendamento = dtpDataAlterarAgendamento.Value.Day + dtpDataAlterarAgendamento.Value.Month + dtpDataAlterarAgendamento.Value.Year;
                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoUpdate = "update Agendamento " +
                                        "set dataAgendamento=@dataAgendamento,horaAgendamento=@horaAgendamento,codigoFuncionario=@codigoFuncionario,codigoServico=@codigoServico,referenciaAgendamento=@referenciaAgendamento " +
                                        "where codigoAgendamento=@codigoAgendamento";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoUpdate, conexao);


                comando.Parameters.Add("@dataAgendamento", OleDbType.VarChar).Value = Convert.ToString(Convert.ToDateTime(dtpDataAlterarAgendamento.Value).ToShortDateString());
                comando.Parameters.Add("@horaAgendamento", OleDbType.VarChar).Value = cbHorarioAlterarAgendamento.Text;
                comando.Parameters.Add("@codigoFuncionario", OleDbType.Integer).Value = codigoFun;
                comando.Parameters.Add("@codigoServico", OleDbType.Integer).Value = codServico;
                comando.Parameters.Add("@referenciaAgendamento", OleDbType.Integer).Value = referenciaAgendamento;
                comando.Parameters.Add("@codigoAgendamento", OleDbType.Integer).Value = Convert.ToInt32(txtCodAlterarAgendamento.Text);


                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso!");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }
    

        // ADICIONANDO HORAS NO CAMPO HORÁRIO
        void preencherHorarioCombobox()
        {            
            DateTime time = DateTime.Today;
            for (DateTime _time = time.AddHours(00); _time < time.AddHours(24); _time = _time.AddMinutes(30)) // Adiciona 30 minutos no combobox
            {
                cbHorarioAlterarAgendamento.Items.Add(_time.ToShortTimeString());
            }
        }

        // METODO PARA HABILITAR CAMPOS DO FORMULARIO
        void habilitarCampos()
        {
            txtCodAlterarAgendamento.ReadOnly = true;
            dtpDataAlterarAgendamento.Enabled = true;
            cbHorarioAlterarAgendamento.Enabled = true;
            txtFuncionarioAlterarAgendamento.ReadOnly = false;
            txtFuncaoAlterarAgendamento.ReadOnly = true;
            txtClienteAlterarAgendamento.ReadOnly = true;
            mkCPFCNPJAlterarAgendamento.ReadOnly = true;
            mkTelefoneAlterarAgendamento.Enabled = false;
            txtConvenioAlterarAgendamento.ReadOnly = true;
            txtObservacoesAlterarAgendamento.ReadOnly = true;
            txtAvisoAlterarAgendamento.ReadOnly = true;
            txtServicoAlterarAgendamento.ReadOnly = false;
            txtDuracaoAlterarAgendamento.ReadOnly = true;
        }

        // METODO PARA DESABILITAR CAMPOS DO FORMULARIO
        void desabilitarCampos()
        {
            txtCodAlterarAgendamento.ReadOnly = false;
            dtpDataAlterarAgendamento.Enabled = false;
            cbHorarioAlterarAgendamento.Enabled = false;
            txtFuncionarioAlterarAgendamento.ReadOnly = true;
            txtFuncaoAlterarAgendamento.ReadOnly = true;
            txtClienteAlterarAgendamento.ReadOnly = true;
            mkCPFCNPJAlterarAgendamento.ReadOnly = true;
            mkTelefoneAlterarAgendamento.Enabled = false;
            txtConvenioAlterarAgendamento.ReadOnly = true;
            txtObservacoesAlterarAgendamento.ReadOnly = true;
            txtAvisoAlterarAgendamento.ReadOnly = true;
            txtServicoAlterarAgendamento.ReadOnly = true;
            txtDuracaoAlterarAgendamento.ReadOnly = true;
        }

        private void frm_alterarAgendamento_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
            preencherHorarioCombobox();
        }

        private void btPesquisarAgenAlterarAgendamento_Click(object sender, EventArgs e)
        {
            habilitarCampos();

            int codigoAgendamento = Convert.ToInt32(txtCodAlterarAgendamento.Text);
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select Agendamento.dataAgendamento, " +                                           
                                           "Agendamento.horaAgendamento, " +
                                           "Funcionario.nome, " +
                                           "Funcionario.funcao, " +
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
                                           "where Agendamento.codigoAgendamento = @codigo";// quando será utilizado uma variável na string select é necessário concatenar

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);

            comando.Parameters.Add("@codigo", OleDbType.VarChar).Value = codigoAgendamento;

            try
            {
                if (txtCodAlterarAgendamento.Text == "")
                {
                    throw new Exception("Digite o código do agendamento para consultar");
                }

                conexao.Open();

                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == false)
                {
                    throw new Exception("Não existe cadastro para esse agendamento");
                }
                else
                {
                    cs.Read();

                    dtpDataAlterarAgendamento.Text = Convert.ToString(cs["dataAgendamento"]);
                    cbHorarioAlterarAgendamento.Text = Convert.ToString(cs["horaAgendamento"]);
                    txtFuncionarioAlterarAgendamento.Text = Convert.ToString(cs["Funcionario.nome"]);
                    txtFuncaoAlterarAgendamento.Text = Convert.ToString(cs["funcao"]);
                    txtClienteAlterarAgendamento.Text = Convert.ToString(cs["Cliente.nome"]);
                    mkCPFCNPJAlterarAgendamento.Text = Convert.ToString(cs["cpfoucnpj"]);
                    mkTelefoneAlterarAgendamento.Text = Convert.ToString(cs["telefone"]);
                    txtConvenioAlterarAgendamento.Text = Convert.ToString(cs["convenio"]);
                    txtObservacoesAlterarAgendamento.Text = Convert.ToString(cs["observacoes"]);
                    txtAvisoAlterarAgendamento.Text = Convert.ToString(cs["aviso"]);
                    txtServicoAlterarAgendamento.Text = Convert.ToString(cs["Servico.nome"]);
                    txtDuracaoAlterarAgendamento.Text = Convert.ToString(cs["duracao"]);
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


        // FUNÇÃO PARA ENCONTRAR O CÓDIGO DO SERVIÇO
        public string codigo_Servico(string nomeServico)
        {
            string codigoServico = "";
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectFuncionario = "select codigoServico " +
                                           "from Servico " +
                                           "where nome like '" + nomeServico + "%'";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelectFuncionario, conexao);

            try
            {
                if (nomeServico == "")
                {
                    throw new Exception("Digite o nome do serviço para atualizar");
                }

                conexao.Open();

                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == false)
                {
                    throw new Exception("Não existe cadastro para esse serviço");
                }
                else
                {
                    cs.Read();
                    codigoServico = Convert.ToString(cs["codigoServico"]);
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

            return codigoServico;
        }

        // FUNÇÃO PARA ENCONTRAR O CÓDIGO DO FUNCIONARIO
        public string codigo_Fun(string nomeFun)
        {
            string codigoFuncionario = "";
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectFuncionario = "select codigoFuncionario " +
                                           "from Funcionario " +
                                           "where nome like '" + nomeFun + "%'";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelectFuncionario, conexao);

            try
            {
                if (nomeFun == "")
                {
                    throw new Exception("Digite o nome do funcionário para consultar");
                }

                conexao.Open();

                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == false)
                {
                    throw new Exception("Não existe cadastro para esse funcionário");
                }
                else
                {
                    cs.Read();
                    codigoFuncionario = Convert.ToString(cs["codigoFuncionario"]);                    
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

            return codigoFuncionario;            
        }


        private void btAtualizarDadosAgenAlterarAgendamento_Click(object sender, EventArgs e)
        {
            int codigoFuncionario = Convert.ToInt32(codigo_Fun(txtFuncionarioAlterarAgendamento.Text));
            int codigoServico = Convert.ToInt32(codigo_Servico(txtServicoAlterarAgendamento.Text));

            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";

            string comandoSelectFuncionario = "select nome,funcao " +
                                           "from Funcionario " +
                                           "where codigoFuncionario = " + codigoFuncionario;

            string comandoSelectServico = "select nome,duracao " +
                                           "from Servico " +
                                           "where codigoServico = " + codigoServico;
                        
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comandoFuncionario = new OleDbCommand(comandoSelectFuncionario, conexao);
            OleDbCommand comandoServico = new OleDbCommand(comandoSelectServico, conexao);

            try
            {
                conexao.Open();
                OleDbDataReader consultaFuncionario = comandoFuncionario.ExecuteReader();
                consultaFuncionario.Read();
                txtFuncionarioAlterarAgendamento.Text = Convert.ToString(consultaFuncionario["nome"]);
                txtFuncaoAlterarAgendamento.Text = Convert.ToString(consultaFuncionario["funcao"]);

                OleDbDataReader consultaServico = comandoServico.ExecuteReader();
                consultaServico.Read();
                txtServicoAlterarAgendamento.Text = Convert.ToString(consultaServico["nome"]);
                txtDuracaoAlterarAgendamento.Text = Convert.ToString(consultaServico["duracao"]);
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

    }
}

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
    public partial class relatorio_agenda_periodo : Form
    {
        public relatorio_agenda_periodo()
        {
            InitializeComponent();
        }

        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        public void renomearCampo()
        {
            dgvRelatorioAgendaPeriodo.Columns[0].HeaderText = "Codigo";
            dgvRelatorioAgendaPeriodo.Columns[1].HeaderText = "Data";
            dgvRelatorioAgendaPeriodo.Columns[2].HeaderText = "Hora";
            dgvRelatorioAgendaPeriodo.Columns[3].HeaderText = "Funcionário";
            dgvRelatorioAgendaPeriodo.Columns[4].HeaderText = "Função";
            dgvRelatorioAgendaPeriodo.Columns[5].HeaderText = "Nome Cliente";
            dgvRelatorioAgendaPeriodo.Columns[6].HeaderText = "CPF / CNPJ";
            dgvRelatorioAgendaPeriodo.Columns[7].HeaderText = "Telefone";
            dgvRelatorioAgendaPeriodo.Columns[8].HeaderText = "Convênio";
            dgvRelatorioAgendaPeriodo.Columns[9].HeaderText = "Observações";
            dgvRelatorioAgendaPeriodo.Columns[10].HeaderText = "Aviso";
            dgvRelatorioAgendaPeriodo.Columns[11].HeaderText = "Nome Serviço";
            dgvRelatorioAgendaPeriodo.Columns[12].HeaderText = "Duração";


            dgvRelatorioAgendaPeriodo.Columns[0].Width = 50;

        }

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS TODOS OS AGENDAMENTOS DO PERIODO SELECIONADO
        void carregarGridGeral(int referenciaAgendamentoInicio, int referenciaAgendamentoFim)
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectGrid = "select Agendamento.codigoAgendamento, " +
                                           "Agendamento.dataAgendamento, " +
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
                                           "where Agendamento.referenciaAgendamento between " + referenciaAgendamentoInicio + " and " + referenciaAgendamentoFim + // quando será utilizado uma variável na string select é necessário concatenar                                                                                      
                                           " order by Agendamento.dataAgendamento, Agendamento.horaAgendamento";


            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);


            try
            {
                conexao.Open();
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvRelatorioAgendaPeriodo.DataSource = carregandoDataGridView;
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

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS AGENDAMENTOS DO PERIODO E FUNCIONÁRIO SELECIONADO
        void carregarGrid(int referenciaAgendamentoInicio, int referenciaAgendamentoFim, int codigoFuncionario)
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelectGrid = "select Agendamento.codigoAgendamento, " +
                                           "Agendamento.dataAgendamento, " +
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
                                           "where Agendamento.referenciaAgendamento between " + referenciaAgendamentoInicio + " and " + referenciaAgendamentoFim + // quando será utilizado uma variável na string select é necessário concatenar                                           
                                           " and  Agendamento.codigoFuncionario = " + codigoFuncionario + // obter o código do funcionário atraves de uma variável                                           
                                           " order by Agendamento.dataAgendamento, Agendamento.horaAgendamento";

            
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);


            try
            {
                conexao.Open();                                
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvRelatorioAgendaPeriodo.DataSource = carregandoDataGridView;
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

        private void btVerificarAgenRelatorioPeriodo_Click(object sender, EventArgs e)
        {
            string dataAgendamentoInicio = Convert.ToDateTime(dtpDataInicioRelatorioPeriodo.Value).ToShortDateString();
            int referenciaAgendamentoInicio = dtpDataInicioRelatorioPeriodo.Value.Day + dtpDataInicioRelatorioPeriodo.Value.Month + dtpDataInicioRelatorioPeriodo.Value.Year;
            string dataAgendamentoFim = Convert.ToDateTime(dtpDataFimRelatorioPeriodo.Value).ToShortDateString();
            int referenciaAgendamentoFim = dtpDataFimRelatorioPeriodo.Value.Day + dtpDataFimRelatorioPeriodo.Value.Month + dtpDataFimRelatorioPeriodo.Value.Year;

            if (txtFunRelatorioPeriodo.Text != "")
            {
                string nomeFun = txtFunRelatorioPeriodo.Text;
                string codigoFuncionario = codigo_Fun(nomeFun);                
                carregarGrid(referenciaAgendamentoInicio, referenciaAgendamentoFim, Convert.ToInt32(codigoFuncionario));
            }            
            else
                carregarGridGeral(referenciaAgendamentoInicio, referenciaAgendamentoFim);
        }

        private void btSairRelatorioPeriodo_Click(object sender, EventArgs e) => this.Close();

        private void btDeletarRelatorioPeriodo_Click(object sender, EventArgs e)
        {
            int referenciaAgendamentoInicio = dtpDataInicioRelatorioPeriodo.Value.Day + dtpDataInicioRelatorioPeriodo.Value.Month + dtpDataInicioRelatorioPeriodo.Value.Year;
            int referenciaAgendamentoFim = dtpDataFimRelatorioPeriodo.Value.Day + dtpDataFimRelatorioPeriodo.Value.Month + dtpDataFimRelatorioPeriodo.Value.Year;
            string nomeFun = txtFunRelatorioPeriodo.Text;
            string codigoFuncionario = codigo_Fun(nomeFun);
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoDelete = "delete from Agendamento where codigoAgendamento=@codSelecionado";

            if (Convert.ToInt32(dgvRelatorioAgendaPeriodo.CurrentRow.Index) >= 0) // Verificar uma forma dele não executar o comando se não for selecionado nenhum agendamento para deletar
            {
                int codSelecionado = Convert.ToInt32(dgvRelatorioAgendaPeriodo.CurrentRow.Cells[0].Value);

                if (MessageBox.Show("Deseja realmente excluir esse cadastro?",
                    "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    MessageBox.Show("Operação Cancelada !! ");
                }
                else
                {
                    OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                    OleDbCommand comando = new OleDbCommand(comandoDelete, conexao);
                    comando.Parameters.Add("@codSelecionado", OleDbType.VarChar).Value = codSelecionado;

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro excluido com sucesso!");
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                    finally
                    {
                        conexao.Close();
                    }

                    if (codigoFuncionario != "")
                        carregarGrid(referenciaAgendamentoInicio, referenciaAgendamentoFim, Convert.ToInt32(codigoFuncionario));
                }
            }
            else
            {
                MessageBox.Show("Selecione um agendamento para deletar.");
            }
        }        

        public int CodigoSelecionado(int codSelecionado)
        {
            return codSelecionado;
        }
        private void btEditarRelatorioPeriodo_Click(object sender, EventArgs e)
        {
            frm_alterarAgendamento EditarAgenda = new frm_alterarAgendamento();
            EditarAgenda.Show();
        }
    }    
}

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
    public partial class relatorio_Agenda_Dia : Form
    {
        public relatorio_Agenda_Dia()
        {
            InitializeComponent();
        }

        private void btSairRelatorioAgendaDia_Click(object sender, EventArgs e) => this.Close();
        
        // PROCEDIMENTO PARA RENOMEAR OS CAMPOS DO DATAGRIDVIEW
        void renomearCampo()
        {
            dgvRelatorioAgendaDia.Columns[0].HeaderText = "Codigo";
            dgvRelatorioAgendaDia.Columns[1].HeaderText = "Data";
            dgvRelatorioAgendaDia.Columns[2].HeaderText = "Hora";
            dgvRelatorioAgendaDia.Columns[3].HeaderText = "Funcionário";
            dgvRelatorioAgendaDia.Columns[4].HeaderText = "Função";
            dgvRelatorioAgendaDia.Columns[5].HeaderText = "Nome Cliente";
            dgvRelatorioAgendaDia.Columns[6].HeaderText = "CPF / CNPJ";
            dgvRelatorioAgendaDia.Columns[7].HeaderText = "Telefone";
            dgvRelatorioAgendaDia.Columns[8].HeaderText = "Convênio";
            dgvRelatorioAgendaDia.Columns[9].HeaderText = "Observações";
            dgvRelatorioAgendaDia.Columns[10].HeaderText = "Aviso";
            dgvRelatorioAgendaDia.Columns[11].HeaderText = "Nome Serviço";
            dgvRelatorioAgendaDia.Columns[12].HeaderText = "Duração (Minutos)";

            
            dgvRelatorioAgendaDia.Columns[0].Width = 50;

        }

        // PROCEDIMENTO PARA CARREGAR O DATAGRIDVIEW COM OS AGENDAMENTOS PARA A DATA SELECIONADA
        void carregarGrid(int referenciaAgendamento)
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
                                           "where Agendamento.referenciaAgendamento = " + referenciaAgendamento +// quando será utilizado uma variável na string select é necessário concatenar
                                           " order by Agendamento.dataAgendamento, Agendamento.horaAgendamento";
            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand preencherDataGridView = new OleDbCommand(comandoSelectGrid, conexao);

            try
            {
                conexao.Open();
                DataTable carregandoDataGridView = new DataTable();
                OleDbDataReader preencherGrid = preencherDataGridView.ExecuteReader();
                carregandoDataGridView.Load(preencherGrid);
                dgvRelatorioAgendaDia.DataSource = carregandoDataGridView;
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

        private void btVerificarAgendamento_Click(object sender, EventArgs e)
        {            
            int referenciaAgendamento = dtpDataAgendamentoRelatorioDia.Value.Day + dtpDataAgendamentoRelatorioDia.Value.Month + dtpDataAgendamentoRelatorioDia.Value.Year;
            carregarGrid(referenciaAgendamento);
        }

        private void btDeletarRelatorioAgendaDia_Click(object sender, EventArgs e)
        {
            int codSelecionado = Convert.ToInt32(dgvRelatorioAgendaDia.CurrentRow.Cells[0].Value);
            int referenciaAgendamento = dtpDataAgendamentoRelatorioDia.Value.Day + dtpDataAgendamentoRelatorioDia.Value.Month + dtpDataAgendamentoRelatorioDia.Value.Year;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoDelete = "delete from Agendamento where codigoAgendamento=@codSelecionado";

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
                    // verificar uma maneira de atualizar o data grid view
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();                    
                }
                carregarGrid(referenciaAgendamento);
            }
        }

        // PROCEDIMENTO PARA ENVIAR CONFIRMAÇÃO DE CONSULTA POR SMS UTILIZANDO O SERVIÇO VIANETT
        void enviarSMS(string telefone, string mensagem, string usuario, string senha)
        {
            using (System.Net.WebClient cliente = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                        "src=" + telefone +"&" +
                        "dst=" + telefone +"&" +
                        "msg=" + System.Web.HttpUtility.UrlEncode(mensagem, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "&" +
                        "username=" + System.Web.HttpUtility.UrlEncode(usuario) + "&" +
                        "password=" + System.Web.HttpUtility.UrlEncode(senha);
                    string result = cliente.DownloadString(url);

                    if (result.Contains("OK"))
                        MessageBox.Show("Confirmação enviada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Confirmação não enviada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //BOTÃO PARA ENVIAR A CONFIRMAÇÃO DO AGENDAMENTO
        private void btConfirmacaoRelatorioAgendaDia_Click(object sender, EventArgs e)
        {
            string telefone = "55" + Convert.ToString(dgvRelatorioAgendaDia.CurrentRow.Cells[7].Value); // colocar no [0] o numero do campo que esta o numero do telefone
            MessageBox.Show("Telefone " + telefone);
            string mensagem = "Confirmando sua consulta dia " + Convert.ToString(dgvRelatorioAgendaDia.CurrentRow.Cells[1].Value) + 
                " às " + Convert.ToString(dgvRelatorioAgendaDia.CurrentRow.Cells[2].Value) +
                "para realizar o procedimento " + Convert.ToString(dgvRelatorioAgendaDia.CurrentRow.Cells[11].Value); // Colocar o numero dos campos que deseja trazer na mensagem
            //string usuario = InputDialogBox.Show("Informe o usuário do ViaNett");
            //string senha = InputDialogBox.Show("Informe a senha do ViaNett");
            string usuario = "agensystem@outlook.com";
            string senha = "ouaeg";

            enviarSMS(telefone, mensagem, usuario, senha);
        }

        private void relatorio_Agenda_Dia_Load(object sender, EventArgs e)
        {
            int referenciaAgendamento = dtpDataAgendamentoRelatorioDia.Value.Day + dtpDataAgendamentoRelatorioDia.Value.Month + dtpDataAgendamentoRelatorioDia.Value.Year;
            carregarGrid(referenciaAgendamento);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Aplicativo desenvolvido para fins de estudo.");
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastroFuncionario CadastrarFun = new frm_cadastroFuncionario();
            CadastrarFun.Show();            
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cadastroCliente CadastrarCliente = new frm_cadastroCliente();
            CadastrarCliente.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_cadastroServico CadastrarServico = new frm_cadastroServico();
            CadastrarServico.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastroAgendamento CadastrarAgendamento = new frm_cadastroAgendamento();
            CadastrarAgendamento.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_pesquisarCliente PesquisarCliente = new frm_pesquisarCliente();
            PesquisarCliente.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_pesquisarFuncionario PesquisarFuncionario = new frm_pesquisarFuncionario();
            PesquisarFuncionario.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_pesquisarServico PesquisarServico = new frm_pesquisarServico();
            PesquisarServico.Show();
        }


        private void consultasParaODiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio_Agenda_Dia AgendaDia = new relatorio_Agenda_Dia();
            AgendaDia.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pesquisaAvançadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendaParaASemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio_agenda_periodo AgendaPeriodo = new relatorio_agenda_periodo();
            AgendaPeriodo.Show();
        }
    }
}

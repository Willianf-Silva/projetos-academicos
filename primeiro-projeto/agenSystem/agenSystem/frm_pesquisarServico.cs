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
    public partial class frm_pesquisarServico : Form
    {
        public frm_pesquisarServico()
        {
            InitializeComponent();
        }


        // LIMPAR TODOS OS CAMPOS
        void limparCampos()
        {
            txtNomeConsultaServico.Focus();

            txtCodigoConsultaServico.Text = "";
            txtNomeConsultaServico.Text = "";
            txtDescricaoConsultaServico.Text = "";
            txtDuracaoConsultaServico.Text = "";
            txtDificuldadeConsultaServico.Text = "";            
        }


        // DESABILITAR OS CAMPOS (EXCETO NOME)
        void desabilitarCampos()
        {
            txtNomeConsultaServico.Focus();

            txtCodigoConsultaServico.ReadOnly = true;
            txtNomeConsultaServico.ReadOnly = false;
            txtDescricaoConsultaServico.ReadOnly = true;
            txtDuracaoConsultaServico.ReadOnly = true;
            txtDificuldadeConsultaServico.ReadOnly = true;      
        }

        // DESABILITAR BOTÕES (EXCETO SAIR)
        void desabilitarBotoes()
        {
            txtNomeConsultaServico.Focus();
                        
            btSalvarConsultaServico.Enabled = false;
            btEditarConsultaServico.Enabled = false;
            btExcluirConsultaServico.Enabled = false;
            btSairConsultaServico.Enabled = true;

        }


        // HABILITAR OS CAMPOS (EXCETO CODIGO)
        void habilitarCampos()
        {
            txtCodigoConsultaServico.ReadOnly = true;
            txtNomeConsultaServico.ReadOnly = false;
            txtDescricaoConsultaServico.ReadOnly = false;
            txtDuracaoConsultaServico.ReadOnly = false;
            txtDificuldadeConsultaServico.ReadOnly = false;
        }

        // HABILITAR BOTÕES
        void habilitarBotoes()
        {            
            btSalvarConsultaServico.Enabled = true;
            btEditarConsultaServico.Enabled = true;
            btExcluirConsultaServico.Enabled = true;
            btSairConsultaServico.Enabled = true;
        }

        private void frm_pesquisarServico_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
            desabilitarBotoes();
        }

        private void btSairConsultaServico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarConsultaServico_Click(object sender, EventArgs e)
        {
            if (txtNomeConsultaServico.Text != "" && txtDificuldadeConsultaServico.Text != "" && txtDuracaoConsultaServico.Text != "")
            {            
                desabilitarCampos();
                desabilitarBotoes();

                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoUpdate = "update Servico " +
                                        "set nome=@nome,descricao=@descricao,duracao=@duracao,dificuldade=@dificuldade " +
                                        "where codigoServico=@codigoServico";


                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoUpdate, conexao);

                // adicionando os valores do text box no banco de dados
                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeConsultaServico.Text;
                comando.Parameters.Add("@descricao", OleDbType.VarChar).Value = txtDescricaoConsultaServico.Text;
                comando.Parameters.Add("@duracao", OleDbType.VarChar).Value = txtDuracaoConsultaServico.Text;
                comando.Parameters.Add("@dificuldade", OleDbType.VarChar).Value = txtDificuldadeConsultaServico.Text;
                comando.Parameters.Add("@codigoServico", OleDbType.VarChar).Value = txtCodigoConsultaServico.Text;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso!");
                    limparCampos();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();
                    btPesquisarConsultaServico.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }

        private void btEditarConsultaServico_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            habilitarBotoes();
        }

        private void btExcluirConsultaServico_Click(object sender, EventArgs e)
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";

            if (MessageBox.Show("Deseja realmente excluir esse cadastro?",
                "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada !! ");
            }
            else
            {
                string comandoDelete = "delete from Servico where nome=@nome";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoDelete, conexao);

                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeConsultaServico.Text;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!");
                    limparCampos();
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
        }

        private void btPesquisarConsultaServico_Click(object sender, EventArgs e)
        {            
            desabilitarCampos();
            
            string nomePesquisaServico = txtNomeConsultaServico.Text;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select * from Servico where nome like '" + nomePesquisaServico +"%'";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);

            //comando.Parameters.Add("@nome", OleDbType.VarChar).Value = nomePesquisaServico;

            try
            {
                if (nomePesquisaServico == "")
                {
                    throw new Exception("Digite o nome do serviço para consultar");
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

                    txtCodigoConsultaServico.Text = Convert.ToString(cs["codigoServico"]);
                    txtNomeConsultaServico.Text = Convert.ToString(cs["nome"]);
                    txtDescricaoConsultaServico.Text = Convert.ToString(cs["descricao"]);
                    txtDuracaoConsultaServico.Text = Convert.ToString(cs["duracao"]);
                    txtDificuldadeConsultaServico.Text = Convert.ToString(cs["dificuldade"]);

                    habilitarBotoes();
                    btSalvarConsultaServico.Enabled = false;
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


        private void btEditarConsultaServico_Click_1(object sender, EventArgs e)
        {
            habilitarCampos();
            habilitarBotoes();
            btEditarConsultaServico.Enabled = false;
            btExcluirConsultaServico.Enabled = false;
            btSairConsultaServico.Enabled = false;
            btPesquisarConsultaServico.Enabled = false;
        }

        private void btExcluirConsultaServico_Click_1(object sender, EventArgs e)
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";

            if (MessageBox.Show("Deseja realmente excluir esse cadastro?",
                "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada !! ");
            }
            else
            {
                string comandoDelete = "delete from Servico where nome=@nome";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoDelete, conexao);

                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeConsultaServico.Text;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!");
                    limparCampos();
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
        }
    }
}

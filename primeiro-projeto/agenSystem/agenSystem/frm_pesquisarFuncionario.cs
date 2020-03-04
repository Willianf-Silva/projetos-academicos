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
    public partial class frm_pesquisarFuncionario : Form
    {
        public frm_pesquisarFuncionario()
        {
            InitializeComponent();
        }

        // LIMPAR CAMPOS
        void limparCampos()
        {
            txtNomeConsultaFun.Focus();

            txtCodigoConsultaFun.Text = "";
            txtNomeConsultaFun.Text = "";
            mkCpfConsultaFun.Text = "";
            txtFuncaoConsultaFun.Text = "";
            txtEmailConsultaFun.Text = "";
            mkNascimentoConsultaFun.Text = "";
            mkCepConsultaFun.Text = "";
            txtEnderecoConsultaFun.Text = "";
            txtComplementoConsultaFun.Text = "";
            txtBairroConsultaFun.Text = "";
            txtCidadeConsultaFun.Text = "";
            cbEstadoConsultaFun.Text = "";
            mkTelefoneConsultaFun.Text = "";
            mkCelularConsultaFun.Text = "";
        }


        // DESABILITANDO CAMPOS PARA SEREM ALTERADOS

        void desabilitarCampos()
        {
            txtNomeConsultaFun.Focus();

            txtCodigoConsultaFun.ReadOnly = true;
            txtNomeConsultaFun.ReadOnly = false;
            mkCpfConsultaFun.Enabled = false;
            txtFuncaoConsultaFun.ReadOnly = true;
            txtEmailConsultaFun.ReadOnly = true;
            mkNascimentoConsultaFun.Enabled = false;
            mkCepConsultaFun.Enabled = false;
            txtEnderecoConsultaFun.ReadOnly = true;
            txtComplementoConsultaFun.ReadOnly = true;
            txtBairroConsultaFun.ReadOnly = true;
            txtCidadeConsultaFun.ReadOnly = true;
            cbEstadoConsultaFun.Enabled = false;
            mkTelefoneConsultaFun.Enabled = false;
            mkCelularConsultaFun.Enabled = false;
            btSalvarConsultaFun.Enabled = false;
            btEditarConsultaFun.Enabled = false;
            btExcluirConsultaFun.Enabled = false;
            btSairConsultaFun.Enabled = true;
        }


        void habilitarCampos()
        {
            // liberando os campos para serem alterados
            txtCodigoConsultaFun.ReadOnly = true;
            txtNomeConsultaFun.ReadOnly = false;
            mkCpfConsultaFun.Enabled = true;
            txtFuncaoConsultaFun.ReadOnly = false;
            txtEmailConsultaFun.ReadOnly = false;
            mkNascimentoConsultaFun.Enabled = true;
            mkCepConsultaFun.Enabled = true;
            txtEnderecoConsultaFun.ReadOnly = false;
            txtComplementoConsultaFun.ReadOnly = false;
            txtBairroConsultaFun.ReadOnly = false;
            txtCidadeConsultaFun.ReadOnly = false;
            cbEstadoConsultaFun.Enabled = true;
            mkTelefoneConsultaFun.Enabled = true;
            mkCelularConsultaFun.Enabled = true;
            btSalvarConsultaFun.Enabled = true;
            btEditarConsultaFun.Enabled = false;
            btExcluirConsultaFun.Enabled = false;
            btSairConsultaFun.Enabled = false;
            btPesquisarConsultaFun.Enabled = false;
        }


        private void btSalvarConsultaCli_Click(object sender, EventArgs e)
        {
            if (txtNomeConsultaFun.Text != "" && mkCpfConsultaFun.Text != "" && txtFuncaoConsultaFun.Text != "")
            { 
                // liberando os campos para serem alterados

                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoUpdate = "update Funcionario " +
                                        "set nome=@nome,cpffuncionario=@cpffuncionario,funcao=@funcao,email=@email,nascimento=@nascimento,cep=@cep,endereco=@endereco,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado,telefone=@telefone,celular=@celular " +
                                        "where cpffuncionario=@cpffuncionario";


                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoUpdate, conexao);

                // adicionando os valores do text box no banco de dados
                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeConsultaFun.Text;
                comando.Parameters.Add("@cpffuncionario", OleDbType.VarChar).Value = mkCpfConsultaFun.Text;
                comando.Parameters.Add("@funcao", OleDbType.VarChar).Value = txtFuncaoConsultaFun.Text;
                comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmailConsultaFun.Text;
                comando.Parameters.Add("@nascimento", OleDbType.VarChar).Value = mkNascimentoConsultaFun.Text;
                comando.Parameters.Add("@cep", OleDbType.VarChar).Value = mkCepConsultaFun.Text;
                comando.Parameters.Add("@endereco", OleDbType.VarChar).Value = txtEnderecoConsultaFun.Text;
                comando.Parameters.Add("@complemento", OleDbType.VarChar).Value = txtComplementoConsultaFun.Text;
                comando.Parameters.Add("@bairro", OleDbType.VarChar).Value = txtBairroConsultaFun.Text;
                comando.Parameters.Add("@cidade", OleDbType.VarChar).Value = txtCidadeConsultaFun.Text;
                comando.Parameters.Add("@estado", OleDbType.VarChar).Value = cbEstadoConsultaFun.Text;
                comando.Parameters.Add("@telefone", OleDbType.VarChar).Value = mkTelefoneConsultaFun.Text;
                comando.Parameters.Add("@celular", OleDbType.VarChar).Value = mkCelularConsultaFun.Text;

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
                    limparCampos();
                    desabilitarCampos();
                    btEditarConsultaFun.Enabled = false;
                    btPesquisarConsultaFun.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }


        

        private void frm_pesquisarFuncionario_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void btEditarConsultaFun_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btExcluirConsultaFun_Click(object sender, EventArgs e)
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
                string comandoDelete = "delete from Funcionario where cpffuncionario=@cpffuncionario";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoDelete, conexao);

                comando.Parameters.Add("@cpffuncionario", OleDbType.VarChar).Value = mkCpfConsultaFun.Text;

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

                this.Close();
            }
        }

        private void btPesquisarConsultaFun_Click(object sender, EventArgs e)
        {
            string nomePesquisaFuncionario = txtNomeConsultaFun.Text;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select * from Funcionario where nome like '" + nomePesquisaFuncionario + "%'";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);
                        
            try
            {
                if (nomePesquisaFuncionario == "")
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

                    txtCodigoConsultaFun.Text = Convert.ToString(cs["codigoFuncionario"]);
                    txtNomeConsultaFun.Text = Convert.ToString(cs["nome"]);
                    mkCpfConsultaFun.Text = Convert.ToString(cs["cpffuncionario"]);
                    txtFuncaoConsultaFun.Text = Convert.ToString(cs["funcao"]);
                    txtEmailConsultaFun.Text = Convert.ToString(cs["email"]);
                    mkNascimentoConsultaFun.Text = Convert.ToString(cs["nascimento"]);
                    mkCepConsultaFun.Text = Convert.ToString(cs["cep"]);
                    txtEnderecoConsultaFun.Text = Convert.ToString(cs["endereco"]);
                    txtComplementoConsultaFun.Text = Convert.ToString(cs["complemento"]);
                    txtBairroConsultaFun.Text = Convert.ToString(cs["bairro"]);
                    txtCidadeConsultaFun.Text = Convert.ToString(cs["cidade"]);
                    cbEstadoConsultaFun.Text = Convert.ToString(cs["estado"]);
                    mkTelefoneConsultaFun.Text = Convert.ToString(cs["telefone"]);
                    mkCelularConsultaFun.Text = Convert.ToString(cs["celular"]);

                    btExcluirConsultaFun.Enabled = true;
                    btEditarConsultaFun.Enabled = true;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                conexao.Close();
                txtNomeConsultaFun.Focus();

            }
        }

        private void btSairConsultaFun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

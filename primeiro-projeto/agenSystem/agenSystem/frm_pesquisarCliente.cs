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

namespace agenSystem
{
    public partial class frm_pesquisarCliente : Form
    {
        public frm_pesquisarCliente()
        {
            InitializeComponent();
        }

        void limparCampos()
        {
            txtCodigoConsultaCli.Text = "";
            txtNomeConsultaCli.Text = "";
            mkCNPJeCPFConsultaCli.Text = "";
            mkCepConsultaCli.Text = "";
            txtEnderecoConsultaCli.Text = "";
            txtComplementoConsultaCli.Text = "";
            txtBairroConsultaCli.Text = "";
            txtCidadeConsultaCli.Text = "";
            cbEstadoConsultaCli.Text = "";
            mkTelefoneConsultaCli.Text = "";
            mkNascimentoConsultaCli.Text = "";
            cbGeneroConsultaCli.Text = "";
            cbEstadocivilConsultaCli.Text = "";
            txtProfissaoConsultaCli.Text = "";
            txtEmailConsultaCli.Text = "";
            txtResponsavelConsultaCli.Text = "";
            txtConvenioConsultaCli.Text = "";
            txtObservacoesConsultaCli.Text = "";
            txtAvisoConsultaCli.Text = "";
        }


        //DESABILITANDO TODOS OS TXTBOX PARA NAO SER EDITADO

        void desabilitarCampos()
        {
            txtNomeConsultaCli.Focus();

            txtCodigoConsultaCli.ReadOnly = true;
            txtNomeConsultaCli.ReadOnly = false;
            mkCNPJeCPFConsultaCli.ReadOnly = true;
            mkCepConsultaCli.Enabled = false;
            txtEnderecoConsultaCli.ReadOnly = true;
            txtComplementoConsultaCli.ReadOnly = true;
            txtBairroConsultaCli.ReadOnly = true;
            txtCidadeConsultaCli.ReadOnly = true;
            cbEstadoConsultaCli.Enabled = false;
            mkTelefoneConsultaCli.Enabled = false;
            mkNascimentoConsultaCli.Enabled = false;
            cbGeneroConsultaCli.Enabled = false;
            cbEstadocivilConsultaCli.Enabled = false;
            txtProfissaoConsultaCli.ReadOnly = true;
            txtEmailConsultaCli.ReadOnly = true;
            txtResponsavelConsultaCli.ReadOnly = true;
            txtConvenioConsultaCli.ReadOnly = true;
            txtObservacoesConsultaCli.ReadOnly = true;
            txtAvisoConsultaCli.ReadOnly = true;
            btSalvarConsultaCli.Enabled = false;
            btEditarConsultaCli.Enabled = false;
            btExcluirConsultaCli.Enabled = false;
        }


        void habilitarCampos()
        {
            //HABILITANDO TODOS OS TXTBOX PARA SEREM EDITADOS

            txtCodigoConsultaCli.ReadOnly = true;
            txtNomeConsultaCli.ReadOnly = false;
            mkCNPJeCPFConsultaCli.ReadOnly = true;
            mkCepConsultaCli.Enabled = true;
            txtEnderecoConsultaCli.ReadOnly = false;
            txtComplementoConsultaCli.ReadOnly = false;
            txtBairroConsultaCli.ReadOnly = false;
            txtCidadeConsultaCli.ReadOnly = false;
            cbEstadoConsultaCli.Enabled = true;
            mkTelefoneConsultaCli.Enabled = true;
            mkNascimentoConsultaCli.Enabled = true;
            cbGeneroConsultaCli.Enabled = true;
            cbEstadocivilConsultaCli.Enabled = true;
            txtProfissaoConsultaCli.ReadOnly = false;
            txtEmailConsultaCli.ReadOnly = false;
            txtResponsavelConsultaCli.ReadOnly = false;
            txtConvenioConsultaCli.ReadOnly = false;
            txtObservacoesConsultaCli.ReadOnly = false;
            txtAvisoConsultaCli.ReadOnly = false;
            btSalvarConsultaCli.Enabled = true;
            btEditarConsultaCli.Enabled = false;
            btExcluirConsultaCli.Enabled = false;
            btSairConsultaCli.Enabled = false;
            btPesquisarConsultaCli.Enabled = false;
        }


        private void frm_pesquisarCliente_Load(object sender, EventArgs e)
        {
            desabilitarCampos();                        
        }

        private void btEditarConsultaCli_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btSalvarConsultaCli_Click(object sender, EventArgs e)
        {
            if (txtNomeConsultaCli.Text != "" && mkCNPJeCPFConsultaCli.Text != "" && mkTelefoneConsultaCli.Text != "")
            {

                string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
                string comandoUpdate = "update Cliente " +
                                        "set nome=@nome,cpfoucnpj=@cpfoucnpj,cep=@cep,endereco=@endereco,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado,telefone=@telefone,nascimento=@nascimento,genero=@genero,estadoCivil=@estadoCivil,profissao=@profissao,email=@email,responsavel=@responsavel,convenio=@convenio,observacoes=@observacoes,aviso=@aviso " +
                                        "where cpfoucnpj=@cpfoucnpj";

                mkTelefoneConsultaCli.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoUpdate, conexao);

                comando.Parameters.Add("@nome", OleDbType.VarChar).Value = txtNomeConsultaCli.Text;
                comando.Parameters.Add("@cpfoucnpj", OleDbType.VarChar).Value = mkCNPJeCPFConsultaCli.Text;
                comando.Parameters.Add("@cep", OleDbType.VarChar).Value = mkCepConsultaCli.Text;
                comando.Parameters.Add("@endereco", OleDbType.VarChar).Value = txtEnderecoConsultaCli.Text;
                comando.Parameters.Add("@complemento", OleDbType.VarChar).Value = txtComplementoConsultaCli.Text;
                comando.Parameters.Add("@bairro", OleDbType.VarChar).Value = txtBairroConsultaCli.Text;
                comando.Parameters.Add("@cidade", OleDbType.VarChar).Value = txtCidadeConsultaCli.Text;
                comando.Parameters.Add("@estado", OleDbType.VarChar).Value = cbEstadoConsultaCli.Text;
                comando.Parameters.Add("@telefone", OleDbType.VarChar).Value = mkTelefoneConsultaCli.Text;
                comando.Parameters.Add("@nascimento", OleDbType.VarChar).Value = mkNascimentoConsultaCli.Text;
                comando.Parameters.Add("@genero", OleDbType.VarChar).Value = cbGeneroConsultaCli.Text;
                comando.Parameters.Add("@estadoCivil", OleDbType.VarChar).Value = cbEstadocivilConsultaCli.Text;
                comando.Parameters.Add("@profissao", OleDbType.VarChar).Value = txtProfissaoConsultaCli.Text;
                comando.Parameters.Add("@email", OleDbType.VarChar).Value = txtEmailConsultaCli.Text;
                comando.Parameters.Add("@responsavel", OleDbType.VarChar).Value = txtResponsavelConsultaCli.Text;
                comando.Parameters.Add("@convenio", OleDbType.VarChar).Value = txtConvenioConsultaCli.Text;
                comando.Parameters.Add("@observacoes", OleDbType.VarChar).Value = txtObservacoesConsultaCli.Text;
                comando.Parameters.Add("@aviso", OleDbType.VarChar).Value = txtAvisoConsultaCli.Text;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso!");
                    limparCampos();
                    desabilitarCampos();
                    btPesquisarConsultaCli.Enabled = true;
                    btSairConsultaCli.Enabled = true;
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
            else
            {
                MessageBox.Show("Favor preencher os campos obrigatórios (*)");
            }
        }

        private void btExcluirConsultaCli_Click(object sender, EventArgs e)
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
                string comandoDelete = "delete from Cliente where cpfOucnpj=@cpfOucnpj";

                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoDelete, conexao);

                comando.Parameters.Add("@cpfoucnpj", OleDbType.VarChar).Value = mkCNPJeCPFConsultaCli.Text;

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!");
                }
                catch(Exception E)
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

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisarConsultaCli_Click(object sender, EventArgs e)
        {

            string nomePesquisaCliente = txtNomeConsultaCli.Text;
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select * from Cliente where nome like '" + nomePesquisaCliente + "%'";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);            

            try
            {
                if (nomePesquisaCliente == "")
                {
                    throw new Exception("Digite o CPF ou CNPJ do cliente para consultar");
                }

                conexao.Open();

                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == false)
                {
                    throw new Exception("Não existe cadastro para esse cliente");
                }
                else
                {
                    cs.Read();

                    txtCodigoConsultaCli.Text = Convert.ToString(cs["codigo"]);
                    txtNomeConsultaCli.Text = Convert.ToString(cs["nome"]);
                    mkCNPJeCPFConsultaCli.Text = Convert.ToString(cs["cpfoucnpj"]);
                    mkCepConsultaCli.Text = Convert.ToString(cs["cep"]);
                    txtEnderecoConsultaCli.Text = Convert.ToString(cs["endereco"]);
                    txtComplementoConsultaCli.Text = Convert.ToString(cs["complemento"]);
                    txtBairroConsultaCli.Text = Convert.ToString(cs["bairro"]);
                    txtCidadeConsultaCli.Text = Convert.ToString(cs["cidade"]);
                    cbEstadoConsultaCli.Text = Convert.ToString(cs["estado"]);
                    mkTelefoneConsultaCli.Text = Convert.ToString(cs["telefone"]);                   
                    mkNascimentoConsultaCli.Text = Convert.ToString(cs["nascimento"]);
                    cbGeneroConsultaCli.Text = Convert.ToString(cs["genero"]);
                    cbEstadocivilConsultaCli.Text = Convert.ToString(cs["estadoCivil"]);
                    txtProfissaoConsultaCli.Text = Convert.ToString(cs["profissao"]);
                    txtEmailConsultaCli.Text = Convert.ToString(cs["email"]);
                    txtResponsavelConsultaCli.Text = Convert.ToString(cs["responsavel"]);
                    txtConvenioConsultaCli.Text = Convert.ToString(cs["convenio"]);
                    txtObservacoesConsultaCli.Text = Convert.ToString(cs["observacoes"]);
                    txtAvisoConsultaCli.Text = Convert.ToString(cs["aviso"]);
                    
                    btEditarConsultaCli.Enabled = true;
                    btExcluirConsultaCli.Enabled = true;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                limparCampos();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

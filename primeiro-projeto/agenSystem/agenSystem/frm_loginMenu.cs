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
    public partial class frm_loginMenu : Form
    {
        public frm_loginMenu()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static class Autenticacao
        {
            static string nome;
            static string senha;


            public static void login(string nome, string senha)
            {
                nome = nome;
                senha = senha;
            }

        }

        private void btLogar_Click(object sender, EventArgs e)
        {

            string comandoLogar = "SELECT * FROM Funcionario WHERE usuario=@usuario AND senha=@senha";
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoLogar, conexao);

            
            comando.Parameters.Add("@usuario", OleDbType.VarChar).Value = txtUsuarioLogin.Text;
            comando.Parameters.Add("@senha", OleDbType.VarChar).Value = txtSenhaLogin.Text;

            try
            {
                if (txtUsuarioLogin.Text == "" || txtSenhaLogin.Text == "")
                {
                    throw new Exception("Informe usuário e senha para entrar.");
                }

                conexao.Open();
                OleDbDataReader consulta = comando.ExecuteReader();

                if (consulta.Read())
                {
                    Autenticacao.login(consulta["nome"].ToString(), consulta["senha"].ToString());
                                        
                    this.Hide();                    
                    Menu TelaPrincipal = new Menu();
                    TelaPrincipal.Show();                    
                }

                else
                {
                    MessageBox.Show("Usuário e/ou senha não encontrados");
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

        string validarUsuario(string senhaAdm)
        {
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select * from Funcionario where senha=@senhaAutenticacao";

            OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
            OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);
            comando.Parameters.Add("@senhaAutenticacao", OleDbType.VarChar).Value = senhaAdm;

            try
            {
                if (senhaAdm == "")
                {
                    throw new Exception("Digite a senha de algum usuário cadastrado para recuperar dados");
                }

                conexao.Open();

                OleDbDataReader cs = comando.ExecuteReader();

                if (cs.HasRows == true)
                {
                    senhaAdm = "encontrado";
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

            return senhaAdm;
        }
        private void btEsqueceuSenha_Click(object sender, EventArgs e)
        {
            string cpfFuncionario = InputDialogBox.Show("Informe o CPF (000.000.000-00) para recuperar a senha.");
            string senhaAdm = InputDialogBox.Show("Informe a senha de um usuário cadastrado.");
            string autenticacaoAdm = validarUsuario(senhaAdm);
            string conexaoCaminho = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\base.mdb";
            string comandoSelect = "select * from Funcionario where cpfFuncionario=@cpfFuncionario";

            if (autenticacaoAdm == "encontrado")
            {


                OleDbConnection conexao = new OleDbConnection(conexaoCaminho);
                OleDbCommand comando = new OleDbCommand(comandoSelect, conexao);
                comando.Parameters.Add("@cpfFuncionario", OleDbType.VarChar).Value = cpfFuncionario;

                try
                {
                    if (cpfFuncionario == "")
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
                        string usuario = Convert.ToString(cs["login"]);
                        string senha = Convert.ToString(cs["senha"]);

                        MessageBox.Show("Usuário: " + usuario + " Senha: " + senha);

                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    conexao.Close();
                    txtUsuarioLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informe um usuário válido.");
            }
        }
    }
}

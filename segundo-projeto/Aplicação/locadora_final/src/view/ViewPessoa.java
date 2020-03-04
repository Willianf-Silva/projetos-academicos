package view;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.text.MaskFormatter;

import model.Funcionario;
import model.FuncionarioDAO;
import model.PadraoTela;
import model.PaisDAO;
import model.Pessoa;
import model.PessoaDAO;
import model.TableModel;
import services.BD;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.JFormattedTextField;
import javax.swing.JPasswordField;
import javax.swing.JButton;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.ParseException;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class ViewPessoa {

	private JFrame CadastroPessoa;
	private JTable tblLista;
	private DefaultTableModel model;
	private BD bd = new BD();
	private PessoaDAO dao = new PessoaDAO();
	private JTextField txtNome;
	private JTextField txtSobrenome;
	private JTextField txtBairro;
	private JTextField txtEmail;
	private JPasswordField txtPassSenha;
	private JTextField txtEndereco;
	private JTextField txtLogin;
	private JTextField txtPesquisa;
	private JFormattedTextField txtFormatedCpf = new JFormattedTextField();
	private JFormattedTextField txtFormatedTelefone = new JFormattedTextField();
	private JFormattedTextField txtFormatedCep = new JFormattedTextField();
	private	JFormattedTextField txtFormatedNascimento = new JFormattedTextField();
	private JComboBox cbTipoPessoa = new JComboBox();
	private JComboBox cbGenero = new JComboBox();
	private JButton btnIncluir = new JButton("Incluir");
	private JButton btnAlterar = new JButton("Alterar");
	private JButton btnExcluir = new JButton("Excluir");
	private JLabel lblLogin = new JLabel("Login");
	private JLabel lblNascimento = new JLabel("Nascimento");
	private JLabel lblCep = new JLabel("Cep");
	private JLabel lblFoto = new JLabel("Foto");
	private JLabel lblClassificacao = new JLabel("Classifica\u00E7\u00E3o");
	private JLabel lblNome = new JLabel("Nome");
	private JLabel lblSobrenome = new JLabel("Sobrenome");
	private JLabel lblCpf = new JLabel("CPF");
	private JLabel lblTelefone = new JLabel("Telefone");
	private JLabel lblBairro = new JLabel("Bairro");
	private JLabel lblEmail = new JLabel("E-mail");
	private JLabel lblGenero = new JLabel("G\u00EAnero");
	private JLabel lblSenha = new JLabel("Senha");
	private JLabel lblEndereco = new JLabel("Endere\u00E7o");
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewPessoa window = new ViewPessoa();
					window.CadastroPessoa.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Método para formatar os campos JFormattedTextField
	 */
	private void formatarCampos() {
		try {
			MaskFormatter cep = new MaskFormatter("#####-###");
			cep.install(txtFormatedCep);			
			
			MaskFormatter cpf = new MaskFormatter("###########");
			cpf.install(txtFormatedCpf);
			
			MaskFormatter nascimento = new MaskFormatter("##/##/####");
			nascimento.install(txtFormatedNascimento);
			
			MaskFormatter telefone = new MaskFormatter("(##)####-####");
			telefone.install(txtFormatedTelefone);
			
		} catch (ParseException e) {
			JOptionPane.showMessageDialog(null, "Erro ao formatar campo de texto. " + e);
			e.printStackTrace();
		}
		
	}
	/**
	 * Método responsável por pegar os valores selecionados na tabela e carregar nos campos
	 */
	private void carregarCampos() {

		int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());		
		txtNome.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 1).toString());
		txtSobrenome.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 2).toString());
		txtFormatedCpf.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 3).toString());		
		txtFormatedTelefone.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 5).toString());
		txtEndereco.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 6).toString());
		txtBairro.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 7).toString());
		txtFormatedCep.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 8).toString());
		txtEmail.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 9).toString());
		txtFormatedNascimento.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 10).toString());		
		cbGenero.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 11).toString());
		txtLogin.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 12).toString());
		txtPassSenha.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 13).toString());
	}
	
	/**
	 * Método responsável por limpar todos os campos
	 */
	private void limparCampos() {

		txtNome.setText(null);
		txtSobrenome.setText(null);
		txtFormatedCpf.setText(null);		
		txtFormatedTelefone.setText(null);
		txtEndereco.setText(null);
		txtBairro.setText(null);
		txtFormatedCep.setText(null);
		txtEmail.setText(null);
		txtFormatedNascimento.setText(null);		
		cbGenero.setSelectedItem(null);
		txtLogin.setText(null);
		txtPassSenha.setText(null);
	}
	
	/**
	 * Método responsável por bloquear a exibição dos campos de login e senha na tela
	 */
	private void bloquearCamposFuncionario() {
		txtLogin.setVisible(false);
		txtPassSenha.setVisible(false);
		lblLogin.setVisible(false);
		lblSenha.setVisible(false);
	}
	
	
	/**
	 * Método responsável por liberar a exibição dos campos de login e senha na tela
	 */
	private void liberarCamposFuncionario() {
		txtLogin.setVisible(true);
		txtPassSenha.setVisible(true);
		lblLogin.setVisible(true);
		lblSenha.setVisible(true);
	}
	
	/**
	 * Create the application.
	 */
	public ViewPessoa() {
		initialize();
		formatarCampos();
		tblLista.setModel(dao.consulta("Cliente"));
		
		
		
		lblFoto.setBounds(10, 61, 202, 214);
		CadastroPessoa.getContentPane().add(lblFoto);
		
		
		cbTipoPessoa.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				// Instanciando uma pessoa para realizar as operações com o banco de dados
				PessoaDAO dao = new PessoaDAO();
				// Chamar o método para carregar a tabela de acordo com o tipo de pessoa selecionado
				tblLista.setModel(dao.consulta(cbTipoPessoa.getSelectedItem().toString()));
				
				//Ajusta os campos conforme a seleção do tipo de pessoa
				if(cbTipoPessoa.getSelectedItem().toString() == "Cliente") {
					bloquearCamposFuncionario();
					
				}else {
					liberarCamposFuncionario();
				}					
			}
		});
		cbTipoPessoa.setModel(new DefaultComboBoxModel(new String[] {"Cliente", "Funcionario"}));
		cbTipoPessoa.setBounds(424, 11, 233, 28);
		//cbTipoPessoa.setSelectedItem(null);
		CadastroPessoa.getContentPane().add(cbTipoPessoa);
		
		
		lblClassificacao.setBounds(333, 18, 79, 14);
		CadastroPessoa.getContentPane().add(lblClassificacao);
		
		txtNome = new JTextField();
		txtNome.setColumns(10);
		txtNome.setBounds(240, 63, 287, 28);
		CadastroPessoa.getContentPane().add(txtNome);
		
		
		lblNome.setBounds(240, 50, 79, 14);
		CadastroPessoa.getContentPane().add(lblNome);
		
		
		lblSobrenome.setBounds(612, 50, 79, 14);
		CadastroPessoa.getContentPane().add(lblSobrenome);
		
		txtSobrenome = new JTextField();
		txtSobrenome.setText("");
		txtSobrenome.setColumns(10);
		txtSobrenome.setBounds(612, 63, 307, 28);
		CadastroPessoa.getContentPane().add(txtSobrenome);
		
		
		lblCpf.setBounds(240, 103, 79, 14);
		CadastroPessoa.getContentPane().add(lblCpf);
		
		
		txtFormatedCpf.setBounds(240, 114, 287, 28);
		CadastroPessoa.getContentPane().add(txtFormatedCpf);
		

		
		txtFormatedTelefone.setBounds(612, 114, 307, 28);
		CadastroPessoa.getContentPane().add(txtFormatedTelefone);
		

		
		cbGenero.setModel(new DefaultComboBoxModel(new String[] {"Feminino", "Masculino"}));
		cbGenero.setBounds(612, 276, 307, 28);
		cbGenero.setSelectedItem(null);
		CadastroPessoa.getContentPane().add(cbGenero);
		
		
		lblTelefone.setBounds(612, 103, 79, 14);
		CadastroPessoa.getContentPane().add(lblTelefone);
		
		
		lblBairro.setBounds(612, 154, 79, 14);
		CadastroPessoa.getContentPane().add(lblBairro);
		
		txtBairro = new JTextField();
		txtBairro.setText("");
		txtBairro.setColumns(10);
		txtBairro.setBounds(612, 169, 307, 28);
		CadastroPessoa.getContentPane().add(txtBairro);
		
		
		lblEmail.setBounds(612, 209, 79, 14);
		CadastroPessoa.getContentPane().add(lblEmail);
		
		txtEmail = new JTextField();
		txtEmail.setText("");
		txtEmail.setColumns(10);
		txtEmail.setBounds(612, 221, 307, 28);
		CadastroPessoa.getContentPane().add(txtEmail);
		

		lblGenero.setBounds(612, 261, 79, 14);
		CadastroPessoa.getContentPane().add(lblGenero);
		
		
		lblSenha.setBounds(612, 316, 79, 14);
		lblSenha.setVisible(false);
		CadastroPessoa.getContentPane().add(lblSenha);
		
		txtPassSenha = new JPasswordField();
		txtPassSenha.setBounds(612, 330, 307, 27);
		txtPassSenha.setVisible(false);
		CadastroPessoa.getContentPane().add(txtPassSenha);
		
		
		lblEndereco.setBounds(240, 154, 79, 14);
		CadastroPessoa.getContentPane().add(lblEndereco);
		
		txtEndereco = new JTextField();
		txtEndereco.setText("");
		txtEndereco.setColumns(10);
		txtEndereco.setBounds(240, 169, 287, 28);
		CadastroPessoa.getContentPane().add(txtEndereco);
		
		
		lblCep.setBounds(240, 209, 79, 14);
		CadastroPessoa.getContentPane().add(lblCep);
		
		
		txtFormatedCep.setBounds(240, 221, 287, 28);
		CadastroPessoa.getContentPane().add(txtFormatedCep);
		
		
		lblNascimento.setBounds(240, 261, 79, 14);
		CadastroPessoa.getContentPane().add(lblNascimento);
		

		txtFormatedNascimento.setBounds(239, 276, 287, 28);
		CadastroPessoa.getContentPane().add(txtFormatedNascimento);
		
		
		lblLogin.setBounds(240, 316, 79, 14);
		lblLogin.setVisible(false);
		CadastroPessoa.getContentPane().add(lblLogin);
		
		txtLogin = new JTextField();
		txtLogin.setText("");
		txtLogin.setColumns(10);
		txtLogin.setBounds(240, 329, 287, 28);
		txtLogin.setVisible(false);
		CadastroPessoa.getContentPane().add(txtLogin);
		
		txtPesquisa = new JTextField();
		txtPesquisa.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {
				PessoaDAO pessoa = new PessoaDAO();
				if (pessoa.consulta(txtPesquisa.getText(),cbTipoPessoa.getSelectedItem().toString()) != null)
					tblLista.setModel(pessoa.consulta(txtPesquisa.getText(),cbTipoPessoa.getSelectedItem().toString()));
				else
					tblLista.setModel( new DefaultTableModel());
			}
		});
		txtPesquisa.setColumns(10);
		txtPesquisa.setBounds(110, 369, 809, 28);
		CadastroPessoa.getContentPane().add(txtPesquisa);
		
		
		btnIncluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				// instanciando os dois objetos que serão utilizados no formulário
				PessoaDAO cliente = new PessoaDAO();
				FuncionarioDAO funcionario = new FuncionarioDAO();
				
				// se for selecionado o cliente chama o método de incluir pessoa
				// se escolher funcionário chama o metodo para incluir funcionário
				if (cbTipoPessoa.getSelectedItem().toString() == "Cliente") {
					Pessoa pessoa = new Pessoa(txtNome.getText(), txtSobrenome.getText(), txtFormatedCpf.getText(), null, txtFormatedTelefone.getText(), txtEndereco.getText(), txtBairro.getText(), txtFormatedCep.getText(), txtEmail.getText(), txtFormatedNascimento.getText(), cbGenero.getSelectedItem().toString());
					JOptionPane.showMessageDialog(null, cliente.salvar(pessoa));
				}
				else if (cbTipoPessoa.getSelectedItem().toString() == "Funcionario"){
					Funcionario pessoa = new Funcionario(txtNome.getText(), txtSobrenome.getText(), txtFormatedCpf.getText(), null, txtFormatedTelefone.getText(), txtEndereco.getText(), txtBairro.getText(), txtFormatedCep.getText(), txtEmail.getText(), txtFormatedNascimento.getText(), cbGenero.getSelectedItem().toString(),txtLogin.getText(),txtPassSenha.getText());
					JOptionPane.showMessageDialog(null, funcionario.salvar(pessoa));					
				}
				tblLista.setModel(cliente.consulta(cbTipoPessoa.getSelectedItem().toString()));
				limparCampos();
			}
		});
		btnIncluir.setBounds(178, 602, 90, 28);
		CadastroPessoa.getContentPane().add(btnIncluir);
		
		
		btnAlterar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				// instanciando os dois objetos que serão utilizados no formulário
				PessoaDAO cliente = new PessoaDAO();
				FuncionarioDAO funcionario = new FuncionarioDAO();
				
				int codigoSSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());				

					// se for selecionado o cliente chama o método de alterar pessoa
					// se escolher funcionário chama o metodo para alterar funcionário
					if (cbTipoPessoa.getSelectedItem().toString() == "Cliente") {
						Pessoa pessoa = new Pessoa(codigoSSelecionado,txtNome.getText(), txtSobrenome.getText(), txtFormatedCpf.getText(), null, txtFormatedTelefone.getText(), txtEndereco.getText(), txtBairro.getText(), txtFormatedCep.getText(), txtEmail.getText(), txtFormatedNascimento.getText(), cbGenero.getSelectedItem().toString());
						JOptionPane.showMessageDialog(null, cliente.alterar(pessoa));
					}
					else if (cbTipoPessoa.getSelectedItem().toString() == "Funcionario"){
						Funcionario pessoa = new Funcionario(codigoSSelecionado,txtNome.getText(), txtSobrenome.getText(), txtFormatedCpf.getText(), null, txtFormatedTelefone.getText(), txtEndereco.getText(), txtBairro.getText(), txtFormatedCep.getText(), txtEmail.getText(), txtFormatedNascimento.getText(), cbGenero.getSelectedItem().toString(),txtLogin.getText(),txtPassSenha.getText());
						JOptionPane.showMessageDialog(null, funcionario.alterar(pessoa));					
					}				
				tblLista.setModel(cliente.consulta(cbTipoPessoa.getSelectedItem().toString()));
				limparCampos();
			}
		});
		btnAlterar.setBounds(446, 602, 90, 28);
		CadastroPessoa.getContentPane().add(btnAlterar);
		btnExcluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				// instanciando os dois objetos que serão utilizados no formulário
				PessoaDAO cliente = new PessoaDAO();
				FuncionarioDAO funcionario = new FuncionarioDAO();
				
				int codigoSSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());				

					// se for selecionado o cliente chama o método de alterar pessoa
					// se escolher funcionário chama o metodo para alterar funcionário
					if (cbTipoPessoa.getSelectedItem().toString() == "Cliente") {
						Pessoa pessoa = new Pessoa(codigoSSelecionado);
						JOptionPane.showMessageDialog(null, cliente.excluir(pessoa));
					}
					else if (cbTipoPessoa.getSelectedItem().toString() == "Funcionario"){
						Funcionario pessoa = new Funcionario(codigoSSelecionado);
						JOptionPane.showMessageDialog(null, funcionario.excluir(pessoa));					
					}				
				tblLista.setModel(cliente.consulta(cbTipoPessoa.getSelectedItem().toString()));
				limparCampos();
			}
		});
		
		
		btnExcluir.setBounds(714, 602, 90, 28);
		CadastroPessoa.getContentPane().add(btnExcluir);
		
		JLabel lblNewLabel = new JLabel("Pesquisar");
		lblNewLabel.setBounds(36, 373, 64, 21);
		CadastroPessoa.getContentPane().add(lblNewLabel);
		
	}

		
	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		CadastroPessoa = new JFrame();
		CadastroPessoa.setTitle("Cadastro Pessoa");
		CadastroPessoa.setBounds(100, 100, 1000, 682);
		CadastroPessoa.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		CadastroPessoa.getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane(tblLista);
		scrollPane.setBounds(10, 408, 909, 162);		
		CadastroPessoa.getContentPane().add(scrollPane);
		
				
		tblLista = new JTable(model);
		tblLista.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				carregarCampos();
			}

		});
		
		tblLista.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblLista);
	}
}

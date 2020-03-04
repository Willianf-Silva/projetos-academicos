package view;

import java.awt.EventQueue;

import javax.swing.JFrame;

import model.Funcionario;
import model.LoginDAO;
import model.PadraoTela;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JPasswordField;

public class ViewLogin {
	LoginDAO dao = new LoginDAO();
	private JFrame frame;
	private JTextField txtLogin;
	private JPasswordField txtSenha;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewLogin window = new ViewLogin();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ViewLogin() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 319, 197);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblLogin = new JLabel("Login");
		lblLogin.setBounds(10, 37, 46, 14);
		frame.getContentPane().add(lblLogin);
		
		JLabel lblSenha = new JLabel("Senha");
		lblSenha.setBounds(10, 79, 46, 14);
		frame.getContentPane().add(lblSenha);
		
		txtLogin = new JTextField();
		txtLogin.setBounds(53, 34, 231, 20);
		frame.getContentPane().add(txtLogin);
		txtLogin.setColumns(10);
		
		JButton btnNewButton = new JButton("Logar");
		btnNewButton.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				Funcionario funcionario = new Funcionario();
				funcionario.setLogin(txtLogin.getText());
				funcionario.setSenha(txtSenha.getText());
				if (dao.logar(funcionario) == 1) {
					ViewTelaPrincipal telaPrincipal = new ViewTelaPrincipal();
					telaPrincipal.main(null);
				}
			}
		});
		btnNewButton.setBounds(195, 121, 89, 23);
		frame.getContentPane().add(btnNewButton);
		
		txtSenha = new JPasswordField();
		txtSenha.setBounds(53, 75, 231, 20);
		frame.getContentPane().add(txtSenha);
	}
}

package view;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import model.PadraoTela;
import model.PessoaDAO;

import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class ViewConsultaClienteLocacao {

	private JFrame ClienteLocacoes;
	private JTable tblLista;
	private JTextField txtCliente;
	PessoaDAO dao = new PessoaDAO();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();

		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewConsultaClienteLocacao window = new ViewConsultaClienteLocacao();
					window.ClienteLocacoes.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ViewConsultaClienteLocacao() {
		initialize();
		tblLista.setModel(dao.consultaocacoes(txtCliente.getText()));
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		ClienteLocacoes = new JFrame();
		ClienteLocacoes.setTitle("Consulta loca\u00E7\u00F5es cliente");
		ClienteLocacoes.setBounds(100, 100, 661, 350);
		ClienteLocacoes.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		ClienteLocacoes.getContentPane().setLayout(null);

		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 50, 625, 250);
		ClienteLocacoes.getContentPane().add(scrollPane);

		tblLista = new JTable();
		tblLista.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblLista);

		JLabel lblCliente = new JLabel("Cliente");
		lblCliente.setBounds(10, 22, 46, 14);
		ClienteLocacoes.getContentPane().add(lblCliente);

		txtCliente = new JTextField();
		txtCliente.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {				

				if(dao.consultaocacoes(txtCliente.getText()) != null)
					tblLista.setModel(dao.consultaocacoes(txtCliente.getText()));
				else
					tblLista.setModel(new DefaultTableModel());
			}

		});
		txtCliente.setBounds(66, 19, 569, 20);
		ClienteLocacoes.getContentPane().add(txtCliente);
		txtCliente.setColumns(10);
	}
}

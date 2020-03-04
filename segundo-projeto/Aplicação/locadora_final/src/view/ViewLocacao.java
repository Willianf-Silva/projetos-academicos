package view;

import java.awt.EventQueue;
import javax.swing.JFrame;
import model.ItemLocacao;
import model.ItemLocacaoDAO;
import model.Locacao;
import model.LocacaoDAO;
import model.PadraoTela;
import model.PessoaDAO;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class ViewLocacao {
	private PessoaDAO cliente = new PessoaDAO();
	private PessoaDAO funcionario = new PessoaDAO();
	private ItemLocacaoDAO itemLocacaoDAO = new ItemLocacaoDAO();
	private LocacaoDAO dao = new LocacaoDAO();
	private DefaultTableModel model;
	ArrayList<ItemLocacao> arrayItem = new ArrayList();
	private JFrame Locacao;
	private JTextField txtVendedor;
	private JTable tblListaVendedor;
	private JTextField txtCliente;
	private JTable tblListaCliente;
	private JTextField txtValorPago;
	private JTextField txtValorTotal;
	private JTextField txtPagar;
	private JTextField txtCodMidia;
	private JButton btnExcluir;
	private JScrollPane scrollPane_2;
	private JTable tblListaMidia;
	private JButton btnFinalizar;


	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewLocacao window = new ViewLocacao();
					window.Locacao.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Método para carregar a tabela com todos os clientes cadastrados no banco
	 */
	private void carregarTabelaCliente() {
		tblListaCliente.setModel(cliente.consulta("Cliente"));
	}

	private void limparCampos() {
		txtVendedor.setText(null);
		txtCliente.setText(null);
		txtCodMidia.setText(null);
		txtValorPago.setText(null);
		txtValorTotal.setText(null);
		txtPagar.setText(null);
	}

	/**
	 * Método para carregar a tabela com todos os funcionários cadastrados no banco
	 */
	private void carregarTabelaVendedor() {
		tblListaVendedor.setModel(cliente.consulta("Funcionario"));
	}

	/**
	 * Create the application.
	 */
	public ViewLocacao() {
		initialize();
		txtValorTotal.disable();
		txtPagar.disable();
		carregarTabelaCliente();
		carregarTabelaVendedor();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		Locacao = new JFrame();
		Locacao.setTitle("Loca\u00E7\u00E3o");
		Locacao.setBounds(100, 100, 815, 475);
		Locacao.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		Locacao.getContentPane().setLayout(null);

		JLabel lblVendedor = new JLabel("Vendedor");
		lblVendedor.setBounds(119, 11, 58, 14);
		Locacao.getContentPane().add(lblVendedor);

		txtVendedor = new JTextField();
		txtVendedor.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {				
				if(funcionario.consulta(txtVendedor.getText(), "Funcionario") != null)
					tblListaVendedor.setModel(funcionario.consulta(txtVendedor.getText(), "Funcionario"));
				else
					tblListaVendedor.setModel(new DefaultTableModel());
			}
		});
		txtVendedor.setBounds(187, 8, 602, 20);
		Locacao.getContentPane().add(txtVendedor);
		txtVendedor.setColumns(10);

		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(187, 36, 602, 97);
		Locacao.getContentPane().add(scrollPane);

		tblListaVendedor = new JTable(model);
		tblListaVendedor.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblListaVendedor);

		JLabel lblCliente = new JLabel("Cliente");
		lblCliente.setBounds(119, 164, 58, 14);
		Locacao.getContentPane().add(lblCliente);

		txtCliente = new JTextField();
		txtCliente.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent e) {
				if(cliente.consulta(txtCliente.getText(), "Cliente") != null)
					tblListaCliente.setModel(cliente.consulta(txtCliente.getText(), "Cliente"));
				else
					tblListaCliente.setModel(new DefaultTableModel());
			}
		});
		txtCliente.setBounds(187, 161, 602, 20);
		Locacao.getContentPane().add(txtCliente);
		txtCliente.setColumns(10);

		JScrollPane scrollPane_1 = new JScrollPane();
		scrollPane_1.setBounds(187, 194, 602, 97);
		Locacao.getContentPane().add(scrollPane_1);

		tblListaCliente = new JTable(model);
		tblListaCliente.setFillsViewportHeight(true);
		scrollPane_1.setViewportView(tblListaCliente);

		JLabel lblValorPago = new JLabel("Valor Pago");
		lblValorPago.setBounds(10, 349, 71, 14);
		Locacao.getContentPane().add(lblValorPago);

		JLabel lblValorTotal = new JLabel("Valor Total");
		lblValorTotal.setBounds(10, 321, 71, 14);
		Locacao.getContentPane().add(lblValorTotal);

		txtValorPago = new JTextField();
		txtValorPago.setBounds(81, 346, 80, 20);
		Locacao.getContentPane().add(txtValorPago);
		txtValorPago.setColumns(10);

		txtValorTotal = new JTextField();
		txtValorTotal.setColumns(10);
		txtValorTotal.setBounds(81, 318, 80, 20);
		Locacao.getContentPane().add(txtValorTotal);

		txtPagar = new JTextField();
		txtPagar.setColumns(10);
		txtPagar.setBounds(81, 377, 80, 20);
		Locacao.getContentPane().add(txtPagar);

		JLabel lblDevedor = new JLabel("\u00C0 pagar");
		lblDevedor.setBounds(10, 380, 71, 14);
		Locacao.getContentPane().add(lblDevedor);

		txtCodMidia = new JTextField();
		txtCodMidia.setColumns(10);
		txtCodMidia.setBounds(281, 300, 508, 20);
		Locacao.getContentPane().add(txtCodMidia);

		btnExcluir = new JButton("-");
		btnExcluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JOptionPane.showMessageDialog(null, "Funcionalidade em desenvolvimento");
			}
		});
		btnExcluir.setBounds(187, 299, 35, 23);
		Locacao.getContentPane().add(btnExcluir);

		JButton btnIncluir = new JButton("+");
		btnIncluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				ItemLocacao itemLocacao = new ItemLocacao(Integer.parseInt(txtCodMidia.getText()));				
				arrayItem.add(itemLocacao);
				txtCodMidia.setText(null);
				txtCodMidia.requestFocus();

				for (ItemLocacao itemArray : arrayItem) {
					// Necessário incluir os itens na tabela
				}
			}
		});
		btnIncluir.setBounds(234, 299, 35, 23);
		Locacao.getContentPane().add(btnIncluir);

		scrollPane_2 = new JScrollPane();
		scrollPane_2.setBounds(187, 333, 602, 72);
		Locacao.getContentPane().add(scrollPane_2);

		tblListaMidia = new JTable(model);
		tblListaMidia.setFillsViewportHeight(true);
		scrollPane_2.setViewportView(tblListaMidia);

		btnFinalizar = new JButton("Finalizar");
		btnFinalizar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				try {
					// Adicionando uma locação no banco de dados
					int codigoCliente = Integer.parseInt(tblListaCliente.getValueAt(tblListaCliente.getSelectedRow(), 0).toString());
					int codigoFuncionario = Integer.parseInt(tblListaVendedor.getValueAt(tblListaVendedor.getSelectedRow(), 0).toString());				
					Locacao locacao = new Locacao(codigoCliente, codigoFuncionario, Double.parseDouble(txtValorPago.getText()));
				//	int retorno = dao.salvar(locacao);

					if (dao.salvar(locacao) > 0) {
						// obtendo o código da ultima locação
						int novaLocacao = dao.codLocacao();
						JOptionPane.showMessageDialog(null, "Nova locação código: " + novaLocacao); // teste
						
						// Adicionando os itens referente a locação
						for (ItemLocacao itemArray : arrayItem) {
							ItemLocacao itemLocacao = new ItemLocacao(novaLocacao, itemArray.getCodMidia());
							//JOptionPane.showMessageDialog(null, "Locação: " + novaLocacao + "\n Midia: " + itemArray.getCodMidia());
							itemLocacaoDAO.salvar(itemLocacao);
						}
					}else {
						JOptionPane.showMessageDialog(null, "Falha na inclusão da locação.");
					}
				} catch (Exception e) {
					JOptionPane.showMessageDialog(null, "Falha " + e.toString());
				}
				limparCampos();
			}
		});
		btnFinalizar.setBounds(44, 408, 89, 23);
		Locacao.getContentPane().add(btnFinalizar);
	}
}

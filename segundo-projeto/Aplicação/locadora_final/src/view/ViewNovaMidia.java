package view;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import model.PadraoTela;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import javax.swing.JCheckBox;

public class ViewNovaMidia {
	private PadraoTela padraoTela = new PadraoTela();
	private JFrame NovaMidia;
	private JTable tblLista;
	private JTextField txtQuantidade;
	private JTextField txtPesquisa;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewNovaMidia window = new ViewNovaMidia();
					window.NovaMidia.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ViewNovaMidia() {
		initialize();
		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		
		padraoTela.Nimbus();
		
		NovaMidia = new JFrame();
		NovaMidia.setBounds(100, 100, 831, 461);
		NovaMidia.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		NovaMidia.getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 157, 795, 195);
		NovaMidia.getContentPane().add(scrollPane);
		
		tblLista = new JTable();
		tblLista.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblLista);
		
		txtQuantidade = new JTextField();
		txtQuantidade.setColumns(10);
		txtQuantidade.setBounds(10, 32, 122, 28);
		NovaMidia.getContentPane().add(txtQuantidade);
		
		JLabel lblQuantidade = new JLabel("Quantidade");
		lblQuantidade.setBounds(10, 11, 114, 16);
		NovaMidia.getContentPane().add(lblQuantidade);
		
		JComboBox cbTipo = new JComboBox();
		cbTipo.setModel(new DefaultComboBoxModel(new String[] {"Dublado", "Legendado"}));
		cbTipo.setBounds(172, 32, 114, 28);
		NovaMidia.getContentPane().add(cbTipo);
		
		JLabel lblMidia = new JLabel("M\u00EDdia");
		lblMidia.setBounds(172, 11, 105, 16);
		NovaMidia.getContentPane().add(lblMidia);
		
		JLabel lblPesquisar = new JLabel("Pesquisar");
		lblPesquisar.setBounds(10, 121, 58, 23);
		NovaMidia.getContentPane().add(lblPesquisar);
		
		txtPesquisa = new JTextField();
		txtPesquisa.setColumns(10);
		txtPesquisa.setBounds(72, 118, 733, 28);
		NovaMidia.getContentPane().add(txtPesquisa);
		
		JButton btnIncluir = new JButton("Incluir");
		btnIncluir.setBounds(136, 363, 90, 28);
		NovaMidia.getContentPane().add(btnIncluir);
		
		JButton btnFechar = new JButton("Fechar");
		btnFechar.setBounds(588, 363, 90, 28);
		NovaMidia.getContentPane().add(btnFechar);
		
		JCheckBox chbObsoleto = new JCheckBox("Obsoleto");
		chbObsoleto.setBounds(10, 75, 97, 23);
		NovaMidia.getContentPane().add(chbObsoleto);
		
		JButton btnAlterar = new JButton("Alterar");
		btnAlterar.setBounds(362, 363, 90, 28);
		NovaMidia.getContentPane().add(btnAlterar);
	}
}

package view;

import java.awt.EventQueue;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import model.*;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextPane;
import javax.swing.table.DefaultTableModel;
import javax.swing.text.MaskFormatter;
import javax.swing.JFormattedTextField;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class ViewProduto {
	private Produto produto = new Produto();
	private ProdutoDAO dao = new ProdutoDAO();
	private DefaultTableModel model = new DefaultTableModel();
	private JFrame Produto;
	private JTable tblLista;
	JLabel lblQuantidadeMidia = new JLabel("Quantidade M\u00EDdia*");
	private JTextField txtPesquisa;
	private JTextField txtQuantidadeMidia;
	private JTextField txtDiretor;
	private JTextField txtNome;
	private JTextField txtProdutora;
	private JComboBox cbTipoLocacao = new JComboBox();
	private JTextField txtSinopse;
	private JFormattedTextField txtFormatedCompra = new JFormattedTextField();
	private JFormattedTextField txtFormatedLancamento = new JFormattedTextField();
	private JFormattedTextField txtFormatedDuracao = new JFormattedTextField();
	private JComboBox cbGenero = new JComboBox();
	private JComboBox cbTitulo = new JComboBox();
	private JComboBox cbMidia = new JComboBox();
	private JComboBox cbPaisOrigem = new JComboBox();
	private JTextPane txtAtores = new JTextPane();


	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {

		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewProduto window = new ViewProduto();
					window.Produto.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
	/**
	 * Método responsavel por carregar a table
	 */
	private void carregarTabela() {
		tblLista.setModel(dao.consulta());
	}
	
	/**
	 * Método responsável por verificar se os campos obrigatorios foram preenchidos
	 * @return - 1 caso tenha preenchido todos os campos ou 0 caso não tenha preenchido todos os campos
	 */
	private int verificaCamposObrigatorios() {
		int retorno;
		if(
				(txtNome.getText().isEmpty()) || 
				(cbGenero.getSelectedIndex() == -1) || 
				(txtFormatedLancamento.getText().isEmpty()) ||				
				(cbTitulo.getSelectedIndex() == -1) || 
				(txtFormatedCompra.getText().isEmpty()) ||
				(cbMidia.getSelectedIndex() == -1) ||
				(cbPaisOrigem.getSelectedIndex() == -1) ||
				(txtFormatedDuracao.getText().isEmpty()) ||
				(cbTipoLocacao.getSelectedIndex() == -1) ||
				//(txtAtores.getText().isEmpty()) ||
				//(txtDiretor.getText().isEmpty()) ||
				//(txtProdutora.getText().isEmpty()) ||
				//(txtSinopse.getText().isEmpty()) ||
				(txtQuantidadeMidia.getText().isEmpty())
		) {
			retorno = 0;
		}
		else {
			retorno = 1;
		}
		return retorno;
	}
	
	/**
	 * Método responsável por deixar todos os campos do formulário vázio
	 */
	private void limparCampos() {
		txtNome.setText(null);
		cbGenero.setSelectedItem(null);
		txtFormatedLancamento.setText(null);		
		txtAtores.setText(null);
		txtDiretor.setText(null);
		txtFormatedDuracao.setText(null);
		txtSinopse.setText(null);
		txtProdutora.setText(null);
		txtFormatedCompra.setText(null);		
		txtQuantidadeMidia.setText(null);
		cbTitulo.setSelectedItem(null);
		cbPaisOrigem.setSelectedItem(null);
		cbMidia.setSelectedItem(null);
		cbTipoLocacao.setSelectedItem(null);
		txtPesquisa.setText(null);
	}
	
	/**
	 * Método responsável por pegar os valores selecionados na tabela e carregar nos campos
	 */
	private void carregarCampos() {
		int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());		
		txtNome.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 1).toString());
		cbGenero.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 2).toString());
		txtFormatedLancamento.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 3).toString());		
		txtAtores.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 4).toString());
		txtDiretor.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 5).toString());
		txtFormatedDuracao.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 6).toString());
		txtSinopse.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 7).toString());
		txtProdutora.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 8).toString());
		txtFormatedCompra.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 9).toString());		
		txtQuantidadeMidia.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 10).toString());
		cbTitulo.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 11).toString());
		cbPaisOrigem.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 12).toString());
		cbMidia.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 13).toString());
		cbTipoLocacao.setSelectedItem(tblLista.getValueAt(tblLista.getSelectedRow(), 14).toString());
	}
	
	/**
	 * Método para formatar os campos JFormattedTextField
	 */
	private void formatarCampos() {
		try {
			MaskFormatter compra = new MaskFormatter("##/##/####");
			compra.install(txtFormatedCompra);			

			MaskFormatter lancamento = new MaskFormatter("##/##/####");
			lancamento.install(txtFormatedLancamento);

			MaskFormatter duracao = new MaskFormatter("##:##");
			duracao.install(txtFormatedDuracao);


		} catch (ParseException e) {
			JOptionPane.showMessageDialog(null, "Erro ao formatar campo de texto. " + e);
			e.printStackTrace();
		}

	}

	/**
	 * Create the application.
	 */
	public ViewProduto() {
		initialize();
		formatarCampos();
		carregarTabela();
	}


	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {


		Produto = new JFrame();
		Produto.setTitle("Titulos");
		Produto.setBounds(100, 100, 874, 600);
		Produto.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		Produto.getContentPane().setLayout(null);

		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 409, 838, 101);
		Produto.getContentPane().add(scrollPane);

		tblLista = new JTable(model);
		tblLista.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				carregarCampos();
				//txtQuantidadeMidia.setVisible(false);
				//lblQuantidadeMidia.setVisible(false);
			}
		});
		tblLista.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblLista);

		txtPesquisa = new JTextField();
		txtPesquisa.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {
				if(dao.consulta(txtPesquisa.getText()) != null)
					tblLista.setModel(dao.consulta(txtPesquisa.getText()));
				else
					tblLista.setModel(new DefaultTableModel());
			}
		});
		txtPesquisa.setColumns(10);
		txtPesquisa.setBounds(242, 369, 606, 28);
		Produto.getContentPane().add(txtPesquisa);

		JLabel lblGenero = new JLabel("G\u00EAnero*");
		lblGenero.setBounds(585, 6, 105, 16);
		Produto.getContentPane().add(lblGenero);

		
		cbGenero.setModel(new DefaultComboBoxModel(new String[] {"A\u00E7\u00E3o", "Anima\u00E7\u00E3o", "Aventura", "Cinema de arte", "Chanchada", "Cinema cat\u00E1strofe", "Com\u00E9dia", "Com\u00E9dia rom\u00E2ntica", "Com\u00E9dia dram\u00E1tica", "Com\u00E9dia de a\u00E7\u00E3o", "Dan\u00E7a", "Document\u00E1rio", "Docufic\u00E7\u00E3o", "Drama", "Espionagem", "Faroeste (ou western)", "Fantasia cient\u00EDfica", "Fic\u00E7\u00E3o cient\u00EDfica", "Filmes de guerra", "Musical", "Filme policial", "Romance", "Seriado", "Suspense", "Terror"}));
		cbGenero.setBounds(585, 24, 263, 28);
		cbGenero.setSelectedItem(null);
		Produto.getContentPane().add(cbGenero);

		JLabel lblTitulo = new JLabel("T\u00EDtulo*");
		lblTitulo.setBounds(585, 66, 105, 16);
		Produto.getContentPane().add(lblTitulo);

		
		cbTitulo.setModel(new DefaultComboBoxModel(new String[] {"Filme", "Serie"}));
		cbTitulo.setBounds(585, 80, 263, 28);
		cbTitulo.setSelectedItem(null);
		Produto.getContentPane().add(cbTitulo);

		JLabel lblMidia = new JLabel("M\u00EDdia*");
		lblMidia.setBounds(585, 120, 105, 16);
		Produto.getContentPane().add(lblMidia);

		
		cbMidia.setModel(new DefaultComboBoxModel(new String[] {"Dublado", "Legendado"}));
		cbMidia.setBounds(585, 137, 263, 28);
		cbMidia.setSelectedItem(null);
		Produto.getContentPane().add(cbMidia);

		JLabel lblTipoLocacao = new JLabel("Tipo Loca\u00E7ao*");
		lblTipoLocacao.setBounds(585, 185, 105, 16);
		Produto.getContentPane().add(lblTipoLocacao);


		cbTipoLocacao.setBounds(585, 199, 263, 28);
		cbTipoLocacao.setModel(dao.popularCbTipoLocacao()); // chamando o método para popular o combobox do banco de dados
		cbTipoLocacao.setSelectedItem(null);
		Produto.getContentPane().add(cbTipoLocacao);


		lblQuantidadeMidia.setBounds(585, 234, 105, 16);
		Produto.getContentPane().add(lblQuantidadeMidia);

		txtQuantidadeMidia = new JTextField();
		txtQuantidadeMidia.setColumns(10);
		txtQuantidadeMidia.setBounds(585, 247, 263, 28);
		Produto.getContentPane().add(txtQuantidadeMidia);

		txtDiretor = new JTextField();
		txtDiretor.setColumns(10);
		txtDiretor.setBounds(242, 247, 263, 28);
		Produto.getContentPane().add(txtDiretor);

		JLabel lblDiretor = new JLabel("Diretor");
		lblDiretor.setBounds(242, 231, 263, 16);
		Produto.getContentPane().add(lblDiretor);

		JLabel lblDuracao = new JLabel("Dura\u00E7\u00E3o*");
		lblDuracao.setBounds(242, 182, 263, 16);
		Produto.getContentPane().add(lblDuracao);


		txtFormatedCompra.setBounds(242, 137, 263, 28);
		Produto.getContentPane().add(txtFormatedCompra);

		JLabel lblDataCompra = new JLabel("Data Compra*");
		lblDataCompra.setBounds(242, 120, 263, 16);
		Produto.getContentPane().add(lblDataCompra);

		JLabel lblLancamento = new JLabel("Data Lan\u00E7amento*");
		lblLancamento.setBounds(242, 64, 263, 16);
		Produto.getContentPane().add(lblLancamento);


		txtFormatedLancamento.setBounds(242, 81, 263, 28);
		Produto.getContentPane().add(txtFormatedLancamento);

		txtNome = new JTextField();
		txtNome.setColumns(10);
		txtNome.setBounds(242, 24, 263, 28);
		Produto.getContentPane().add(txtNome);

		JLabel lblNome = new JLabel("Nome*");
		lblNome.setBounds(242, 6, 263, 16);
		Produto.getContentPane().add(lblNome);

		txtProdutora = new JTextField();
		txtProdutora.setColumns(10);
		txtProdutora.setBounds(10, 302, 196, 24);
		Produto.getContentPane().add(txtProdutora);

		JLabel lblProdutora = new JLabel("Produtora");
		lblProdutora.setBounds(10, 283, 196, 16);
		Produto.getContentPane().add(lblProdutora);

		txtAtores.setBounds(10, 247, 196, 24);
		Produto.getContentPane().add(txtAtores);

		JLabel lblAtores = new JLabel("Atores");
		lblAtores.setBounds(10, 231, 196, 16);
		Produto.getContentPane().add(lblAtores);

		JLabel lblPais = new JLabel("Pa\u00EDs Origem*");
		lblPais.setBounds(10, 182, 196, 16);
		Produto.getContentPane().add(lblPais);

		JLabel lblFoto = new JLabel("Capa");
		lblFoto.setBounds(10, 6, 196, 159);
		Produto.getContentPane().add(lblFoto);

		JButton btNovaMidia = new JButton("Nova M\u00EDdia");
		btNovaMidia.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JOptionPane.showMessageDialog(null, "Funcionalidade em desenvolvimento.");
			}
		});
		btNovaMidia.setBounds(68, 521, 90, 28);
		Produto.getContentPane().add(btNovaMidia);

		
		cbPaisOrigem.setBounds(10, 203, 196, 28);
		cbPaisOrigem.setModel(dao.popularCbPaisOrigem());
		cbPaisOrigem.setSelectedItem(null);
		Produto.getContentPane().add(cbPaisOrigem);

		JButton btIncluir = new JButton("Incluir");
		btIncluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				int validacao = verificaCamposObrigatorios();				
				if ( validacao == 1){
					Produto produto = new Produto(txtNome.getText(), null, cbGenero.getSelectedItem().toString(), txtFormatedLancamento.getText(), txtAtores.getText(), txtDiretor.getText(), txtFormatedDuracao.getText(), txtSinopse.getText(), txtProdutora.getText(), txtFormatedCompra.getText(), Integer.parseInt(txtQuantidadeMidia.getText()), cbTitulo.getSelectedItem().toString(),cbPaisOrigem.getSelectedItem().toString(), cbMidia.getSelectedItem().toString(), cbTipoLocacao.getSelectedItem().toString());
					JOptionPane.showMessageDialog(null, dao.salvar(produto));
					limparCampos();
				}else {
					JOptionPane.showMessageDialog(null, "Preencha os campos obrigatórios (*)");
				}				
				carregarTabela();
				
			}
		});
		btIncluir.setBounds(384, 522, 90, 28);
		Produto.getContentPane().add(btIncluir);

		JButton btAlterar = new JButton("Alterar");
		btAlterar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());
				int validacao = verificaCamposObrigatorios();
				if ( validacao == 1){
					Produto produto = new Produto(codigoSelecionado, txtNome.getText(), null, cbGenero.getSelectedItem().toString(), txtFormatedLancamento.getText(), txtAtores.getText(), txtDiretor.getText(), txtFormatedDuracao.getText(), txtSinopse.getText(), txtProdutora.getText(), txtFormatedCompra.getText(), Integer.parseInt(txtQuantidadeMidia.getText()), cbTitulo.getSelectedItem().toString(),cbPaisOrigem.getSelectedItem().toString(), cbMidia.getSelectedItem().toString(), cbTipoLocacao.getSelectedItem().toString());
					JOptionPane.showMessageDialog(null, dao.alterar(produto));
					limparCampos();
				}else {
					JOptionPane.showMessageDialog(null, "Preencha os campos obrigatórios (*)");
				}				
				carregarTabela();
			}
		});
		btAlterar.setBounds(542, 522, 90, 28);
		Produto.getContentPane().add(btAlterar);

		JButton btExcluir = new JButton("Excluir");
		btExcluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());
				Produto produto = new Produto(codigoSelecionado);
				JOptionPane.showMessageDialog(null, dao.excluir(produto));
				carregarTabela();
				limparCampos();
			}
		});
		btExcluir.setBounds(700, 522, 90, 28);
		Produto.getContentPane().add(btExcluir);

		txtSinopse = new JTextField();
		txtSinopse.setColumns(10);
		txtSinopse.setBounds(242, 302, 606, 55);
		Produto.getContentPane().add(txtSinopse);


		txtFormatedDuracao.setBounds(242, 199, 263, 28);
		Produto.getContentPane().add(txtFormatedDuracao);
		
		JButton btLimpar = new JButton("Limpar");
		btLimpar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				txtQuantidadeMidia.setVisible(true);
				lblQuantidadeMidia.setVisible(true);
				limparCampos();
				carregarTabela();
			}

		});
		btLimpar.setBounds(226, 521, 90, 28);
		Produto.getContentPane().add(btLimpar);
		
		JLabel lblSinopse = new JLabel("Sinopse");
		lblSinopse.setBounds(242, 286, 196, 16);
		Produto.getContentPane().add(lblSinopse);
		
		JLabel lblPesquisa = new JLabel("Pesquisa");
		lblPesquisa.setBounds(174, 375, 63, 16);
		Produto.getContentPane().add(lblPesquisa);


	}
}

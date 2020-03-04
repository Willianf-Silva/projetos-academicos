package view;

import java.awt.EventQueue;
import javax.swing.DefaultComboBoxModel;
import services.BD;
import model.TableModel;
import model.TipoLocacao;
import model.TipoLocacaoDAO;
import model.PadraoTela;
import model.Produto;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;


public class ViewTipoLocacao {
	TipoLocacaoDAO dao = new TipoLocacaoDAO();
	private DefaultTableModel model;
	private BD bd = new BD();
	private JFrame viewTipoLocacao;
	private JTable tblLista = new JTable(model);
	private JScrollPane scrollPane = new JScrollPane();
	private JTextField txtNome  = new JTextField();
	private JTextField txtTempo  = new JTextField();
	private JTextField txtValorUnit = new JTextField();
	private JTextField txtDescricao = new JTextField();
	private JLabel lblNome = new JLabel("Nome*");
	private JLabel lblTempo = new JLabel("Tempo*");
	private JLabel lblValorUnit = new JLabel("Valor Unit\u00E1rio*");
	private JLabel lblDescricao = new JLabel("Descri\u00E7\u00E3o");
	private JButton btnIncluir = new JButton("Incluir");
	private JButton btnAlterar = new JButton("Alterar");
	private JButton btnExcluir = new JButton("Excluir");
	private final JTextField txtPesquisa = new JTextField();
	private final JLabel lblPesquisar = new JLabel("Pesquisar");

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewTipoLocacao window = new ViewTipoLocacao();
					window.viewTipoLocacao.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Método responsável por pegar os valores selecionados na tabela e carregar nos campos
	 */
	private void carregarCampos() {		
		int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());		
		txtNome.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 1).toString());
		txtDescricao.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 2).toString());
		txtTempo.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 3).toString());		
		txtValorUnit.setText(tblLista.getValueAt(tblLista.getSelectedRow(), 4).toString());		
	}
	
	
	/**
	 * Método responsável por deixar todos os campos nullos
	 */
	private void limparCampos() {
		txtNome.setText(null);
		txtDescricao.setText(null);
		txtTempo.setText(null);		
		txtValorUnit.setText(null);	
	}

	
	/**
	 * Método responsável por verificar se os campos obrigatorios foram preenchidos
	 * @return - 1 caso tenha preenchido todos os campos ou 0 caso não tenha preenchido todos os campos
	 */
	private int verificaCamposObrigatorios() {
		int retorno;
		if(
				(txtNome.getText().isEmpty()) ||
				(txtTempo.getText().isEmpty()) ||				
				(txtValorUnit.getText().isEmpty())
		) {
			retorno = 0;
		}
		else {
			retorno = 1;
		}
		return retorno;
	}
	
	
	/**
	 * Create the application.
	 */
	public ViewTipoLocacao() {
		initialize();
		tblLista.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				carregarCampos();
			}
		});
		tblLista.setModel(dao.consulta());
		txtPesquisa.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {
				if (dao.consulta(txtPesquisa.getText()) != null)
				tblLista.setModel(dao.consulta(txtPesquisa.getText()));
				else
					tblLista.setModel(new DefaultTableModel());
			}
		});
		txtPesquisa.setColumns(10);
		txtPesquisa.setBounds(104, 222, 399, 28);
		
		viewTipoLocacao.getContentPane().add(txtPesquisa);
		lblPesquisar.setBounds(35, 229, 59, 14);
		
		viewTipoLocacao.getContentPane().add(lblPesquisar);
		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		viewTipoLocacao = new JFrame();
		viewTipoLocacao.setTitle("Tipo de Loca\u00E7\u00E3o");
		viewTipoLocacao.setBounds(100, 100, 531, 485);
		viewTipoLocacao.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		viewTipoLocacao.getContentPane().setLayout(null);
		
		
		scrollPane.setBounds(10, 257, 493, 139);
		viewTipoLocacao.getContentPane().add(scrollPane);		
		
		tblLista.setFillsViewportHeight(true);
		scrollPane.setViewportView(tblLista);
		
		
		lblNome.setBounds(10, 12, 46, 14);
		viewTipoLocacao.getContentPane().add(lblNome);
		
		
		txtNome.setColumns(10);
		txtNome.setBounds(10, 27, 493, 28);
		viewTipoLocacao.getContentPane().add(txtNome);
		
		
		lblTempo.setBounds(10, 66, 46, 14);
		viewTipoLocacao.getContentPane().add(lblTempo);
		
		
		txtTempo.setColumns(10);
		txtTempo.setBounds(10, 80, 233, 28);
		viewTipoLocacao.getContentPane().add(txtTempo);
		
		
		lblValorUnit.setBounds(270, 67, 103, 14);
		viewTipoLocacao.getContentPane().add(lblValorUnit);
		
		
		txtValorUnit.setColumns(10);
		txtValorUnit.setBounds(270, 80, 233, 28);
		viewTipoLocacao.getContentPane().add(txtValorUnit);
		
		
		lblDescricao.setBounds(10, 118, 103, 14);
		viewTipoLocacao.getContentPane().add(lblDescricao);
		
		
		txtDescricao.setColumns(10);
		txtDescricao.setBounds(10, 132, 493, 62);
		viewTipoLocacao.getContentPane().add(txtDescricao);
		btnIncluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {	
				int validacao = verificaCamposObrigatorios();
				if ( validacao == 1){
					TipoLocacao tipoLocacao = new TipoLocacao(txtNome.getText(),txtDescricao.getText(),Integer.parseInt(txtTempo.getText()),Double.parseDouble(txtValorUnit.getText()));
					JOptionPane.showMessageDialog(null, dao.salvar(tipoLocacao));
					limparCampos();
				}else {
					JOptionPane.showMessageDialog(null, "Preencha os campos obrigatórios (*)");
				}

				tblLista.setModel(dao.consulta());
			}
		});
		
		
		btnIncluir.setBounds(61, 407, 90, 28);
		viewTipoLocacao.getContentPane().add(btnIncluir);
		btnAlterar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {				
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());
				int validacao = verificaCamposObrigatorios();
				if ( validacao == 1){
					TipoLocacao tipoLocacao = new TipoLocacao(codigoSelecionado,txtNome.getText(),txtDescricao.getText(),Integer.parseInt(txtTempo.getText()),Double.parseDouble(txtValorUnit.getText()));
					JOptionPane.showMessageDialog(null, dao.alterar(tipoLocacao));
					limparCampos();
				}else {
					JOptionPane.showMessageDialog(null, "Preencha os campos obrigatórios (*)");
				}

				tblLista.setModel(dao.consulta());
			}
		});
		

		btnAlterar.setBounds(212, 407, 90, 28);
		viewTipoLocacao.getContentPane().add(btnAlterar);
		btnExcluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());
				TipoLocacao tipoLocacao = new TipoLocacao(codigoSelecionado);
				JOptionPane.showMessageDialog(null, dao.excluir(tipoLocacao));
				tblLista.setModel(dao.consulta());
				limparCampos();
			}
		});
		

		btnExcluir.setBounds(363, 407, 90, 28);
		viewTipoLocacao.getContentPane().add(btnExcluir);
	}
}

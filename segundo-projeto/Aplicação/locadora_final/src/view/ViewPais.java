package view;

import java.awt.*;
import javax.swing.*;
import javax.swing.table.*;
import javax.swing.table.TableModel;

import model.*;
import services.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class ViewPais {
	PaisDAO dao = new PaisDAO();
	private BD bd = new BD();
	private JFrame Pais;
	private JTextField txtPesquisa;
	private JTable tblLista;
	private DefaultTableModel model;	
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewPais window = new ViewPais();
					window.Pais.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ViewPais() {
		initialize();
		tblLista.setModel(dao.consulta());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		Pais = new JFrame();
		Pais.setBounds(100, 100, 718, 397);
		Pais.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		Pais.getContentPane().setLayout(null);
		
		JLabel lblPesquisar = new JLabel("Pesquisar");
		lblPesquisar.setFont(new Font("Tahoma", Font.PLAIN, 12));
		lblPesquisar.setBounds(10, 14, 69, 14);
		Pais.getContentPane().add(lblPesquisar);
		
		txtPesquisa = new JTextField();
		txtPesquisa.addKeyListener(new KeyAdapter() {
			@Override
			public void keyReleased(KeyEvent arg0) {
				if(dao.consulta(txtPesquisa.getText()) != null)
					tblLista.setModel(dao.consulta(txtPesquisa.getText()));
				else
					tblLista.setModel(new DefaultTableModel());
				}
			}
		);
		txtPesquisa.setBounds(75, 12, 600, 20);
		Pais.getContentPane().add(txtPesquisa);
		txtPesquisa.setColumns(10);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 39, 665, 257);
		Pais.getContentPane().add(scrollPane);
		
		tblLista = new JTable(model);
		tblLista.setFillsViewportHeight(true);		
		scrollPane.setViewportView(tblLista);
		
		JButton btnIncluir = new JButton("Incluir");
		btnIncluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				PaisDAO dao = new PaisDAO();
				String nome = JOptionPane.showInputDialog("Nome do País");
				if (nome == null) {
					JOptionPane.showMessageDialog(null, "Operação cancelada.");
				}else {
					Pais pais = new Pais(nome);
					JOptionPane.showMessageDialog(null, dao.salvar(pais));					
				}
				tblLista.setModel(dao.consulta());
			}
		});
		btnIncluir.setBounds(108, 307, 90, 28);
		Pais.getContentPane().add(btnIncluir);
		
		JButton btnAlterar = new JButton("Alterar");
		btnAlterar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());				
				Pais pais = new Pais(codigoSelecionado, JOptionPane.showInputDialog("Digite o nome atual"));
				int resposta = JOptionPane.showConfirmDialog(null, "Deseja realmente alterar ?");
				if (resposta == JOptionPane.YES_OPTION) {
					JOptionPane.showMessageDialog(null, dao.alterar(pais));
				}else if (resposta == JOptionPane.NO_OPTION) {
					JOptionPane.showMessageDialog(null, "Alteração não realizada.");
				}else if (resposta == JOptionPane.CANCEL_OPTION){
					JOptionPane.showMessageDialog(null, "Operação Cancelada");
				}else {
					JOptionPane.showMessageDialog(null, "Consulte o desenvolvedor");
				}
				tblLista.setModel(dao.consulta());
				
			}
		});
		btnAlterar.setBounds(306, 307, 90, 28);
		Pais.getContentPane().add(btnAlterar);
		
		JButton btnExcluir = new JButton("Excluir");
		btnExcluir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				int codigoSelecionado = Integer.parseInt(tblLista.getValueAt(tblLista.getSelectedRow(), 0).toString());
				Pais pais = new Pais(codigoSelecionado);
				JOptionPane.showMessageDialog(null, dao.excluir(pais));
				tblLista.setModel(dao.consulta());
			}
		});
		btnExcluir.setBounds(504, 307, 90, 28);
		Pais.getContentPane().add(btnExcluir);
	}
}

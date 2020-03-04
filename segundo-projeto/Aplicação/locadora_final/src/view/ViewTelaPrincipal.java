package view;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JMenuBar;
import javax.swing.JOptionPane;

import model.PadraoTela;

import javax.swing.JMenu;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JMenuItem;

public class ViewTelaPrincipal {

	private JFrame frame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		PadraoTela PadraoTela = new PadraoTela();
		PadraoTela.Nimbus();
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ViewTelaPrincipal window = new ViewTelaPrincipal();
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
	public ViewTelaPrincipal() {
		initialize();		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 827, 459);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JMenuBar menuBar = new JMenuBar();
		frame.setJMenuBar(menuBar);
		
		JMenu mnLocao = new JMenu("Loca\u00E7\u00E3o");
		mnLocao.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				ViewLocacao viewLocacao = new ViewLocacao();
				viewLocacao.main(null);
			}
		});
		menuBar.add(mnLocao);
		
		JMenu mnPessoa = new JMenu("Pessoa");
		mnPessoa.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				ViewPessoa viewPessoa = new ViewPessoa();
				viewPessoa.main(null);
			}
		});
		
		JMenu mnDevoluo = new JMenu("Devolu\u00E7\u00E3o");
		mnDevoluo.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				JOptionPane.showMessageDialog(null, "Tela em fase de desenvolvimento.");
			}
		});
		menuBar.add(mnDevoluo);
		menuBar.add(mnPessoa);
		
		JMenu mnTitulo = new JMenu("Titulo");
		mnTitulo.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				ViewProduto titulo = new ViewProduto();
				titulo.main(null);
			}
		});
		menuBar.add(mnTitulo);
		
		JMenu mnPas = new JMenu("Pa\u00EDs");
		mnPas.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				ViewPais pais = new ViewPais();
				pais.main(null);
			}
		});
		menuBar.add(mnPas);
		
		JMenu mnTipoDeLocao = new JMenu("Tipo de Loca\u00E7\u00E3o");
		mnTipoDeLocao.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				ViewTipoLocacao tipoLocacao = new ViewTipoLocacao();
				tipoLocacao.main(null);
			}
		});
		menuBar.add(mnTipoDeLocao);
		
		JMenu mnConsultas = new JMenu("Consultas");
		menuBar.add(mnConsultas);
		
		JMenu mnTituloLocadoCliente = new JMenu("Titulo Locado Cliente");
		mnTituloLocadoCliente.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				ViewConsultaClienteLocacao consultaClienteLocacao  = new ViewConsultaClienteLocacao();
				consultaClienteLocacao.main(null);
			}
		});
		mnConsultas.add(mnTituloLocadoCliente);
		frame.getContentPane().setLayout(null);
	}
}

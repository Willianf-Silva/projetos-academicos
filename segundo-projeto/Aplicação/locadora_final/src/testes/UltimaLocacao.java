package testes;

import javax.swing.JOptionPane;

import model.LocacaoDAO;

public class UltimaLocacao {

	public static void main(String[] args) {
		LocacaoDAO dao = new LocacaoDAO();
		
		int i = dao.codLocacao();
		JOptionPane.showMessageDialog(null, "Código ultima locação " + i);
	}

}

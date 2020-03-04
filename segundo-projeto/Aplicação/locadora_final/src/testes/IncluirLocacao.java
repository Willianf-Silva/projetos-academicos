package testes;

import javax.swing.JOptionPane;

import model.Locacao;
import model.LocacaoDAO;

public class IncluirLocacao {

	public static void main(String[] args) {
		Locacao locacao = new Locacao(1, 1, 45.67);
		LocacaoDAO dao = new LocacaoDAO();
		
		JOptionPane.showMessageDialog(null, dao.salvar(locacao));
	}

}

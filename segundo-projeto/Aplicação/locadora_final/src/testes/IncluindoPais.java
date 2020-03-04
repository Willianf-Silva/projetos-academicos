package testes;

import javax.swing.JOptionPane;

import model.*;

public class IncluindoPais {

	public static void main(String[] args) {		
		PaisDAO dao = new PaisDAO();
				// SALVANDO O PRODUTO E EXIBINDO A MENSAGEM DE RETORNO
		Pais pais = new Pais(JOptionPane.showInputDialog("Nome do País"));		
		JOptionPane.showMessageDialog(null, dao.salvar(pais));
	}
}

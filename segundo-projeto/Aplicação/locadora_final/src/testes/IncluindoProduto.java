package testes;

import javax.swing.JOptionPane;

import model.Produto;
import model.ProdutoDAO;

public class IncluindoProduto {

	public static void main(String[] args) {
		Produto produto = new Produto("Velozes", null, "A��o", "31-05-2018", "Willian", "Bruno", null, "Teste, Teste, Teste, Teste.", "Faz filmes", "31-05-2019", 5, "F", "Jap�o", "L", "Lan�amentos");
		ProdutoDAO dao = new ProdutoDAO();
		JOptionPane.showMessageDialog(null, dao.salvar(produto));
	}

}

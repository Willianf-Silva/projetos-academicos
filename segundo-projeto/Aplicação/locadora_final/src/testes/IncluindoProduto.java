package testes;

import javax.swing.JOptionPane;

import model.Produto;
import model.ProdutoDAO;

public class IncluindoProduto {

	public static void main(String[] args) {
		Produto produto = new Produto("Velozes", null, "Ação", "31-05-2018", "Willian", "Bruno", null, "Teste, Teste, Teste, Teste.", "Faz filmes", "31-05-2019", 5, "F", "Japão", "L", "Lançamentos");
		ProdutoDAO dao = new ProdutoDAO();
		JOptionPane.showMessageDialog(null, dao.salvar(produto));
	}

}

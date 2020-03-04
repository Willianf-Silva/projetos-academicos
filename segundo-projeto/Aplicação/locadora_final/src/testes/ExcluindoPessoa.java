package testes;

import javax.swing.JOptionPane;

import model.Pessoa;
import model.PessoaDAO;

public class ExcluindoPessoa {

	public static void main(String[] args) {
		PessoaDAO dao = new PessoaDAO();
		Pessoa pessoa = new Pessoa(2);
		JOptionPane.showMessageDialog(null, dao.excluir(pessoa));
	}

}

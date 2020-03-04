package testes;

import javax.swing.JOptionPane;

import model.Pessoa;
import model.PessoaDAO;

public class AlterandoPessoa {

	public static void main(String[] args) {
		PessoaDAO dao = new PessoaDAO();		
		Pessoa pessoa = new Pessoa(1,"Willian", "Silva", "42176524888", null, "39357793", "rua 02", "Nova veneza", "13348772", "Karen@karen.com.br", "31-05-1993", "F");
		JOptionPane.showMessageDialog(null, dao.alterar(pessoa));
	}

}

package testes;

import javax.swing.JOptionPane;

import model.Pais;
import model.PaisDAO;
import model.Pessoa;
import model.PessoaDAO;

public class IncluindoPessoa {

	public static void main(String[] args) {
		PessoaDAO dao = new PessoaDAO();
		// INCLUINDO CLIENTES NO BANCO
		for (int a = 1; a < 30; a++) {
			Pessoa pessoa = new Pessoa("Paulo", "Silva", "4092513682"+a, null, "39357793", "rua 02", "Nova veneza", "13348772", "Karen@karen.com.br", "31-05-1993", "F");		
			JOptionPane.showMessageDialog(null, dao.salvar(pessoa));	
		}
		
	}

}

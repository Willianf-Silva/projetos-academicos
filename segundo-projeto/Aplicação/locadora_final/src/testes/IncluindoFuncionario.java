package testes;

import javax.swing.JOptionPane;

import model.Funcionario;
import model.FuncionarioDAO;

public class IncluindoFuncionario {

	public static void main(String[] args) {
		FuncionarioDAO dao = new FuncionarioDAO();
		// INCLUINDO FUNCIONARIOS NO BANCO
		for (int a = 1; a < 30; a++) {
			Funcionario funcionario = new Funcionario("Paulo", "Silva", "409251368"+a, null, "39357793", "rua 02", "Nova veneza", "13348772", "Karen@karen.com.br", "31-05-1993", "F","Willian","017166");		
			JOptionPane.showMessageDialog(null, dao.salvar(funcionario));	
		}
	}

}

package testes;

import javax.swing.JOptionPane;

import model.Funcionario;
import model.FuncionarioDAO;

public class AlterandoFuncionario {

	public static void main(String[] args) {
		FuncionarioDAO dao = new FuncionarioDAO();
		
			Funcionario funcionario = new Funcionario(2,"Paulo", "Silva", "40925136824", null, "39357793", "rua 02", "Nova veneza", "13348772", "Karen@karen.com.br", "31-05-1993", "F","Willian","017166");		
			JOptionPane.showMessageDialog(null, dao.alterar(funcionario));
	}
}

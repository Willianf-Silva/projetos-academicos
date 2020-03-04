package testes;

import javax.swing.JOptionPane;

import model.Funcionario;
import model.FuncionarioDAO;

public class ExcluindoFuncionario {

	public static void main(String[] args) {
		FuncionarioDAO dao = new FuncionarioDAO();
		Funcionario funcionario = new Funcionario(2);
		JOptionPane.showMessageDialog(null, dao.excluir(funcionario));
	}

}

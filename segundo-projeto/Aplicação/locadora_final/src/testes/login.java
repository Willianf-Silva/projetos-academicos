package testes;

import model.Funcionario;
import model.LoginDAO;

public class login {

	public static void main(String[] args) {
		Funcionario funcionario = new Funcionario();
		funcionario.setLogin("Bruno");
		funcionario.setSenha("0171666");
		LoginDAO dao = new LoginDAO();
		System.out.println(dao.logar(funcionario));
	}

}

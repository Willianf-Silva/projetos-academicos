package model;

import javax.swing.table.DefaultTableModel;

public interface FuncionarioInterface {
	String salvar(Funcionario funcionario);
	String alterar(Funcionario funcionario);
	String excluir(Funcionario funcionario);		
}

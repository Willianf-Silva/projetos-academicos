package model;

import javax.swing.table.DefaultTableModel;

public interface PaisInterface {
	String salvar(Pais pais);
	String alterar(Pais pais);
	String excluir(Pais pais);
	DefaultTableModel consulta();
	DefaultTableModel consulta(String nome);
}

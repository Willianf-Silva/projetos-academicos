package model;

import javax.swing.table.DefaultTableModel;

public interface ItemLocacaoInterface {
	DefaultTableModel consulta();
	String salvar(ItemLocacao itemLocacao);
	void incluir (ItemLocacao itemLocacao);
}

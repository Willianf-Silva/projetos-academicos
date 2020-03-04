package model;

import javax.swing.DefaultComboBoxModel;
import javax.swing.table.DefaultTableModel;
import model.Produto;

public interface ProdutoInterface {
	String salvar(Produto produto);
	String alterar(Produto produto);
	String excluir(Produto produto);
	DefaultTableModel consulta();
	DefaultTableModel consulta(String nome);
	DefaultComboBoxModel popularCbTipoLocacao();
	DefaultComboBoxModel popularCbPaisOrigem();
}

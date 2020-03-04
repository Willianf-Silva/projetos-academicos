package model;

import javax.swing.table.DefaultTableModel;

public interface TipoLocacaoInterface {
	String salvar(TipoLocacao tipoLocacao);
	String alterar(TipoLocacao tipoLocacao);
	String excluir(TipoLocacao tipoLocacao);
	DefaultTableModel consulta();
	DefaultTableModel consulta(String nome);
}
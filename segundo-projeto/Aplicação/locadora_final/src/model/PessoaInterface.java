package model;

import javax.swing.table.DefaultTableModel;

public interface PessoaInterface {
	String salvar(Pessoa pessoa);
	String alterar(Pessoa pessoa);
	String excluir(Pessoa pessoa);
	DefaultTableModel consulta(String tipoPessoa);
	DefaultTableModel consulta(String nome, String tipoPessoa);
	DefaultTableModel consultaocacoes(String nome);
}

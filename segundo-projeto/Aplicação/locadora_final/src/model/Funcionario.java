package model;

import javax.swing.table.DefaultTableModel;

public class Funcionario extends Pessoa {
	private String login;
	private String senha;
	
	/**
	 * Método construtor padrão
	 */
	public Funcionario() {	
	}
	
	/**
	 * Métodos contrutor responsável por receber o código do funcionário
	 * @param codigo
	 */
	public Funcionario(int codigo) {
		super.setCodigo(codigo);
	}

	/**
	 * Método construtor com todos os parametros incluindo codigo
	 * @param codigo
	 * @param nome
	 * @param sobrenome
	 * @param cpf
	 * @param foto
	 * @param telefone
	 * @param endereco
	 * @param bairro
	 * @param cep
	 * @param email
	 * @param nascimento
	 * @param genero
	 * @param login
	 * @param senha
	 */
	public Funcionario(
			int codigo,
			String nome,
			String sobrenome,
			String cpf,
			String foto,
			String telefone,
			String endereco,
			String bairro,
			String cep,
			String email,
			String nascimento,
			String genero,
			String login,
			String senha) {
		super.setCodigo(codigo);
		super.setNome(nome);
		super.setSobrenome(sobrenome);
		super.setCpf(cpf);
		super.setFoto(foto);
		super.setTelefone(telefone);
		super.setEndereco(endereco);
		super.setBairro(bairro);
		super.setCep(cep);
		super.setEmail(email);
		super.setNascimento(nascimento);
		super.setGenero(genero);		
		this.login = login;
		this.senha = senha;
	}
	
	/**
	 * Método construtor com todos os parametros exceto codigo
	 * @param nome
	 * @param sobrenome
	 * @param cpf
	 * @param foto
	 * @param telefone
	 * @param endereco
	 * @param bairro
	 * @param cep
	 * @param email
	 * @param nascimento
	 * @param genero
	 * @param login
	 * @param senha
	 */
	public Funcionario(
			String nome,
			String sobrenome,
			String cpf,
			String foto,
			String telefone,
			String endereco,
			String bairro,
			String cep,
			String email,
			String nascimento,
			String genero,
			String login,
			String senha) {
		super.setNome(nome);
		super.setSobrenome(sobrenome);
		super.setCpf(cpf);
		super.setFoto(foto);
		super.setTelefone(telefone);
		super.setEndereco(endereco);
		super.setBairro(bairro);
		super.setCep(cep);
		super.setEmail(email);
		super.setNascimento(nascimento);
		super.setGenero(genero);		
		this.login = login;
		this.senha = senha;
	}

	public String getLogin() {
		return login;
	}

	public void setLogin(String login) {
		this.login = login;
	}

	public String getSenha() {
		return senha;
	}

	public void setSenha(String senha) {
		this.senha = senha;
	}
	
	
}

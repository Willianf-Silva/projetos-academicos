package model;

import javax.swing.table.DefaultTableModel;

public class Pessoa {
	private int codigo;
	private String nome;
	private String sobrenome;
	private String cpf;
	private String foto;
	private String telefone;
	private String endereco;
	private String bairro;
	private String cep;
	private String email;
	private String nascimento;
	private String genero;
	
	/**
	 * Método construtor padrão
	 */
	public Pessoa() {
	}
	



	/**
	 * Método construtor responsável por receber o código da pessoa
	 * @param codigo
	 */
	public Pessoa(int codigo) {
		super();
		this.codigo = codigo;
	}





	/**
	 * Método contrutor com todos os parametros incluindo código
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
	 */
		public Pessoa(int codigo, String nome, String sobrenome, String cpf, String foto, String telefone,
			String endereco, String bairro, String cep, String email, String nascimento, String genero) {
		this.codigo = codigo;
		this.nome = nome;
		this.sobrenome = sobrenome;
		this.cpf = cpf;
		this.foto = foto;
		this.telefone = telefone;
		this.endereco = endereco;
		this.bairro = bairro;
		this.cep = cep;
		this.email = email;
		this.nascimento = nascimento;
		this.genero = genero;
	}





/**
 * Método contrutor com todos os parametros exceto código
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
 */
	public Pessoa(String nome, String sobrenome, String cpf, String foto, String telefone, String endereco,
			String bairro, String cep, String email, String nascimento, String genero) {		
		this.nome = nome;
		this.sobrenome = sobrenome;
		this.cpf = cpf;
		this.foto = foto;
		this.telefone = telefone;
		this.endereco = endereco;
		this.bairro = bairro;
		this.cep = cep;
		this.email = email;
		this.nascimento = nascimento;
		this.genero = genero;
	}



	public int getCodigo() {
		return codigo;
	}

	public void setCodigo(int codigo) {
		this.codigo = codigo;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getSobrenome() {
		return sobrenome;
	}

	public void setSobrenome(String sobrenome) {
		this.sobrenome = sobrenome;
	}

	public String getCpf() {
		return cpf;
	}

	public void setCpf(String cpf) {
		this.cpf = cpf;
	}

	public String getFoto() {
		return foto;
	}

	public void setFoto(String foto) {
		this.foto = foto;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

	public String getEndereco() {
		return endereco;
	}

	public void setEndereco(String endereco) {
		this.endereco = endereco;
	}

	public String getBairro() {
		return bairro;
	}

	public void setBairro(String bairro) {
		this.bairro = bairro;
	}

	public String getCep() {
		return cep;
	}

	public void setCep(String cep) {
		this.cep = cep;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getNascimento() {
		return nascimento;
	}

	public void setNascimento(String nascimento) {
		this.nascimento = nascimento;
	}

	public String getGenero() {
		return genero;
	}

	public void setGenero(String genero) {
		this.genero = genero;
	}
}

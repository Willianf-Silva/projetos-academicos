package model;

public class TipoLocacao {
	private int codigo;	 
	private String nome;	 
	private String descricao;	 
	private int tempo;	 
	private double valorUnit;
	
	/**
	 * M�todo contrutor padr�o
	 */
	public TipoLocacao() {
	}
	
	
	/**
	 * M�todo contrutor que recebe o c�digo como parametro
	 * @param codigo
	 */
	public TipoLocacao(int codigo) {
		this.codigo = codigo;
	}


	/**
	 * M�todo contrutor com todos os parametros exceto c�digo
	 * @param nome
	 * @param descricao
	 * @param tempo
	 * @param valorUnit
	 */
	public TipoLocacao(String nome, String descricao, int tempo, double valorUnit) {
		this.nome = nome;
		this.descricao = descricao;
		this.tempo = tempo;
		this.valorUnit = valorUnit;
	}
	
	
	
	/**
	 * M�todo contrutor com todos os parametros incluindo c�digo
	 * @param codigo
	 * @param nome
	 * @param descricao
	 * @param tempo
	 * @param valorUnit
	 */
	public TipoLocacao(int codigo, String nome, String descricao, int tempo, double valorUnit) {
		super();
		this.codigo = codigo;
		this.nome = nome;
		this.descricao = descricao;
		this.tempo = tempo;
		this.valorUnit = valorUnit;
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
	public String getDescricao() {
		return descricao;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	public int getTempo() {
		return tempo;
	}
	public void setTempo(int tempo) {
		this.tempo = tempo;
	}
	public double getValorUnit() {
		return valorUnit;
	}
	public void setValorUnit(double valorUnit) {
		this.valorUnit = valorUnit;
	}
	
	
}

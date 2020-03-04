package model;

public class Pais {

	private int codigo;	 
	private String nome;

	public Pais() {
		// TODO Auto-generated constructor stub
	}
	
	public Pais(int codigo) {
		this.codigo = codigo;		
	}
	
	public Pais(int codigo, String nome) {
		this.codigo = codigo;
		this.nome = nome;
	}

	public Pais(String nome) {
		this.nome = nome;
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
	 
}

package model;

public class ItemLocacao {
	private int codMidia;
	private int codLocacao;
	
	public ItemLocacao() {
	}
	
	
	
	/**
	 * Construtor apenas com o codigo da midia
	 * @param codMidia
	 */
	public ItemLocacao(int codMidia) {
		this.codMidia = codMidia;
	}



	/**
	 * Construtor para incluir uma midia
	 * @param codMidia
	 * @param codLocacao
	 */
	public ItemLocacao(int codLocacao, int codMidia) {
		this.codMidia = codMidia;
		this.codLocacao = codLocacao;
	}
	
	

	public int getCodMidia() {
		return codMidia;
	}
	public void setCodMidia(int codMidia) {
		this.codMidia = codMidia;
	}
	public int getCodLocacao() {
		return codLocacao;
	}
	public void setCodLocacao(int codLocacao) {
		this.codLocacao = codLocacao;
	}
	
	
	
}

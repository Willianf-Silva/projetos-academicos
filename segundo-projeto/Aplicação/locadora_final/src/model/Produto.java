package model;

import java.util.Date;

public class Produto {
	private int codigo;	 
	private String nome;	 
	private String capa;	 
	private String genero;	 
	private String dataLancamento;		 
	private String ator;	 
	private String diretor;	 
	private String duracao;	 
	private String sinopse;	 
	private String produtora;	 
	private String dataCompra;	 
	private int quantidadeDVD;	 
	private String tipo; // S�rie ou filme "Se for s�rie envia para o banco s, se for filme f
	private String paisNome;
	private String midiaTipo; // Legendado ou Dublado, ou seja, l ou d
	private String tipoLocacaoNome;
	
	/**
	 * M�todo contrutor padr�o
	 */
	public Produto() {
	}
	
	/**
	 * M�todo construtor com passagem do parametro c�digo. Utilizado para excluir um produto
	 * @param codigo
	 */
	public Produto(int codigo) {
		this.codigo = codigo;
	}

	/**
	 * M�todo construtor com todos os parametros, incluindo c�digo. Utilizado para alterar um produto
	 * @param codigo
	 * @param nome
	 * @param capa
	 * @param genero
	 * @param dataLancamento
	 * @param ator
	 * @param diretor
	 * @param duracao
	 * @param sinopse
	 * @param produtora
	 * @param dataCompra
	 * @param quantidadeDVD
	 * @param tipo
	 * @param paisNome
	 * @param midiaTipo
	 * @param tipoLocacaoNome
	 */
	public Produto(int codigo, String nome, String capa, String genero, String dataLancamento, String ator,
			String diretor, String duracao, String sinopse, String produtora, String dataCompra, int quantidadeDVD,
			String tipo, String paisNome, String midiaTipo, String tipoLocacaoNome) {
		this.codigo = codigo;
		this.nome = nome;
		this.capa = capa;
		this.genero = genero;
		this.dataLancamento = dataLancamento;
		this.ator = ator;
		this.diretor = diretor;
		this.duracao = duracao;
		this.sinopse = sinopse;
		this.produtora = produtora;
		this.dataCompra = dataCompra;
		this.quantidadeDVD = quantidadeDVD;
		this.tipo = tipo;
		this.paisNome = paisNome;
		this.midiaTipo = midiaTipo;
		this.tipoLocacaoNome = tipoLocacaoNome;
	}
	
	/**
	 * M�todo construtor com todos os parametros, exceto c�digo. Utilizado para incluir um novo produto
	 * @param nome
	 * @param capa
	 * @param genero
	 * @param dataLancamento
	 * @param ator
	 * @param diretor
	 * @param duracao
	 * @param sinopse
	 * @param produtora
	 * @param dataCompra
	 * @param quantidadeDVD
	 * @param tipo
	 * @param paisNome
	 * @param midiaTipo
	 * @param tipoLocacaoNome
	 */
	public Produto(String nome, String capa, String genero, String dataLancamento, String ator, String diretor,
			String duracao, String sinopse, String produtora, String dataCompra, int quantidadeDVD, String tipo,
			String paisNome, String midiaTipo, String tipoLocacaoNome) {
		this.nome = nome;
		this.capa = capa;
		this.genero = genero;
		this.dataLancamento = dataLancamento;
		this.ator = ator;
		this.diretor = diretor;
		this.duracao = duracao;
		this.sinopse = sinopse;
		this.produtora = produtora;
		this.dataCompra = dataCompra;
		this.quantidadeDVD = quantidadeDVD;
		this.tipo = tipo;
		this.paisNome = paisNome;
		this.midiaTipo = midiaTipo;
		this.tipoLocacaoNome = tipoLocacaoNome;
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

	public String getCapa() {
		return capa;
	}

	public void setCapa(String capa) {
		this.capa = capa;
	}

	public String getGenero() {
		return genero;
	}

	public void setGenero(String genero) {
		this.genero = genero;
	}

	public String getDataLancamento() {
		return dataLancamento;
	}

	public void setDataLancamento(String dataLancamento) {
		this.dataLancamento = dataLancamento;
	}

	public String getAtor() {
		return ator;
	}

	public void setAtor(String ator) {
		this.ator = ator;
	}

	public String getDiretor() {
		return diretor;
	}

	public void setDiretor(String diretor) {
		this.diretor = diretor;
	}

	public String getDuracao() {
		return duracao;
	}

	public void setDuracao(String duracao) {
		this.duracao = duracao;
	}

	public String getSinopse() {
		return sinopse;
	}

	public void setSinopse(String sinopse) {
		this.sinopse = sinopse;
	}

	public String getProdutora() {
		return produtora;
	}

	public void setProdutora(String produtora) {
		this.produtora = produtora;
	}

	public String getDataCompra() {
		return dataCompra;
	}

	public void setDataCompra(String dataCompra) {
		this.dataCompra = dataCompra;
	}

	public int getQuantidadeDVD() {
		return quantidadeDVD;
	}

	public void setQuantidadeDVD(int quantidadeDVD) {
		this.quantidadeDVD = quantidadeDVD;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getPaisNome() {
		return paisNome;
	}

	public void setPaisNome(String paisNome) {
		this.paisNome = paisNome;
	}

	public String getMidiaTipo() {
		return midiaTipo;
	}

	public void setMidiaTipo(String midiaTipo) {
		this.midiaTipo = midiaTipo;
	}

	public String getTipoLocacaoNome() {
		return tipoLocacaoNome;
	}

	public void setTipoLocacaoNome(String tipoLocacaoNome) {
		this.tipoLocacaoNome = tipoLocacaoNome;
	}
	
	
	
}

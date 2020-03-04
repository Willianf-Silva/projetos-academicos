package model;

import java.util.Date;

public class Locacao {
	private int codigo;	 
	private int codCliente;
	private int codFuncionario;
	private String data;	 
	private double valorTotal;	 
	private double valorPago;	
	private int[] arrayItem[]; // array para guardar todos os itens.
	
	public Locacao() {
		
	}
	
	
	
	/**
	 * Construtor para incluir uma nova locação
	 * @param codCliente
	 * @param codFuncionario
	 * @param valorPago
	 */
	public Locacao(int codCliente, int codFuncionario, double valorPago) {
		this.codCliente = codCliente;
		this.codFuncionario = codFuncionario;
		this.valorPago = valorPago;
	}




	/**
	 * Construtor com todos os campos, exceto o código da locação
	 * @param cliente
	 * @param funcionario
	 * @param data
	 * @param valorTotal
	 * @param valorPago
	 * @param arrayItem
	 */
	public Locacao(int codCliente, int codFuncionario, String data, double valorTotal, double valorPago,
			int[][] arrayItem) {
		this.codCliente = codCliente;
		this.codFuncionario = codFuncionario;
		this.data = data;
		this.valorTotal = valorTotal;
		this.valorPago = valorPago;
		this.arrayItem = arrayItem;
	}

	
	

	/**
	 * Método construtor passando apenas o código por parametro
	 * @param codigo
	 */
	public Locacao(int codigo) {
		this.codigo = codigo;
	}


	public int getCodigo() {
		return codigo;
	}


	public void setCodigo(int codigo) {
		this.codigo = codigo;
	}


	public int getCodCliente() {
		return codCliente;
	}


	public void setCodCliente(int codCliente) {
		this.codCliente = codCliente;
	}


	public int getCodFuncionario() {
		return codFuncionario;
	}


	public void setCodFuncionario(int codFuncionario) {
		this.codFuncionario = codFuncionario;
	}


	public String getData() {
		return data;
	}


	public void setData(String data) {
		this.data = data;
	}


	public double getValorTotal() {
		return valorTotal;
	}


	public void setValorTotal(double valorTotal) {
		this.valorTotal = valorTotal;
	}


	public double getValorPago() {
		return valorPago;
	}


	public void setValorPago(double valorPago) {
		this.valorPago = valorPago;
	}


	public int[][] getArrayItem() {
		return arrayItem;
	}


	public void setArrayItem(int[][] arrayItem) {
		this.arrayItem = arrayItem;
	}


	
	
	
}
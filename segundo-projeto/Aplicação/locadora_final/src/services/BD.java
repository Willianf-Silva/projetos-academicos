package services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class BD {

	// realizar a conexao
	public Connection con = null;
	// executar instruções em SQL
	public PreparedStatement st = null;
	// simula uma tabela em memória
	public ResultSet rs = null;
	
	private final String LOGIN = "Willian";
	private final String SENHA = "017166";
	private final String DRIVER = 
	"com.microsoft.sqlserver.jdbc.SQLServerDriver";
	private final String DATABASE = "Locadora";
	private final String URL =
		"jdbc:sqlserver://localhost:1433;"
		+ "databaseName="+DATABASE;
	
	public boolean getConnection() {
		try {
			Class.forName(DRIVER);
			con = 
			 DriverManager.getConnection(URL,LOGIN,SENHA);
			//System.out.println("Conectou...");
			return true;
		}
		catch(ClassNotFoundException erro) {
			System.out.println("Driver não encontrado");
			return false;
		}
		catch(SQLException erro) {
			System.out.println("Erro "+erro.toString());
			return false;
		}
		
	}
	public void close() {
		try {
			if(rs!=null) rs.close();
		} 
		catch(SQLException erro) {}
		try {
			if(st!=null) st.close();
		} 
		catch(SQLException erro) {}
		try {
			if(con!=null) {
				con.close();
				//System.out.println("Desconectou...");
			}
		} 
		catch(SQLException erro) {}
		
	}
	public static void main(String[] args) {
		BD bd = new BD();
		bd.getConnection();
		bd.close();
	}
}

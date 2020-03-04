package model;

import java.sql.*;
import javax.swing.*;
import javax.swing.table.*;

import model.TableModel;
import services.BD;

public class PaisDAO implements PaisInterface{
	Pais pais = new Pais();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;
	
	/**
	 * Métodos responsável por receber o nome do país e realizar toda a operação de inclusão no banco de dados
	 */
	@Override
	public String salvar(Pais pais) {
		String sql = "sp_novoPais ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setString(1, pais.getNome());
				bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				mensagem = "Dados inseridos com sucesso!";
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}
			
		} catch (SQLException erro) {
			mensagem = "Falha" + erro.toString();
		}finally {
			bd.close();
		}
		return mensagem;		
	}

	@Override
	public String alterar(Pais pais) {
		String sql = "EXEC sp_alterarPais ?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, pais.getCodigo());
				bd.st.setString(2, pais.getNome());
				bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				mensagem = "Dados alterados com sucesso!";
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}
			
		} catch (SQLException erro) {
			mensagem = "Falha" + erro.toString();
		}finally {
			bd.close();
		}
		return mensagem;
	}

	@Override
	public String excluir(Pais pais) {
		String sql = "DELETE FROM PAIS WHERE Pais_Codigo = ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, pais.getCodigo());
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				if(r==1)
					mensagem = "Exclusão realizada com sucesso";
				else
					mensagem = "Produto não encontrado";
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}
			
		} catch (SQLException erro) {
			mensagem = "Falha" + erro.toString();
		}finally {
			bd.close();
		}
		return mensagem;
	}

	@Override
	public DefaultTableModel consulta() {		
		try {
			if(bd.getConnection()) {
				String sql = "SELECT * FROM Pais";			
				model = TableModel.getModel(bd, sql); // classe criada pelo sérgio para trazer os dados em uma JTABLE			
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
			}
				
		} catch (Exception erro) {
			JOptionPane.showMessageDialog(null, "Falha" + erro.toString());
		}finally {
			bd.close();
		}
		return model;
	}

	@Override
	public DefaultTableModel consulta(String nome) {		
		try {
			if(bd.getConnection()) {
				String sql = "SELECT * FROM Pais WHERE Pais_Nome LIKE '"+nome+"%'";				
				model = TableModel.getModel(bd, sql); // classe criada pelo sérgio para trazer os dados em uma JTABLE
			
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
			}
				
		} catch (Exception erro) {
			JOptionPane.showMessageDialog(null, erro);
		}finally {
			bd.close();
		}
		return model;		
	}
}

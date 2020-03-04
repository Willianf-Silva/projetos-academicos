package model;

import java.sql.SQLException;

import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

import services.BD;

public class TipoLocacaoDAO implements TipoLocacaoInterface{
	TipoLocacao tipoLocacao = new TipoLocacao();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;
	
	@Override
	public String salvar(TipoLocacao tipoLocacao) {
		String sql = "EXEC sp_novoTipoLocacao ?,?,?,?";
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setString(1, tipoLocacao.getNome());
				bd.st.setString(2, tipoLocacao.getDescricao());
				bd.st.setInt(3, tipoLocacao.getTempo());
				bd.st.setDouble(4, tipoLocacao.getValorUnit());
								
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				
				if(r >= 1) {
					mensagem = "Dados inseridos com sucesso!";
				}
				else {
					mensagem = "Operação cancelada. Verifique se o nome já está cadastrado";
				}
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
	public String alterar(TipoLocacao tipoLocacao) {
		String sql = "EXEC sp_alterarTipoLocacao ?,?,?,?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, tipoLocacao.getCodigo());
				bd.st.setString(2, tipoLocacao.getNome());
				bd.st.setString(3, tipoLocacao.getDescricao());
				bd.st.setInt(4, tipoLocacao.getTempo());				
				bd.st.setDouble(5, tipoLocacao.getValorUnit());
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Dados alterados com sucesso!";
				}else {
					mensagem = "Operação cancelada. Favor selecionar um tipo válido.";
				}
								
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
	public String excluir(TipoLocacao tipoLocacao) {
		String sql = "DELETE FROM TipoLocacao WHERE TipoLocacao_Codigo = ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, tipoLocacao.getCodigo());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Tipo de locação excluido com sucesso!";
				}else {
					mensagem = "Operação cancelada. Selecione o tipo de locação que deseja excluir.";
				}
				
								
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
				String sql = "SELECT * FROM TipoLocacao";			
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
				String sql = "SELECT * FROM TipoLocacao WHERE TipoLocacao_Nome LIKE '"+ nome +"%'";
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
	
}

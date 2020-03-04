package model;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

import services.BD;

public class ProdutoDAO implements ProdutoInterface {
	Produto produto = new Produto();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;


	@Override
	public String salvar(Produto produto) {
		String sql = "EXEC sp_novoTitulo ?,?,?,?,?,?,?,?,?,?,?,?,?,?,?";

		try {			

			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setString(1, produto.getNome());
				bd.st.setString(2, produto.getCapa());
				bd.st.setString(3, produto.getGenero());
				bd.st.setString(4, produto.getDataLancamento());
				bd.st.setString(5, produto.getAtor());
				bd.st.setString(6, produto.getDiretor());
				bd.st.setString(7, produto.getDuracao());
				bd.st.setString(8, produto.getSinopse());
				bd.st.setString(9, produto.getProdutora());
				bd.st.setString(10, produto.getDataCompra());
				bd.st.setInt(11, produto.getQuantidadeDVD());
				bd.st.setString(12, produto.getTipo());
				bd.st.setString(13, produto.getPaisNome()); // Verificar pois é objeto TipoLocacao
				bd.st.setString(14, produto.getMidiaTipo());
				bd.st.setString(15, produto.getTipoLocacaoNome()); // Verificar pois é objeto TipoLocacao

				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas

				if(r >= 1) {
					mensagem = "Dados inseridos com sucesso!";
				}
				else {
					mensagem = "Operação cancelada.";
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
	public String alterar(Produto produto) {
		String sql = "EXEC sp_alterarTitulo ?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, produto.getCodigo());
				bd.st.setString(2, produto.getNome());
				bd.st.setString(3, produto.getCapa());
				bd.st.setString(4, produto.getGenero());
				bd.st.setString(5, produto.getDataLancamento());
				bd.st.setString(6, produto.getAtor());
				bd.st.setString(7, produto.getDiretor());
				bd.st.setString(8, produto.getDuracao());
				bd.st.setString(9, produto.getSinopse());
				bd.st.setString(10, produto.getProdutora());
				bd.st.setString(11, produto.getDataCompra());
				bd.st.setInt(12, produto.getQuantidadeDVD());
				bd.st.setString(13, produto.getTipo());
				bd.st.setString(14, produto.getPaisNome()); // Verificar pois é objeto TipoLocacao
				bd.st.setString(15, produto.getMidiaTipo());
				bd.st.setString(16, produto.getTipoLocacaoNome()); // Verificar pois é objeto TipoLocacao				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Dados alterados com sucesso!";
				}else {
					mensagem = "Operação cancelada. Selecione um titulo válido.";
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
	public String excluir(Produto produto) {
		String sql = "EXEC sp_excluirTitulo ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, produto.getCodigo());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r >= 1) {
					mensagem = "Cliente excluido com sucesso!";
				}else {
					mensagem = "Operação cancelada. Selecione o cliente que deseja excluir.";
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
				String sql = "SELECT * FROM vwTitulos";			
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
				String sql = "SELECT T.Titulo_Codigo AS Codigo,\r\n" + 
						"T.Titulo_Nome AS Nome,\r\n" + 
						"T.Titulo_Genero AS Genero, \r\n" + 
						"Convert(varchar(10),T.Titulo_DataLancamento,103) AS Lançamento,\r\n" + 
						"T.Titulo_Ator AS Atores, \r\n" + 
						"T.Titulo_Diretor AS Diretor, \r\n" + 
						"Convert(varchar(10),T.Titulo_Duracao,108) AS Duração, \r\n" + 
						"T.Titulo_Sinopse AS Sinopse, \r\n" + 
						"T.Titulo_Produtora AS Produtora,\r\n" + 
						"Convert(varchar(10),T.Titulo_DataCompra,103) AS Compra, \r\n" + 
						"T.Titulo_Quantidade AS Quantidade, \r\n" + 
						"T.Titulo_Tipo AS Tipo, \r\n" + 
						"P.Pais_Nome AS Pais, \r\n" + 
						"T.Titulo_Midia_Tipo AS Midia, \r\n" + 
						"TL.TipoLocacao_Nome AS TipoLocação\r\n" + 
						"FROM Titulo T\r\n" + 
						"INNER JOIN Pais P\r\n" + 
						"ON T.Pais_Codigo = P.Pais_Codigo\r\n" + 
						"INNER JOIN TipoLocacao TL\r\n" + 
						"ON T.Titulo_TipoLocacao_Codigo = TL.TipoLocacao_Codigo\r\n" + 
						"WHERE Titulo_Nome LIKE '"+nome+"%'";				
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

	
	/**
	 * Método responsável por acessar o banco de dados e trazer todos os valores contidos no campo TipoLocacao_Nome
	 * @return - lista de todos os nomes cadastrados no tipo de locação.
	 */
	@Override
	public DefaultComboBoxModel popularCbTipoLocacao(){
		List<String> strList = new ArrayList<String>();

		String sql = "SELECT * FROM TipoLocacao";
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.rs = bd.st.executeQuery();
				
				while(bd.rs.next()){

					strList.add(bd.rs.getString("TipoLocacao_Nome"));
				}
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}
		} catch (Exception e) {
			// TODO: handle exception
		}finally {
			bd.close();
		}
		DefaultComboBoxModel defaultComboBox = new DefaultComboBoxModel(strList.toArray());
		return defaultComboBox;
	}
	
	/**
	 * Método responsável por acessar o banco de dados e trazer todos os valores contidos no campo Pais_Nome
	 * @return - lista de todos os nomes cadastrados no pais.
	 */
	@Override
	public DefaultComboBoxModel popularCbPaisOrigem(){
		List<String> strList = new ArrayList<String>();

		String sql = "SELECT * FROM Pais";
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.rs = bd.st.executeQuery();
				
				while(bd.rs.next()){

					strList.add(bd.rs.getString("Pais_Nome"));
				}
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}
		} catch (Exception e) {
			// TODO: handle exception
		}finally {
			bd.close();
		}
		DefaultComboBoxModel defaultComboBox = new DefaultComboBoxModel(strList.toArray());
		return defaultComboBox;
	}
	
}

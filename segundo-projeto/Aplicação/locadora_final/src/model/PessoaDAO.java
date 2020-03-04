package model;

import java.sql.SQLException;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import services.*;

public class PessoaDAO implements PessoaInterface {
	Pessoa pessoa = new Pessoa();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;
	
	/**
	 * Incluir um cliente no banco de dados
	 */
	@Override
	public String salvar(Pessoa pessoa) {
		String sql = "EXEC sp_novoCliente ?,?,?,?,?,?,?,?,?,?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setString(1, pessoa.getNome());
				bd.st.setString(2, pessoa.getSobrenome());
				bd.st.setString(3, pessoa.getCpf());
				bd.st.setString(4, pessoa.getFoto());
				bd.st.setString(5, pessoa.getTelefone());
				bd.st.setString(6, pessoa.getEndereco());
				bd.st.setString(7, pessoa.getBairro());
				bd.st.setString(8, pessoa.getCep());
				bd.st.setString(9, pessoa.getEmail());
				bd.st.setString(10, pessoa.getNascimento());
				bd.st.setString(11, pessoa.getGenero());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				
				if(r >= 1) {
					mensagem = "Dados inseridos com sucesso!";
				}
				else {
					mensagem = "Operação cancelada. Verifique se o CPF "+pessoa.getCpf()+" já possui cadastro.";
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

	
	
	/**
	 * Alterando dados no banco de dados
	 */
	@Override
	public String alterar(Pessoa pessoa) {
		String sql = "EXEC sp_alterarCliente ?,?,?,?,?,?,?,?,?,?,?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, pessoa.getCodigo());
				bd.st.setString(2, pessoa.getNome());
				bd.st.setString(3, pessoa.getSobrenome());
				bd.st.setString(4, pessoa.getCpf());
				bd.st.setString(5, pessoa.getFoto());
				bd.st.setString(6, pessoa.getTelefone());
				bd.st.setString(7, pessoa.getEndereco());
				bd.st.setString(8, pessoa.getBairro());
				bd.st.setString(9, pessoa.getCep());
				bd.st.setString(10, pessoa.getEmail());
				bd.st.setString(11, pessoa.getNascimento());
				bd.st.setString(12, pessoa.getGenero());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Dados alterados com sucesso!";
				}else {
					mensagem = "Operação cancelada. Favor verificar se o CPF " + pessoa.getCpf() + " já possui cadastro.";
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

	
	/**
	 * Método responsável por excluir um cliente de acordo com o código recebido
	 */
	@Override
	public String excluir(Pessoa pessoa) {
		String sql = "DELETE FROM Cliente WHERE Cliente_Codigo = ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, pessoa.getCodigo());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
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
	public DefaultTableModel consulta(String tipoPessoa) {
		try {
			if(bd.getConnection()) {
				String sql = null;
				
				if (tipoPessoa == "Cliente") {
					sql = "SELECT * FROM vwClientes";
				}else{
					sql = "SELECT * FROM vwFuncionarios";
				}
			
			model = TableModel.getModel(bd, sql); // classe criada pelo sérgio para trazer os dados em uma JTABLE
			
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
			}
				
		} catch (Exception e) {
			// TODO: handle exception
		}finally {
			bd.close();
		}
		return model;


	}


	@Override
	public DefaultTableModel consulta(String nome, String tipoPessoa) {
		try {
			if(bd.getConnection()) {
				String sql = null;
				
				if (tipoPessoa == "Cliente") {
					sql = "SELECT\r\n" + 
							"Cliente_Codigo AS Código,\r\n" + 
							"Cliente_Nome AS Nome,\r\n" + 
							"Cliente_Sobrenome AS Sobrenome,\r\n" + 
							"Cliente_CPF AS CPF,\r\n" + 
							"Cliente_Foto AS Foto,\r\n" + 
							"Cliente_Telefone AS Telefone,\r\n" + 
							"Cliente_Endereco AS Endereço,\r\n" + 
							"Cliente_Bairro AS Bairro,\r\n" + 
							"Cliente_Cep AS Cep,\r\n" + 
							"Cliente_Email AS Email,\r\n" + 
							"Convert(varchar(10),Cliente_Nascimento,103) AS Nascimento,\r\n" + 
							"Cliente_Genero AS Gênero \r\n" + 
							"FROM Cliente\r\n" + 
							"WHERE Cliente_Nome LIKE '"+nome+"%'";
				}else{
					sql = "SELECT\r\n" + 
							"Funcionario_Codigo AS Código,\r\n" + 
							"Funcionario_Nome AS Nome,\r\n" + 
							"Funcionario_Sobrenome AS Sobrenome,\r\n" + 
							"Funcionario_CPF AS CPF,\r\n" + 
							"Funcionario_Foto AS Foto,\r\n" + 
							"Funcionario_Telefone AS Telefone,\r\n" + 
							"Funcionario_Endereco AS Endereço,\r\n" + 
							"Funcionario_Bairro AS Bairro,\r\n" + 
							"Funcionario_Cep AS Cep,\r\n" + 
							"Funcionario_Email AS Email,\r\n" + 
							"Convert(varchar(10),Funcionario_Nascimento,103) AS Nascimento,\r\n" + 
							"Funcionario_Genero AS Gênero \r\n" + 
							"FROM Funcionario\r\n" + 
							"WHERE Funcionario_Nome LIKE '"+nome+"%'";
				}
			
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



	@Override
	public DefaultTableModel consultaocacoes(String nome) {
		try {
			if(bd.getConnection()) {
				String sql = "SELECT c.Cliente_Nome AS Cliente,\r\n" + 
						"t.Titulo_Tipo AS Tipo, \r\n" + 
						"t.Titulo_Nome AS Nome, \r\n" + 
						"Convert(varchar(10),T.Titulo_DataLancamento,103) AS Lançamento,\r\n" + 
						"t.Titulo_Genero AS Gênero,\r\n" + 
						"t.Titulo_Sinopse AS Sinopse\r\n" + 
						"FROM Locacao L\r\n" + 
						"INNER JOIN Cliente C\r\n" + 
						"ON c.Cliente_Codigo = l.Cliente_Codigo\r\n" + 
						"INNER JOIN ItemLocacao IT\r\n" + 
						"ON L.Locacao_Codigo = IT.Locacao_Codigo\r\n" + 
						"INNER JOIN Midia m\r\n" + 
						"ON m.Midia_Codigo = it.Midia_Codigo\r\n" + 
						"INNER JOIN Titulo T\r\n" + 
						"ON t.Titulo_Codigo = m.Titulo_Codigo\r\n" + 
						"WHERE C.Cliente_Nome LIKE '" + nome +"%'\r\n" + 
						"GROUP BY c.Cliente_Nome,\r\n" + 
						"t.Titulo_Codigo, \r\n" + 
						"t.Titulo_Tipo, \r\n" + 
						"t.Titulo_Nome, \r\n" + 
						"t.Titulo_DataLancamento,\r\n" + 
						"t.Titulo_Genero,\r\n" + 
						"t.Titulo_Sinopse";
			
			model = TableModel.getModel(bd, sql); // classe criada pelo sérgio para trazer os dados em uma JTABLE
			
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
			}
				
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Falha " + e.toString());
		}finally {
			bd.close();
		}
		return model;
	}

}

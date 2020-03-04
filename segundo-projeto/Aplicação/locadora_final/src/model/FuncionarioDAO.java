package model;

import java.sql.SQLException;

import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

import services.BD;

public class FuncionarioDAO implements FuncionarioInterface {
	Funcionario funcionario = new Funcionario();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;
	
	@Override
	public String salvar(Funcionario funcionario) {
		String sql = "EXEC sp_novoFuncionario ?,?,?,?,?,?,?,?,?,?,?,?,?";
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setString(1, funcionario.getNome());
				bd.st.setString(2, funcionario.getSobrenome());
				bd.st.setString(3, funcionario.getCpf());
				bd.st.setString(4, funcionario.getFoto());
				bd.st.setString(5, funcionario.getTelefone());
				bd.st.setString(6, funcionario.getEndereco());
				bd.st.setString(7, funcionario.getBairro());
				bd.st.setString(8, funcionario.getCep());
				bd.st.setString(9, funcionario.getEmail());
				bd.st.setString(10, funcionario.getNascimento());
				bd.st.setString(11, funcionario.getGenero());
				bd.st.setString(12, funcionario.getLogin());
				bd.st.setString(13, funcionario.getSenha());
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas
				
				if(r >= 1) {
					mensagem = "Dados inseridos com sucesso!";
				}
				else {
					mensagem = "Operação cancelada. Verifique se o CPF "+funcionario.getCpf()+" já possui cadastro.";
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
	public String alterar(Funcionario funcionario) {
		String sql = "EXEC sp_alterarFuncionario ?,?,?,?,?,?,?,?,?,?,?,?,?,?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, funcionario.getCodigo());
				bd.st.setString(2, funcionario.getNome());
				bd.st.setString(3, funcionario.getSobrenome());
				bd.st.setString(4, funcionario.getCpf());
				bd.st.setString(5, funcionario.getFoto());
				bd.st.setString(6, funcionario.getTelefone());
				bd.st.setString(7, funcionario.getEndereco());
				bd.st.setString(8, funcionario.getBairro());
				bd.st.setString(9, funcionario.getCep());
				bd.st.setString(10, funcionario.getEmail());
				bd.st.setString(11, funcionario.getNascimento());
				bd.st.setString(12, funcionario.getGenero());
				bd.st.setString(13, funcionario.getLogin());
				bd.st.setString(14, funcionario.getSenha());
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Dados alterados com sucesso!";
				}else {
					mensagem = "Operação cancelada. Favor verificar se o CPF " + funcionario.getCpf() + " já possui cadastro.";
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
	 * Método responsável por excluir um funcionário de acordo com o código recebido
	 */
	@Override
	public String excluir(Funcionario funcionario) {
		String sql = "DELETE FROM Funcionario WHERE Funcionario_Codigo = ?";
		
		try {
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, funcionario.getCodigo());				
				int r = bd.st.executeUpdate(); // esse executeUpdate retorna quantas linhas foram afetadas				
				if (r == 1) {
					mensagem = "Funcionário excluido com sucesso!";
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
}
package model;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JOptionPane;
import services.BD;
import view.ViewTelaPrincipal;

public class LoginDAO {
	BD bd = new BD();

	public int logar(Funcionario funcionario) {
		String sql = "SELECT * FROM Funcionario WHERE Funcionario_Login=? AND Funcionario_senha=?";
		int situacao = 0;
		try {
			if(bd.getConnection()) {
				PreparedStatement pst = bd.con.prepareStatement(sql);
				pst.setString(1, funcionario.getLogin());
				pst.setString(2, funcionario.getSenha());
				ResultSet rs = pst.executeQuery(); // esse executeUpdate retorna quantas linhas foram afetadas

				if (rs.next()) {
					situacao = 1;
					JOptionPane.showMessageDialog(null, "Usuário " + rs.getString("Funcionario_Login") +" logado.");
				}
				else {
					JOptionPane.showMessageDialog(null, "Usuário e/ou senha inválido");
				}

			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}			
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e);
		}finally {
			bd.close();
		}
		return situacao;
	}
}

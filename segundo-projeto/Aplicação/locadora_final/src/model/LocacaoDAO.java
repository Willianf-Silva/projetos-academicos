package model;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.sql.Statement;

import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import services.BD;

public class LocacaoDAO implements LocacaoInterface {
	Locacao locacao = new Locacao();
	BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;

	@Override
	public int salvar(Locacao locacao) {		
		int retorno = 0;

		try {			
			String sql = "EXEC sp_novoLocacao ?,?,?";			
			if(bd.getConnection()) {
				bd.st = bd.con.prepareStatement(sql);
				bd.st.setInt(1, locacao.getCodCliente());
				bd.st.setInt(2, locacao.getCodFuncionario());
				bd.st.setDouble(3, locacao.getValorPago());
				retorno = bd.st.executeUpdate();
				if (retorno > 1) {
					retorno = 1;
				}

			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
				System.exit(0);
			}

		} catch (SQLException erro) {
			mensagem = "Falha" + erro.toString();
			JOptionPane.showMessageDialog(null, mensagem);
		}finally {
			bd.close();
		}
		return retorno;
	}

	/**
	 * Método responsável por obter o código da ultima locação existente no banco
	 */
	@Override
	public int codLocacao() {
		int maxLocacao = 0;
		String sql = "select max(Locacao_Codigo) from Locacao";

		try {
			if(bd.getConnection()) {
				Statement st = bd.con.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
				ResultSet rs = st.executeQuery(sql);
				rs.first();
				maxLocacao = rs.getInt(1);
				
			}else {
				JOptionPane.showMessageDialog(null, "Falha na conexão");
			}

		} catch (SQLException e1) {
			JOptionPane.showMessageDialog(null, "Falha " + e1.toString());
		}
		return maxLocacao;
	}

}

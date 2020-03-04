package model;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Arrays;

import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

import services.BD;

public class ItemLocacaoDAO implements ItemLocacaoInterface{
	ItemLocacao itemLocacao = new ItemLocacao();
	private BD bd = new BD();
	private DefaultTableModel model;
	private String mensagem, sql;
	


	@Override
	public void incluir(ItemLocacao itemLocacao) {
	}

	@Override
	public String salvar(ItemLocacao itemLocacao) {

		String sql = "sp_novoItemLocacao ?,?";

		try {

				if(bd.getConnection()) {
					bd.st = bd.con.prepareStatement(sql);
					bd.st.setInt(1, itemLocacao.getCodLocacao());
					bd.st.setInt(2, itemLocacao.getCodMidia());

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
	public DefaultTableModel consulta() {
		try {
			if(bd.getConnection()) {
				String sql = "SELECT * FROM Midia";
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
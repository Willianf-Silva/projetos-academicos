package model;

public class PadraoTela {
	/**
	 * Método para padronizar o modo de janela Nimbus
	 */
	public void Nimbus() {
		 try {
	            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
	                if ("Nimbus".equals(info.getName())) {
	                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
	                    break;
	                }
	            }
	        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
	        	System.err.println(ex);
	        }
	}
	
	
}

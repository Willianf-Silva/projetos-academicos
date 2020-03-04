package model;

import java.sql.ResultSet;

import services.BD;

public interface LocacaoInterface {
	int salvar(Locacao locacao);
	int codLocacao();
}

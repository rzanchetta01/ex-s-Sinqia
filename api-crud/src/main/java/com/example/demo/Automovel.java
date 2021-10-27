package com.example.demo;

import java.math.BigDecimal;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Automovel {
	
	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	public Long id;
	public String modelo;
	public Integer numRodas;
	public String cor;
	public String Placa;
	public Integer numPortas;
	public String Descricao;
	public BigDecimal preco;
	public String tipoCarro;
	
}

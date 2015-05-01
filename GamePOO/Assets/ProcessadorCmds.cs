using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class ProcessadorCmds {
	//Comandos 
	// novo obeto Nome_classe x = new Class()
	// Chamar metodo obeto.metodo();
		

	//verifica se a semantica ta correta 
	// se a classe/metodo existe e se ele tem permissao de executar(de acordo com as regras de batalha que serao definidas )
	public bool isAllowed(string cmd,string textoDigitado, string[] parametros){

		if (cmd.Equals ("NOVO_OBJETO")) {
			//todo
		} else if (cmd.Equals ("CHAMAR_METODO")) {
			//todo
		} else {
			//todo
		}
		return true; 
	}
	//identificar se a sintaxe do comando e valida
	public string identifyCmd(string textoDigitado){
		string[] delimitadores = {" ","."};
		string[] palavras = textoDigitado.Split (delimitadores,StringSplitOptions.RemoveEmptyEntries);

			Regex regex = new Regex (@"^[A-Za-z]");
			//pode ser uma tentativa de instanciar classe

			if (palavras.Length == 5) {
				Match match = regex.Match(palavras[0]);
				if(match.Success){
					match = regex.Match(palavras[1]);
					if(match.Success){
						if(palavras[2].Equals("=")){
						string temp = palavras[3].ToLower();
							if(temp.Equals("new")){
							//mudar caso o objeto receba parametros na criaçao, em um futuro distante, espera-se
								if(palavras[4].EndsWith("()")){
									return "NOVO_OBJETO";
								}else{return "Erro_Fechar_Parentese";}
							}else{ return "Palavra_reservada_NEW";}
						}
					}
			}else{return "Erro_nome_classe";}
		}else if(palavras.Length > 5){
			return "Erro_tamanho_string";
		}else if (palavras.Length == 2){
				return "CHAMAR_METODO";	

		}

		return "COMANDO_NAO_ENCONTRADO";
	}

	//outras tentativas
	private void analiseSintatica(string texto){
		// classe objeto sinal palavra_reservada clase  abre_parenteses  atributos fecha_parenteses
		//objeto sinal metodo abre_parenteses atributos fecha_parenteses
		ArrayList classes = new ArrayList ();
		classes.Add("Javali");
		classes.Add("Urso");

		string[] delimitadores = {" ","."};
		string[] palavras = texto.Split (delimitadores,StringSplitOptions.RemoveEmptyEntries);
		Regex regex = new Regex (@"^[A-Za-z]");
		for (int i = 0; i < palavras.Length; i++) {
			if(classes.Contains(palavras[i])){
				Match match = regex.Match(palavras[i+1]);
				if(match.Success && palavras[i+2].Equals("=") && palavras[i+3].Equals("new")){

				}
			}
		}
			

	
	}


		
}

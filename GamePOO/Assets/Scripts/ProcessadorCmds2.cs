using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;

public class ProcessadorCmds2 {

    private Hashtable tabelaClasses = new Hashtable();

	public string[] verificaEstruturaGeral(string textoDigitado){		
        string acesso = "";
        string nomeClass = "";
        string variavel = "";        
        string constru = "";
        
        Regex regex = new Regex(@"(?<acesso>[a-z]*)[ ]*(?<nomeClass>[A-Z]+[a-zA-Z]*)[ ](?<var>[$_a-z][A-Z0-9a-z]*)[ ]*=[ ]*new[ ](?<constru>[A-Z]+[a-zA-Z]*)\((([A-Z]+[a-z]+[ ][_$a-z]+[A-Z_a-z0-9]*([ ]+,|,)*)*([ ]*[A-Z]+[a-z]+[ ][_$a-z]+[A-Z_a-z0-9]*)*)*\);");
        Regex regexMetodo = new Regex(@"(?<instancia>[$_a-z]+[A-Z_a-z0-9]*)\.(?<metodo>[$_a-z]+[_a-z0-9A-Z]+)\((([_$a-z]+[A-Z_a-z0-9]*([ ]+,|,)*)*([ ]*[_$a-z]+[A-Z_a-z0-9]*)*)*\);");
		
        Match matchObj = regex.Match (textoDigitado);
		Match matchMetodo = regexMetodo.Match (textoDigitado);
        string[] resultado = {"","","","",""};

        if (matchObj.Success) {
            acesso = matchObj.Groups["acesso"].Value;
            nomeClass = matchObj.Groups["nomeClass"].Value;
            variavel = matchObj.Groups["var"].Value;            
            constru = matchObj.Groups["constru"].Value;           

            if (!verificaAcesso(acesso)){                
                resultado[0] = "ERRO_MODIFICADOR_DE_ACESSO";
                return resultado;
            }            
            if (!contemClass(nomeClass)){                
                resultado[0] = "ERRO_CLASS_NOT_FOUND ";
                return resultado;                
            }
            if(isPalavraReservada(variavel)){                
                resultado[0] = "ERRO_USO_DE_PALAVRA_RESERVADA";
                return resultado;                                
            }
            if(!(nomeClass.Equals(constru))){
                resultado[0] = "ERRO_CONSTRUTOR";
                return resultado;
            }

            resultado[0] = "NOVO_OBJETO";
            resultado[1] = nomeClass;
            resultado[2] = variavel;

			try{
				this.tabelaClasses.Add(variavel,nomeClass);
			}catch(ArgumentException e){
				resultado[0] = "Error_Nome_Objeto_Ja_existe";
				resultado[1] = nomeClass;
				resultado[2] = variavel;
				return resultado;
			}
           

            return resultado;
            
		}else if(matchMetodo.Success){
            string objeto = matchMetodo.Groups["instancia"].Value;
            string metodo = matchMetodo.Groups["metodo"].Value;
			string nomeCls = "";
            foreach (DictionaryEntry entry in tabelaClasses)
            {
                if (entry.Key.Equals(objeto))
                {                   
                    if (!contemMetodo((string) entry.Value, metodo + "();"))
                    {
                        resultado[0] = "ERRO_METODO_NOT_FOUND";
                        return resultado;
                    }
					nomeCls = (string) entry.Value;
                }
            }
            resultado[0] = "CHAMAR_METODO";
            resultado[1] = nomeCls;
			resultado[2] = objeto;
			resultado[3] = metodo;
            return resultado;
        }
        resultado[0] = "SINTAXE_INCORRETA";
        return resultado;
	}

    /* public string verificaCorretudeDoMetodo(string nomeClass, string metodo)
     {
         Regex regexMetodo = new Regex(@"(?<instancia>[$_a-z]+[A-Z_a-z0-9]*)\.(?<metodo>[$_a-z]+[_a-z0-9A-Z]+)\((([_$a-z]+[A-Z_a-z0-9]*([ ]+,|,)*)*([ ]*[_$a-z]+[A-Z_a-z0-9]*)*)*\);");
         Match matchMetodo = regexMetodo.Match(metodo);
         if (matchMetodo.Success)
         {
             if (!contemMetodo(nomeClass, metodo + ""))
             {
                 return "ERRO_METODO_NOT_FOUND";
             }
             return "METODO_UTILIZADO";
         }
     }*/

    public Boolean verificaAcesso(string acesso)
    {
        if (acesso.Equals("private") || acesso.Equals("public") || acesso.Equals("protected") || acesso.Equals("") || acesso == null) 
        {
            return true;    
        }
        return false;
    }

    public Boolean contemClass(string nomeClass) 
    {
        Hashtable classes = this.repositorio();
        return classes.ContainsKey(nomeClass);
    }

    public Boolean contemMetodo(string nomeClasse, string nomeMetodo)
    {
        Hashtable classes = this.repositorio();
        if (classes.ContainsKey(nomeClasse))
        {
            foreach(DictionaryEntry entry in classes){
                if (entry.Key.Equals(nomeClasse)) {
                    ArrayList lista = (ArrayList) entry.Value;
                    if (lista.Contains(nomeMetodo)) {
                        return true;
                    }
                }
            }
            
        }
        return false;
    }
    private Hashtable repositorio()
    {

        Hashtable dicionario = new Hashtable();
        
        ArrayList aranha = new ArrayList();
        aranha.Add("atacar();");
        aranha.Add("defender();");

        ArrayList ogro = new ArrayList();
        ogro.Add("atacar();");
        ogro.Add("defender();");

        ArrayList dinossauro = new ArrayList();
        dinossauro.Add("atacar();");
        dinossauro.Add("defender();");

        dicionario.Add("Aranha", aranha);
        dicionario.Add("Ogro", ogro);
        dicionario.Add("Dinossauro",dinossauro);
        
        return dicionario;
    }
	// Ate a versao 7 sao 53 palavras reservadas
	private Boolean isPalavraReservada(string palavra)
    {
		switch (palavra) {
		case "private": 
			return true;
		case "protected": 
			return true;
		case "public": 
			return true;
		case "abstract": 
			return true;
		case "extends": 
			return true;
		case "final": 
			return true;
		case "class": 
			return true;
		case "implements": 
			return true;
		case "interface": 
			return true;
		case "native": 
			return true;
		case "new": 
			return true;
		case "static": 
			return true;
		case "strictfp": 
			return true;
		case "synchronized": 
			return true;
		case "transient": 
			return true;
		case "volatile": 
			return true;
		case "break": 
			return true;
		case "case": 
			return true;
		case "continue": 
			return true;
		case "default": 
			return true;
		case "do": 
			return true;
		case "else": 
			return true;
		case "for": 
			return true;
		case "if": 
			return true;
		case "instanceof": 
			return true;
		case "return": 	
			return true;
		case "switch": 
			return true;
		case "while": 
			return true;	
		case "assert": 
			return true;
		case "catch": 
			return true;
		case "finally": 
			return true;
		case "throw": 
			return true;
		case "throws": 
			return true;
		case "try": 
			return true;
		case "import": 
			return true;
		case "package": 
			return true;
		case "boolean": 
			return true;
		case "byte": 
			return true;
		case "char": 
			return true;	
		case "double": 
			return true;
		case "float": 
			return true;
		case "int": 
			return true;
		case "long": 
			return true;
		case "short": 
			return true;
		case "super": 
			return true;
		case "this": 
			return true;
		case "void": 
			return true;
		case "const": 
			return true;
		case "goto": 
			return true;
		case "null": 
			return true;
		case "enum": 
			return true;
		case "true": 
			return true;
		case "false": 
			return true;
		default:
			return false;
			
		}
		
	}
	
}

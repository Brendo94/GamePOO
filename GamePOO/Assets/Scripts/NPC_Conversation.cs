using UnityEngine;
using System.Collections;

public class NPC_Conversation : MonoBehaviour {

	public UnityEngine.UI.Text conversa;

	private static string dialogo;

	// Use this for initialization
	void Start () {
		//dialogo = "Ola jovem, eu quero que voce me traga uma classe correta. Dentro dessa caverna existem 5 classes, das quais apenas uma e correta, me traga ela e eu lhe levarei para fora da caverna"; 
		conversa.text = ""; 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			if (Pergaminho.classeNoInventario.Equals ("classe01") ) {
				dialogo = "Correto!!";
				Application.LoadLevel("segunda_fase");
			} else if (Pergaminho.classeNoInventario.Equals ("classe02")) {
				dialogo = "Hum, nao era essa que eu queria... Esta errada, falta ponto e vírgula no construtor";
			} else if (Pergaminho.classeNoInventario.Equals ("classe03")) {
				dialogo = "Hum, nao era essa que eu queria... Esta errada, o método atacar() não tem retorno, exige um retorno do tipo float";
			} else if (Pergaminho.classeNoInventario.Equals ("classe04")) {
				dialogo = "Hum, nao era essa que eu queria... Esta errada, o método defender() retorna uma atribuição";
			} else if (Pergaminho.classeNoInventario.Equals ("classe05")) {
				dialogo = "Hum, nao era essa que eu queria... Esta errada, o método float atacar() retorna uma String";
			} else{
				dialogo = "Ola jovem, eu quero que voce me traga uma classe correta. Dentro dessa caverna existem 5 classes, das quais apenas uma e correta, me traga ela e eu lhe levarei para fora da caverna";
			}
				conversa.text = dialogo;
		}

	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			dialogo = "";
		conversa.text = dialogo;
	}
}
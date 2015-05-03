using UnityEngine;
using System.Collections;

public class NPC_Conversation : MonoBehaviour {

	public UnityEngine.UI.Text conversa;

	private string dialogo;

	// Use this for initialization
	void Start () {
		dialogo = "Ola jovem, venha aqui."; 
		conversa.text = ""; 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			if (Pergaminho.classeNoInventario.Equals ("classe01") ) {
				dialogo = "public class Aranha { \n   private float poder;\n private float custo;\npublic Aranha() {\n poder = 10;\n custo = 15;\n }\n " +
					"public float atacar(){\n return poder;\n }\n  public void defender(float dano){ \n        custo = custo - dano; \n    } \n}";
			} else if (Pergaminho.classeNoInventario.Equals ("classe02")) {
				dialogo = "sou classe 02, ola";
			} else if (Pergaminho.classeNoInventario.Equals ("classe03")) {
				dialogo = "sou classe 03, ola";
			} else if (Pergaminho.classeNoInventario.Equals ("classe04")) {
				dialogo = "sou classe 04, ola";
			} else if (Pergaminho.classeNoInventario.Equals ("classe05")) {
				dialogo = "sou classe 05, ola";
			}
				conversa.text = dialogo;
		}	
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			conversa.text = "";
	}
}
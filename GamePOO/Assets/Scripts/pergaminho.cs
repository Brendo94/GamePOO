using UnityEngine;
using System.Collections;

public class pergaminho : MonoBehaviour {

	public UnityEngine.UI.Text conversa;
	public Canvas painel;
	private string dialogo;
	public static string classeNoInventario;
	private bool destruir;



	// Use this for initialization
	void Start () {
		dialogo = "new Class()"; 
		conversa.text = "";
		classeNoInventario = "";
		painel.enabled = false;
		destruir = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = true;

			if (this.gameObject.name.Equals ("classe01")) {
				conversa.text = "sou classe 01, ola";
			} else if (this.gameObject.name.Equals ("classe02")) {
				conversa.text = "sou classe 02, ola";

			} else if (this.gameObject.name.Equals ("classe03")) {
				conversa.text = "sou classe 03, ola";
			} else if (this.gameObject.name.Equals ("classe04")) {
				conversa.text = "sou classe 04, ola";
			} else if (this.gameObject.name.Equals ("classe05")) {
				conversa.text = "sou classe 05, ola";
			}


		}	
		
		
	}
	void OnTriggerStay(Collider c){
		if (destruir && c.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			destruir = false;
		}
	}

	public void Coletar(){
		PrimeiroInventario.temScroll = true;
		painel.enabled = false;
		destruir = true;
		classeNoInventario = this.gameObject.name;
		conversa.text = "";



	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = false;
			conversa.text = "";
		}
			
	}
}

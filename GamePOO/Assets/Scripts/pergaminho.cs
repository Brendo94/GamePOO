using UnityEngine;
using System.Collections;

public class pergaminho : MonoBehaviour {

	public UnityEngine.UI.Text conversa;
	public Canvas painel;
	private string dialogo;

	// Use this for initialization
	void Start () {
		dialogo = "new Class()"; 
		conversa.text = "";
		painel.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = true;
			if (this.gameObject.CompareTag ("classe01")) {
				conversa.text = "sou classe 01, ola";
			} else if (this.gameObject.CompareTag ("classe02")) {
				conversa.text = "sou classe 02, ola";
			} else if (this.gameObject.CompareTag ("classe03")) {
				conversa.text = "sou classe 03, ola";
			} else if (this.gameObject.CompareTag ("classe04")) {
				conversa.text = "sou classe 04, ola";
			} else if (this.gameObject.CompareTag ("classe05")) {
				conversa.text = "sou classe 05, ola";
			}


		}
		
		
		
	}

	public void Coletar(){
		if (this.gameObject.CompareTag ("classe01")) {
		
		} else if (this.gameObject.CompareTag ("classe02")) {
		
		} else if (this.gameObject.CompareTag ("classe03")) {
		
		} else if (this.gameObject.CompareTag ("classe04")) {
		
		} else if (this.gameObject.CompareTag ("classe05")) {
		
		}


		painel.enabled = false;
		Destroy (gameObject);
	}

	public void Rejeitar(){
		painel.enabled = false;
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			painel.enabled = false;
			conversa.text = "";
	}
}

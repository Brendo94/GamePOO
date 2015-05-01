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
			conversa.text = dialogo;
			
		}
		
		
		
	}

	public void Coletar(){
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

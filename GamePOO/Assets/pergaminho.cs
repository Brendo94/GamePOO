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
	
	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			painel.enabled = false;
			conversa.text = "";
	}
}

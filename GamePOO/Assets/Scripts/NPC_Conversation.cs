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
			conversa.text = dialogo;

		}
			


	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			conversa.text = "";
}
}
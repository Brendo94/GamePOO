using UnityEngine;
using System.Collections;

public class bloqueioBehavior : MonoBehaviour {
	public UnityEngine.UI.Text mensagem;
	private string dialogo;
	public Canvas panelBloqueio;

	// Use this for initialization
	void Start () {
		dialogo = "Desculpe jovem aventureiro, mas você não têm permissão de acesso a este local!! Até mais!!!";
		mensagem.text = "";
		panelBloqueio.enabled = false;
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player"))
			mensagem.text = dialogo;
			panelBloqueio.enabled = true;
	}
	
	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player"))
			mensagem.text = "";
			panelBloqueio.enabled = false;
	}


	// Update is called once per frame
	void Update () {
	
	}
}

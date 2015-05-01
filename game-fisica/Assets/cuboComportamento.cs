using UnityEngine;
using System.Collections;

public class cuboComportamento : MonoBehaviour {
	float velocidadeAtual = 0.001f;
	float aceleracao = 0.001f;
	float eixoY = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (velocidadeAtual == 0) {
			velocidadeAtual = velocidadeAtual - 1;
			gameObject.transform.Translate (gameObject.transform.position + new Vector3 (velocidadeAtual, eixoY, 0));
		} else {
			eixoY = eixoY + aceleracao;
			gameObject.transform.Translate (gameObject.transform.position + new Vector3 (velocidadeAtual, eixoY, 0));
		}

	}
}

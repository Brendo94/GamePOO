using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventario : MonoBehaviour {
	public string nomeItens;
	public string[] itens;
	public List<string> myList;
	public UnityEngine.UI.Button[] botoes;

	void Start () {
		myList = new List<string>();
		foreach (UnityEngine.UI.Button botao in botoes){
			botao.interactable = false;
		}

	}

	void OnCollisionEnter (Collision coll){
		if(coll.gameObject.CompareTag("Scroll")){

			botoes[int.Parse(coll.gameObject.name)].interactable = true;

			Destroy(coll.gameObject);
		}
	}

}

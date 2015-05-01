using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventario : MonoBehaviour {
	public string nomeItens;
	public string[] itens;
	public List<string> myList;
	public UnityEngine.UI.Button[] botoes;

	// Use this for initialization
	void Start () {
		myList = new List<string>();
		foreach (UnityEngine.UI.Button botao in botoes){
			botao.interactable = false;
		}

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision coll){
		if(coll.gameObject.CompareTag("Scroll")){
//			myList.Add(coll.gameObject.name);
//			foreach (string nome in myList){
//				if(nome == "primeiro"){
//					botoes[0].interactable = true;
//				}
//			}
//			if(coll.gameObject.name == "primeiro"){
//				botoes[0].interactable = true;
//			}

			foreach (UnityEngine.UI.Button botao in botoes){

			}

			botoes[int.Parse(coll.gameObject.name)].interactable = true;

			Destroy(coll.gameObject);
		}
	}


//	public int ListaItens(){
//		return myList.Count;
//	}
//
//	public void ListaTes(List<string> tes){
//		myList = tes;
//		Debug.Log (myList.Count);
//	}
}

using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public UnityEngine.UI.Text conversa;
	private string[] _textoConversa;
	public Canvas painel;
	public GameObject inventario;

	// Use this for initialization
	void Start () {
		conversa.text = "";
		painel.enabled = false;
		_textoConversa = new string[] {"Hello World ()" , "Ola Mundo ()", "Oh Hell yes"};

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (inv.ListaItens());
//		foreach (string item in inv.ListaItens()){
//			Debug.Log (item);
//			Debug.Log ("coisou");
//			if(item == "primeiro"){
//				Debug.Log("primeiro item");
//			}
//		}
	}
	
	public void Clicou (int numeroBotao) {
		conversa.text = _textoConversa [numeroBotao];
	}

	public void Sair () {
		conversa.text = "";
	}

}

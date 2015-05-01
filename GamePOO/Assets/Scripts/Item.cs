using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public UnityEngine.UI.Text conversa;
	private string[] _textoConversa;
	public Canvas painel;

	// Use this for initialization
	void Start () {
		conversa.text = "";
		painel.enabled = false;
		_textoConversa = new string[] {"Hello World ()" , "Ola Mundo ()", "Oh Hell yes"};

	}

	public void Clicou (int numeroBotao) {
		conversa.text = _textoConversa [numeroBotao];
	}

	public void Sair () {
		conversa.text = "";
	}

}

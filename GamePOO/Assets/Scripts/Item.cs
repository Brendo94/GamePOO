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
		_textoConversa = new string[] {"public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15;\n }\n " +
                    "public float atacar(){\n return poder;\n }\n  public float defender(float dano){ \n        return dano - defesa; \n    } \n}" , "Ola Mundo ()", "Oh Hell yes"};
		
	}

	public void Clicou (int numeroBotao) {
		conversa.text = _textoConversa [numeroBotao];
	}

	public void Sair () {
		conversa.text = "";
	}

}

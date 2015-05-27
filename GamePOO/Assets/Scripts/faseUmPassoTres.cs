using UnityEngine;
using System.Collections;

public class faseUmPassoTres : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public float delay;
	private string texto_historia;

	void Start () {
		texto_historia = "Logo, para usar um método de uma Classe POO é necessário instanciá-la no terminal de comandos. Por exemplo, caso você tenha uma Classe Dinossauro e para instanciar um novo objeto é necessário informar o nome do novo dinossauro; assim é necessário informar no terminal a seguinte declaração: Dinossauro meuDinossauro = new Dinossauro (''Rogerio''); Depois de feito isso, você poderá usar os métodos públicos que a Classe Dinossauro oferece. Por exemplo, caso a classe ofereça um método que permite realizar um ataque a um inimigo, você deverá informar o nome do objeto, seguido da assinatura do método, e quando necessário informar os parâmetros. Como, por exemplo: meuDinossauro.atacar();"; 
		texto.text = "";
		StartCoroutine(TypeText (texto_historia));
	}

	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator TypeText (string caracteres) {
		for (int i =0; i < caracteres.Length; i++){
			texto.text += caracteres[i];
			yield return new WaitForSeconds(delay);
		}  
	}


}

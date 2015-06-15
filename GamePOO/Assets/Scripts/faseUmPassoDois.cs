using UnityEngine;
using System.Collections;

public class faseUmPassoDois: MonoBehaviour {
	
	public UnityEngine.UI.Text mensagem;
	public float delay;
	private string texto_historia;
	public UnityEngine.UI.Image inventario;

	void Start () {
		texto_historia = "Agora você possui apenas uma Classe Aranha, mas ao longo de sua jornada você poderá conseguir novas Classes POO. Quando você conseguir uma nova classe, tal ficará visível no seu painel de pertences, para que você possa utilizá-los quando necessário. Clicando na representação da classe no Painel de Pertences, é possível ver as informações da classe, como atributos, métodos e parâmetros. " +

			"Estas informações serão úteis quando você for utilizar um dos métodos da Classe POO em um combate, por exemplo."; 
		mensagem.text = "";
		StartCoroutine(TypeText (texto_historia));
		inventario.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
	}
	
	private IEnumerator TypeText (string caracteres) {
		for (int i =0; i < caracteres.Length; i++){
			mensagem.text += caracteres[i];
			yield return new WaitForSeconds(delay);
		}
		inventario.enabled = true;
	}
}

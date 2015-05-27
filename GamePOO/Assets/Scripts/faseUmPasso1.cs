using UnityEngine;
using System.Collections;

public class faseUmPasso1 : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public float delay;
	private string texto_historia;
	
	void Start () {
		texto_historia = "Parabéns Jovem Aventureiro! Você conseguiu entregar ao Mago o pergaminho correto, e por conta disso conseguiu passar de fase. Mas a sua jornada no mundo mágico de POO está apenas começando... Na última fase você conseguiu uma Classe POO doada pelo Mago, como recompensa pelo seu feito. Este aliado lhe será muito útil nos próximos desafios do jogo, por isso mantenha-se atento às maneiras de como usar tais regalias."; 
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

using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public float delay;
	private string texto_historia;
	
	void Start () {
		texto_historia = "Parabéns Jovem Aventureiro! Você conseguiu dettorar o chefão final !!! \nThat's all folks!"; 
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

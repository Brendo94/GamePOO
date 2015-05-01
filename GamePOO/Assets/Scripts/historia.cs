using UnityEngine;
using System.Collections;

public class historia : MonoBehaviour {

	public UnityEngine.UI.Text texto;
	public float delay;
	private string texto_historia;

	void Start () {
		texto_historia = "Após sua família ser sequestrada por criaturas comandadas pelo rei Crytalis, um garoto parte em uma jornada em busca de seus pais. Porém esse caminho não será fácil, ele terá diversos desafios a sua frente. No meio de sua jornada o garoto se descuida e cai em um buraco coberto por folhas e galhos no meio de uma floresta escura, batendo sua cabeça no chão com a chegada ao solo deixando-o inconsciente. No dia seguinte quando ele acorda percebe que está em uma caverna e logo tenta buscar uma saída."; 
		texto.text = "";
		StartCoroutine(TypeText (texto_historia));
	}

	private IEnumerator TypeText (string caracteres) {
		for (int i =0; i < caracteres.Length; i++){
			texto.text += caracteres[i];
			yield return new WaitForSeconds(delay);
		}  
	}	

}

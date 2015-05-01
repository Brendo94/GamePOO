using UnityEngine;
using System.Collections;

public class movimentacao : MonoBehaviour {

	public float velocidade = 0.001f;
	public float aceleracao = 0.001f;
	public float aceleracaoy = -0.001f;
	public float velocidadey = -0.001f;
	public float resistencia = -0.001f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		velocidadey = aceleracaoy + velocidadey;
		aceleracaoy = aceleracaoy - resistencia;
		gameObject.transform.Translate (gameObject.transform.position +  new Vector3(velocidade, velocidadey, 0));
	}

}

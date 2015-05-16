using UnityEngine;
using System.Collections;

public class GerenciadorBatalha : MonoBehaviour {
	private  GameObject _monstro;
	public  GameObject[] monstros;
	public static bool block;


	// Use this for initialization
	void Start () {
		block = true;
		instanciarMosntro ("coisa");
	}

	void instanciarMosntro(string nomeMonstro){
		if(nomeMonstro.Equals("coisa"))
		_monstro = GameObject.Instantiate (monstros [0]) as GameObject;
		_monstro.transform.position = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (!block) {
//			chamar animaçao
//			chamo o ataque do inimigo
		}
	}

	public static bool Block {
		get {return block;}
		set {block = value;}
	}
}

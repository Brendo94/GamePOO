using UnityEngine;
using System.Collections;

public class GerenciadorSummoner : MonoBehaviour {
	private  GameObject _monstro;
	public  GameObject[] monstros;
	private bool[] _estaVazio;
	private Transform[] _filhos;

	// Use this for initialization
	void Start () {
		_estaVazio = new bool[4];
		//Invoke ("Instanciar", 1f);
		//Invoke ("Instanciar", 1f);
		//Invoke ("Instanciar", 1f);
		_estaVazio [0] = true;
		_estaVazio [1] = true;
		_estaVazio [2] = true;
		_filhos = GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Instanciar(string nomeMonstro) {

		if(nomeMonstro == "Aranha"){
			_monstro = GameObject.Instantiate (monstros [0]) as GameObject;

		}

		if (_estaVazio [0]) {
			_monstro.transform.position =  _filhos[1].transform.position;
			_estaVazio[0] = false;
		}else if (_estaVazio [1]) {
			_monstro.transform.position =  _filhos[2].transform.position;
			_estaVazio[1] = false;
		}else if (_estaVazio [2]) {
			_monstro.transform.position =  _filhos[3].transform.position;
			_estaVazio[2] = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class GerenciadorSummoner : MonoBehaviour {
	private  GameObject _monstro;
	public  GameObject[] monstros;
	private bool[] _estaVazio;
	private Transform[] _filhos;
    //public Animator anime;

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

	public void callAnimation(string[] parametros){
		
		if (parametros [1] == "Aranha") {
			print("Entrou na aranha");
			_monstro = monstros[0].gameObject;

			_monstro.GetComponent<Animator>().Play("attack");
            
        }
	}
	public void Instanciar(string nomeMonstro) {

		if (nomeMonstro == "Aranha") {
			_monstro = GameObject.Instantiate (monstros [0]) as GameObject;
		} else if (nomeMonstro == "alguma coisa") {
			//implementar
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

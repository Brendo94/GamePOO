using UnityEngine;
using System.Collections;

public class LoadMonstroArena : MonoBehaviour {
	private GameObject _monstro;
	public GameObject[] monstros;


	// Use this for initialization
	void Start () {
		_monstro = GameObject.Instantiate (monstros [1]) as GameObject;
		_monstro.transform.position = transform.position;
		_monstro = GameObject.Instantiate (monstros [2]) as GameObject;
		_monstro.transform.position = transform.position;
		_monstro = GameObject.Instantiate (monstros [3]) as GameObject;
		_monstro.transform.position = transform.position;
		_monstro = GameObject.Instantiate (monstros [4]) as GameObject;
		_monstro.transform.position = transform.position;
		_monstro = GameObject.Instantiate (monstros [5]) as GameObject;
		_monstro.transform.position = transform.position;
		_monstro = GameObject.Instantiate (monstros [6]) as GameObject;
		_monstro.transform.position = transform.position;
		//GerenciadorSummoner.nomeMonstro = "Aranha";
	}
	
	// Update is called once per frame
	void Update () {

	}
}

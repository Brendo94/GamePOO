using UnityEngine;
using System.Collections;

public class PrimeiroInventario : MonoBehaviour {
	public GameObject miniScroll;
	private bool temScroll;
	// Use this for initialization
	void Start () {
		miniScroll.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (temScroll) {
			miniScroll.SetActive (true);
		} else {
			miniScroll.SetActive (false);
		}
	}
	

	void OnTriggerEnter (Collider coll){
		if (coll.gameObject.CompareTag("NPC")) {
			temScroll = false;
		}
		if (coll.gameObject.CompareTag ("Scroll")) {
			temScroll = true;
		}
	}
}

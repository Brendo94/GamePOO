using UnityEngine;
using System.Collections;

public class pergaminho : MonoBehaviour {

	public UnityEngine.UI.Text conversa;
	public Canvas painel;
	private string dialogo;
	public static string classeNoInventario;
	private bool destruir;




	// Use this for initialization
	void Start () {
		dialogo = "new Class()"; 
		conversa.text = "";
		classeNoInventario = "";
		painel.enabled = false;
		destruir = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = true;

			if (this.gameObject.name.Equals ("classe01")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float custo;\npublic Aranha() {\n poder = 10;\n custo = 15;\n }\n " +
					"public float atacar(){\n return poder;\n }\n  public void defender(float dano){ \n        custo = custo - dano; \n    } \n}";
			} else if (this.gameObject.name.Equals ("classe02")) {
				conversa.text = "sou classe 02, ola";

			} else if (this.gameObject.name.Equals ("classe03")) {
				conversa.text = "sou classe 03, ola";
			} else if (this.gameObject.name.Equals ("classe04")) {
				conversa.text = "sou classe 04, ola";
			} else if (this.gameObject.name.Equals ("classe05")) {
				conversa.text = "sou classe 05, ola";
			}


		}	
		
		
	}
	void OnTriggerStay(Collider c){

		if (!PrimeiroInventario.temScroll && c.gameObject.CompareTag ("Player")  && destruir) {
			destruir = false;
			painel.enabled = false;
			PrimeiroInventario.temScroll = true;
			Destroy (gameObject);

		} else {

		}
	}

	public void Coletar(){
		if (!PrimeiroInventario.temScroll && !destruir) {
			classeNoInventario = gameObject.name;
			conversa.text = "";
			destruir = true;

			painel.enabled = false;
		} else {
			Debug.Log(PrimeiroInventario.temScroll);
		}

	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = false;
			conversa.text = "";
		}
			
	}
}

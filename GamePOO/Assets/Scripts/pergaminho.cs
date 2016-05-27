using UnityEngine;
using System.Collections;

public class Pergaminho : MonoBehaviour {
	
	public UnityEngine.UI.Text conversa;
	public Canvas painel;
	private string dialogo;
	public static string classeNoInventario;
	private static bool destruir;
	private static string nome;
	
	
	
	// Use this for initialization
	void Start () {
		dialogo = "new Class()"; 
		conversa.text = "";
		classeNoInventario = "sdfghjk";
		painel.enabled = false;
		destruir = false;
		nome = "";
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = true;
			nome = this.gameObject.name;
			if (this.gameObject.name.Equals ("classe01")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15;\n }\n " +
					"public float atacar(){\n return poder;\n }\n  public float defender(float dano){ \n        return dano - defesa; \n    } \n}";
			} else if (this.gameObject.name.Equals ("classe02")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15\n }\n " +
					"public float atacar(){\n return poder;\n }\n  public float defender(float dano){ \n        return dano - defesa; \n    } \n}";
				
			} else if (this.gameObject.name.Equals ("classe03")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15;\n }\n " +
                    "public float atacar(){\n poder = poder + 1;\n }\n  public float defender(float dano){ \n        return dano - defesa; \n  return defesa;  \n } \n}";
				
			} else if (this.gameObject.name.Equals ("classe04")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15;\n }\n " +
					"public float atacar(){\n return true;\n }\n  public void defender(float dano){ \n        return dano - defesa; \n  return true;  \n } \n}";
				
			} else if (this.gameObject.name.Equals ("classe05")) {
				conversa.text = "public class Aranha { \n   private float poder;\n private float defesa;\npublic Aranha() {\n poder = 10;\n defesa = 15;\n }\n " +
                    "public float atacar(){\n return “ataque”;\n }\n  public float defender(float dano){ \n        return dano - defesa; \n  return 0;  \n } \n}";
				
			}
			
			
		}	
		
		
	}
    void OnTriggerStay(Collider c){
		
		if (!PrimeiroInventario.temScroll && c.gameObject.CompareTag ("Player")  && destruir) {
			destruir = false;
			painel.enabled = false;
			PrimeiroInventario.temScroll = true;
			Destroy (gameObject);	
		}
	}
	
	public void Coletar(){
		if (!PrimeiroInventario.temScroll && !destruir) {
			classeNoInventario = nome;
			conversa.text = "";
			destruir = true;
			Debug.Log(nome);
			painel.enabled = false;
		}	
	}

    void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			painel.enabled = false;
			conversa.text = "";	
		}

	}
}

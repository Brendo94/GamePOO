using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControladorCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetString("Ganhou").Equals("sim"))
        {
            Vector3 temp;
            temp.x = PlayerPrefs.GetFloat("X");
            temp.y = PlayerPrefs.GetFloat("Y");
            temp.z = PlayerPrefs.GetFloat("Z");
            gameObject.transform.position = temp;
        }
        else {
            PlayerPrefs.DeleteAll();
        }
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider coll){

		if (coll.name.Equals ("PaiDoMonstro") && PlayerPrefs.GetString ("Ganhou").Length == 0) {

			PlayerPrefs.SetString ("nomeMonstro", coll.name);
			SceneManager.LoadScene ("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);

		}
		if (coll.name.Equals ("PaiDoMonstro") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

		if (coll.name.Equals ("butterfly2") && PlayerPrefs.GetString ("Ganhou").Length == 0) {
			
			PlayerPrefs.SetString ("nomeMonstro", coll.name);
            SceneManager.LoadScene("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);
			
		}
		if (coll.name.Equals ("butterfly2") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

		if (coll.name.Equals ("GOBLIN") && PlayerPrefs.GetString ("Ganhou").Length == 0) {
			
			PlayerPrefs.SetString ("nomeMonstro", coll.name);
            SceneManager.LoadScene("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);
			
		}
		if (coll.name.Equals ("GOBLIN") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

		if (coll.name.Equals ("cyclop_soldier") && PlayerPrefs.GetString ("Ganhou").Length == 0) {
			
			PlayerPrefs.SetString ("nomeMonstro", coll.name);
            SceneManager.LoadScene("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);
			
		}
		if (coll.name.Equals ("cyclop_soldier") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

		if (coll.name.Equals ("humpback_whale") && PlayerPrefs.GetString ("Ganhou").Length == 0) {
			
			PlayerPrefs.SetString ("nomeMonstro", coll.name);
            SceneManager.LoadScene("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);
			
		}
		if (coll.name.Equals ("humpback_whale") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

		if (coll.name.Equals ("Allosaurus_03") && PlayerPrefs.GetString ("Ganhou").Length == 0) {
			
			PlayerPrefs.SetString ("nomeMonstro", coll.name);
            SceneManager.LoadScene("campo_batalha");
			PlayerPrefs.SetFloat("X", gameObject.transform.position.x);
			PlayerPrefs.SetFloat("Y", gameObject.transform.position.y);
			PlayerPrefs.SetFloat("Z", gameObject.transform.position.z);
			
		}
		if (coll.name.Equals ("Allosaurus_03") && PlayerPrefs.GetString("Ganhou").Equals("sim")) {
			//Nao esta funcionando, outra forma de fazer e mudar a posiçao dele para fora do mapa;
			Destroy(coll);
			coll.enabled = false;
			PlayerPrefs.DeleteAll();
		}

	}
}

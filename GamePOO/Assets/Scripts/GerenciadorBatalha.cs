using UnityEngine;
using System.Collections;

public class GerenciadorBatalha : MonoBehaviour {
	private  GameObject _monstro;
	public  GameObject[] monstros;
	public static bool block{ get; set;}
	public static bool block_mana{ get; set;}
	private int Monstro_life{ get; set;}
	private int Mago_life{ get; set;}
	private int Mago_mana{ get; set;}

	void Start () {
		block = true;
		block_mana = true;// variavel que indica se o usuario em mana suficiente para realizar uma jogada
		instanciarMosntro ("coisa");
		Monstro_life = 100;
		Mago_life = 100;//lembrando que esses valores estao na classe backgroundBehavior
		Mago_mana = 20;// entao eles devem ser alterados la tmb

	}

	void instanciarMosntro(string nomeMonstro){
		if(nomeMonstro.Equals("coisa"))
		_monstro = GameObject.Instantiate (monstros [0]) as GameObject;
		_monstro.transform.position = gameObject.transform.position;
	}
	public void MonstroAtacar(){
		int valor = 10;

		if (Mago_life - valor > 0) {
			GameObject.Find ("Background").SendMessageUpwards ("atualizarBarra", valor);
			Mago_life -= valor;
		} else {
			//batalha acaba aqui, perdeu

		}

	}

	public void  MagoAtacar(string[] parametros){
		// valor sera definido ainda.

		int valor_a_ser_descontado_da_vida_do_monstro = 10;
		if (Monstro_life >= valor_a_ser_descontado_da_vida_do_monstro) {
			Monstro_life -= valor_a_ser_descontado_da_vida_do_monstro;
			//chamar animacao monstro
			//na classe GerenciadorSummoner
			GameObject.Find("GerenciadorSummoner").SendMessage("callAnimation", parametros);
		} else {
			//batalha acaba aqui!!!!!
		}
	}


	public void MagoDefender(){
	 // to do
	}

	// Update is called once per frame
	void Update () {
		if (!block) {
//			chamar animaçao
			MonstroAtacar();
			block = true;
		}
	}

}

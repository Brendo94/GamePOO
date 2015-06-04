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
	private bool Vez_mago;
	public UnityEngine.UI.Button vez;
	private bool defender{ get; set;}
	private int contadorDefesa{ get ; set ;}

	void Start () {
		block = false;
		block_mana = false;// variavel que indica se o usuario em mana suficiente para realizar uma jogada
		instanciarMosntro ("coisa");
		Monstro_life = 100;
		Mago_life = 100;//lembrando que esses valores estao na classe backgroundBehavior
		Mago_mana = 45;// entao eles devem ser alterados la tmb
		Vez_mago = true;
		defender = false;
		contadorDefesa = 0;

	}

	public void VezDeQuem(){
		Vez_mago = !Vez_mago;
		if (Vez_mago) {
			vez.enabled = true;
			block = false;
			Mago_mana += 15;
			GameObject.Find ("Background").SendMessageUpwards ("aumentarMana", 15);
		}else {
			vez.enabled = false;
			block = true;
			Invoke("MonstroAtacar", 3f);
		}

	}

	void instanciarMosntro(string nomeMonstro){
		if(nomeMonstro.Equals("coisa"))
		_monstro = GameObject.Instantiate (monstros [0]) as GameObject;
		_monstro.transform.position = gameObject.transform.position;
	}
	public void MonstroAtacar(){

		int valor = Random.Range (6, 12);

		if (defender) {
			valor -= Random.Range (3, 5);
		} 

		if (Mago_life - valor > 0) {
			GameObject.Find ("Background").SendMessageUpwards ("atualizarBarra", valor);
			Mago_life -= valor;
		} else {
			//batalha acaba aqui, perdeu

		}
		if (contadorDefesa > 0) {
			contadorDefesa--;
		} else {
			defender= false ;
		}
		VezDeQuem ();
	}

	public void InstanciarMonstroMago(string[] parametros){
		Mago_mana -= 30;
		GameObject.Find ("GerenciadorSummoner").SendMessage ("Instanciar", parametros[1]);
		GameObject.Find ("Background").SendMessageUpwards ("diminuirMana", 30);
	}

	public void  JogadaMago(string[] parametros){
		// valor sera definido ainda.

		int valor_a_ser_descontado_da_vida_do_monstro = Random.Range(6,12);
		if (Monstro_life >= valor_a_ser_descontado_da_vida_do_monstro && parametros [3].Equals ("atacar")) {
			Monstro_life -= valor_a_ser_descontado_da_vida_do_monstro;
			Mago_mana -= 15;
			GameObject.Find ("Background").SendMessageUpwards ("diminuirMana", 15);
			GameObject.Find ("ControlBar").SendMessage ("atualizarBarra", Monstro_life);
			//chamar animacao monstro
			//na classe GerenciadorSummoner
			GameObject.Find ("GerenciadorSummoner").SendMessage ("callAnimation", parametros);
		} else if (parametros [3].Equals ("defender")) {
			contadorDefesa += 3;
			defender = true;
			Mago_mana -= 15;
			GameObject.Find ("Background").SendMessageUpwards ("diminuirMana", 15);

		} else {
			//batalha acaba aqui!!!!!
		}
	}


	//cmd[0] = NOME DO COMANDO
	//cmd[1] = NOME DA CLASSE;
	//cmd[2] = NOME DO OBJETO;
	//cmd[3] = NOME DO METODO;	
	public void checarValores(string[] parametros){
		if (parametros [0].Equals ("NOVO_OBJETO")) { 
			if (Mago_mana >= 30) {
				block_mana = false;
			} else {
				block_mana = true;
			}
		}
		//Pode ser feito verificaçoes mais robustas para evitar tantos if e else, no futuro
		if(parametros [0].Equals ("CHAMAR_METODO") && parametros[3].Equals ("atacar")){
				if(Mago_mana >= 15){
					block_mana = false;
				}else {
					block_mana = true;
				}
			}else if(parametros [0].Equals ("CHAMAR_METODO") && parametros[3].Equals ("defender")){
				if(Mago_mana >= 15){
					block_mana = false;
				}else {
					block_mana = true;
				}
			}
		Debug.Log(Mago_mana);
		Debug.Log (parametros[0] + parametros[1] + parametros[2] + parametros[3]);
	}


	public void ManaMago(){
		if (Mago_mana <= 0) {
			block_mana = true;
		}
	}


	public void MagoDefender(){
	 // to do
	}

	// Update is called once per frame
	void Update () {
		if (block) {
//			chamar animaçao
//			if(!Vez_mago){
//				MonstroAtacar();
//			}

			//Invoke("VezDeQuem", 10f);

		}
	}

}

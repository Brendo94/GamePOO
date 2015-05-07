using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backgroundBehavior : MonoBehaviour {
	public UnityEngine.UI.Text textoHealth;
	public UnityEngine.UI.Text textoMana;

	public int estadoVida;
	public int estadoMana;
	public int maximoVida;
	public int maximoMana;

	public UnityEngine.UI.Slider sliderHealth;
	public UnityEngine.UI.Slider sliderMana;

	public Color MaxHealthColor = Color.green;
	public Color MinHealthColor = Color.red;
	public Color colorMana = Color.blue;
	public Image fill;

	// Use this for initialization
	void Start () {
		textoHealth.text = "Health: 100";
		textoMana.text = "Mana: 0";
		estadoVida = 100;
		maximoVida = 100;
		estadoMana = 0;
		maximoMana = 100;
		sliderHealth.wholeNumbers = true;
		sliderHealth.minValue = 0f;
		sliderHealth.maxValue = maximoVida;
		sliderHealth.value = maximoVida;
		sliderMana.wholeNumbers = true;
		sliderMana.minValue = 0;
		sliderMana.maxValue = maximoMana;
		sliderMana.value = estadoMana;
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void atualizarBarra(){
		if (estouVivo()) {
			atualizarHealth (1);
			UpdateHealthBar (estadoVida);
			atualizarTextoHealth();
		}
	}
	
	private bool estouVivo(){
		if (estadoVida >= 1) {
			return true;
		} else {
			return false;
		}
	}

	private void atualizarHealth(int decrescimo){
		estadoVida -= decrescimo;
	}

	private void atualizarTextoHealth(){
		textoHealth.text = "Health: " + estadoVida;
	}

	public void UpdateHealthBar(int val) {
		sliderHealth.value = val;
		fill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)val / maximoVida);
	}
	
	public void aumentarMana(){
		//neste ponto verifica-se se a adiçao ultrapassa o valor maximo de mana, caso nao esse valor e decrescido, caso contrario iguala ao valor maximo
		if ((estadoMana + 1) <= maximoMana) {
			estadoMana++;
		} else {
			estadoMana = maximoMana;
		}
		atualizarTextoMana ();
		sliderMana.value = estadoMana;

	}

	public void diminuirMana(){
		//neste ponto verifica-se se o decrescimo de mana pode ser menor que zero, caso nao executa o if, caso contrario esse valor iguala a zero.
		if ((estadoMana-1)>=0) {
			estadoMana--;
		} else {
			estadoMana = 0;
		}
		atualizarTextoMana ();
		sliderMana.value = estadoMana;
	}

	private void atualizarTextoMana(){
		textoMana.text = "Mana: " + estadoMana;
	}
}
 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backgroundBehavior : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public int estadoVida;
	public int maximoVida;
	private float cachedY;
	private float minXValue;
	private float maxXValue;

	public UnityEngine.UI.Slider slider;
	public Color MaxHealthColor = Color.green;
	public Color MinHealthColor = Color.red;
	public Image fill;

	// Use this for initialization
	void Start () {
		texto.text = "Health: 100";
		estadoVida = 100;
		maximoVida = 100;
		slider.wholeNumbers = true;
		slider.minValue = 0f;
		slider.maxValue = maximoVida;
		slider.value = maximoVida;
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void atualizarBarra(){
		if (estouVivo()) {
			atualizarCorBarra ();
			atualizarTexto();
		}
	}

	private void atualizarTexto(){
		texto.text = "Health: " + estadoVida;
	}
	
	private void atualizarCorBarra(){
		float currentXValue = MapValues(estadoVida,0,maximoVida,minXValue,maxXValue);
		UpdateHealthBar (estadoVida);
		estadoVida--;
	}

	private bool estouVivo(){
		if (estadoVida >= 1) {
			return true;
		} else {
			return false;
		}
	}

	public void UpdateHealthBar(int val) {
		slider.value = val;
		fill.color = Color.Lerp(MinHealthColor, MaxHealthColor, (float)val / maximoVida);
	}
	
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x-inMin)*(outMax-outMin)/(inMax-inMin)+outMin;
	}
	
}
 
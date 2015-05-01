using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backgroundBehavior : MonoBehaviour {
	public UnityEngine.UI.Text texto;
	public int estadoVida;
	public UnityEngine.UI.Image visualHealth;
	public int maximoVida;

	public RectTransform healthTransform;
	private float cachedY;
	private float minXValue;
	private float maxXValue;

	//private float currentXValue = 0;


	// Use this for initialization
	void Start () {
		texto.text = "Health: 100";
		estadoVida = 100;
		maximoVida = 100;
		cachedY = healthTransform.position.y;
		maxXValue = healthTransform.position.x;
		//minXValue = (float)80.3;
		minXValue = healthTransform.position.x - healthTransform.rect.width;
		//maxXValue = (float)80.3+(float)161.1;
		//healthTransform.GetComponent<CanvasRenderer>().hideIfInvisible = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private bool estouVivo(){
		if (estadoVida >= 1) {
			return true;
		} else {
			return false;
		}
	}

	private void atualizarTexto(int decrescimo){
		estadoVida = estadoVida - decrescimo;
		texto.text = "Health: " + estadoVida;
	}

	private void atualizarCorBarra(){
		float currentXValue = MapValues(estadoVida,0,maximoVida,minXValue,maxXValue);
		//currentXValue = MapValues(estadoVida,0,100,-10,0);
		//Debug.Log (currentXValue);
		healthTransform.position = new Vector3 (currentXValue, cachedY);

		if (estadoVida > maximoVida / 2) {
			visualHealth.color = new Color32((byte)MapValues(estadoVida, maximoVida/2, maximoVida,255,0),255,0,255);
		} else {
			visualHealth.color = new Color32(255, (byte)MapValues(estadoVida, 0, maximoVida/2,0,255),0,255);
		}
	}

	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x-inMin)*(outMax-outMin)/(inMax-inMin)+outMin;
	}

	public void atualizarBarra(){
		if (estouVivo()) {
			atualizarTexto(1);
			atualizarCorBarra ();
		}
	}


}
 
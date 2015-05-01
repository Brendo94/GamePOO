using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class visualBehavior : MonoBehaviour {
	public RectTransform healthTransform;
	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentHealth;
	
	private int CurrentHealth
	{
		get { return currentHealth;}
		set {
			currentHealth = value;
			handleHealth();
		}
	}
	
	private int minHealth;
	private int maxHealth;
	public Text healthText;
	public Image visualHealth;
	public float cooDown;
	private bool onCD;

	// Use this for initialization
	void Start () {
		cachedY = healthTransform.position.y;
		maxXValue = healthTransform.position.x;
		minXValue = healthTransform.position.x - healthTransform.rect.width;
		currentHealth = maxHealth;
		onCD = false;
		healthTransform.GetComponent<CanvasRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void handleHealth(){
		healthText.text = "Health: "+currentHealth;
		float currentXValue = MapValues(currentHealth,0,maxHealth,minXValue,maxXValue);
		healthTransform.Translate (new Vector3 (currentXValue, cachedY));
		
		if (currentHealth > maxHealth / 2) {
			visualHealth.color = new Color32((byte)MapValues(currentHealth, maxHealth/2, maxHealth,255,0),255,0,255);
		} else {
			visualHealth.color = new Color32(255, (byte)MapValues(currentHealth, 0, maxHealth/2,0,255),0,255);
		}
	}

	IEnumerator CoolDownDmg(){
		onCD = true;
		yield return new WaitForSeconds (cooDown);
		onCD = false;
	}
	
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x-inMin)*(outMax-outMin)/(inMax-inMin)+outMin;
	}
	
	void OnTriggerStay(){
		StartCoroutine (CoolDownDmg ());
		CurrentHealth -= 1;
	}

}

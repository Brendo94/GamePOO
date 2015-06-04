//this script is just used for the demo...nothing to see here move along.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ControlBar : MonoBehaviour {

	//a list of all the UIScript_HP
	public List<UIBarScript> HPScriptList = new List<UIBarScript>();
	private int minHP;
	private int maxHP;

	void Start()
	{
		minHP = 100;
		maxHP = 100;
		foreach (UIBarScript HPS in HPScriptList)
		{
			HPS.UpdateValue(minHP,maxHP);
		}
	}

	public void atualizarBarra(int HP){
		minHP = HP;
		foreach (UIBarScript HPS in HPScriptList)
		{
			HPS.UpdateValue(minHP, maxHP);
		}
	}

//	// Update is called once per frame
//	void Update () 
//	{
//		Debug.Log (minHP);
//
//		//for every UIScript_HP update it.
//
//
//	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public Transform button; //Drag a button transform on to here, and see how to toggle it when Space is pressed
	
	
	
	void Update () {
		
		
		if (Input.GetKeyUp(KeyCode.Space) )
		{
			//If space is pressed, and the button is currently interactable, make it so its not interactable
			if (button.GetComponent<Button>().IsInteractable() == true)
			{
				button.GetComponent<Button>().interactable = false; 
			}
			else //Else make it interactable
			{
				button.GetComponent<Button>().interactable = true;
			}
			
		}
		
	}
	
}


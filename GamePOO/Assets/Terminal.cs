using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour {

	public GUISkin terminal_skin;

	private Rect windowT = new Rect(200,200,300,400);
	private string messageBox = "";
	private string messageToSend = "";
	private static int num_messages = 0 ;


	private void OnGUI(){
		GUI.skin = terminal_skin;
		windowT = GUI.Window (1, windowT, windowFunc, "Terminal");


	}

	private void windowFunc(int id){
		GUILayout.Box(messageBox,GUILayout.Height(350));
		GUILayout.BeginHorizontal ();
		messageToSend =  GUILayout.TextField (messageToSend);

		if((GUILayout.Button("executar", GUILayout.Width(75)) ) && messageToSend.Length > 0){
			messageBox += messageToSend + "\n";
			messageToSend = "";
			if(num_messages == 20){
				messageBox = "";
				num_messages = 0;
			}
			num_messages++;

		}
		GUILayout.EndHorizontal ();
		GUI.DragWindow (new Rect (0, 0, Screen.width, Screen.height));
	}

	private void processText(string text){
		//do something
	}
}

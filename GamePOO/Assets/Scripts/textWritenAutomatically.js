var letterPause = 0.2;
var word = ""; // change this one in the inspector
private var currentWord = "";
var VecnaBoldI : Font;
var style : GUIStyle;
var Delay : float = 0.05;
private var contador = 1;
function Start (){
 TypeText (word);
}

function AddText(newText : String){
	word = newText;
	TypeText(word);
}

private function TypeText (compareWord : String) {
	object=GameObject.Find("historia");
 	historia = object.GetComponent(GUIText);
	
	for (var letter in word.ToCharArray()) {
	     if (word != compareWord) break;
	     historia.text += letter;
	     yield WaitForSeconds (Delay);
	     if(contador%50 == 0){
	     	historia.text += "\n";
	     }
	     contador++;
	}  
}	

/*
function OnGUI(){
	style.fontSize = 26;
    style.font = VecnaBoldI;
 	GUI.Label(new Rect(400, 100, 50, 50), currentWord, style);
 	//Label(new Rect(400, 100, 50, 50), currentWord, style);
}*/

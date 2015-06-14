	using UnityEngine;
	using System.Collections;

	public class Terminal : MonoBehaviour{

		public GUISkin terminal_skin;
		private Rect windowT = new Rect (30, 180, 300, 400);
		private string messageBox = "";
		private string messageToSend = "";
		private static int num_messages = 0 ;
		private ProcessadorCmds processadorCmds = new ProcessadorCmds ();
	    private ProcessadorCmds2 processadorCmds2 = new ProcessadorCmds2();



		private void OnGUI (){
			GUI.skin = terminal_skin;
			windowT = GUI.Window (1, windowT, windowFunc, "Terminal");
		}

		private void windowFunc (int id){
			GUILayout.Box (messageBox, GUILayout.Height (350));
			GUILayout.BeginHorizontal ();
			messageToSend = GUILayout.TextField (messageToSend);

			if ((Event.current.keyCode == KeyCode.Return || (GUILayout.Button ("executar", GUILayout.Width (75)))) && messageToSend.Length > 0) {

			 //esse metodo ira retornar o comando a ser executado e uma lista de parametros, caso tenha.
			 //cmd[0] = NOME DO COMANDO
			 //cmd[1] = NOME DA CLASSE;
			 //cmd[2] = NOME DO OBJETO;
			 //cmd[3] = NOME DO METODO;	
				string[] cmd = processadorCmds2.verificaEstruturaGeral (messageToSend); 
				GameObject.Find ("GerenciadorBatalha").SendMessage ("checarValores", cmd);
				if (!GerenciadorBatalha.block) {
				    if (!GerenciadorBatalha.block_mana) {
						if (cmd[0].Equals ("NOVO_OBJETO")) {
							GameObject.Find ("GerenciadorBatalha").SendMessage ("InstanciarMonstroMago", cmd);
							//GerenciadorBatalha.block = false;
						} else if (cmd[0].Equals ("CHAMAR_METODO")) {
						GameObject.Find ("GerenciadorBatalha").SendMessage ("JogadaMago", cmd);
							//GerenciadorBatalha.block = false;
						}
						messageBox += cmd[0] + "\n";

					}else{
						messageBox += "Voce nao possui mana sufuciente" + "\n";
					}

				} else {
					messageBox += "Espere sua vez" + "\n";
				}

				if (num_messages == 20 || messageToSend.Equals ("clear")) {
					messageBox = "";
					num_messages = 0;
				}
				messageToSend = "";
				num_messages++;

			}
			GUILayout.EndHorizontal ();
			GUI.DragWindow (new Rect (0, 0, Screen.width, Screen.height));
		}



	}

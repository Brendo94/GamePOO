	using UnityEngine;
	using System.Collections;

	public class Terminal : MonoBehaviour{

		public GUISkin terminal_skin;
		private Rect windowT = new Rect (200, 200, 300, 400);
		private string messageBox = "";
		private string messageToSend = "";
		private static int num_messages = 0 ;
		private ProcessadorCmds processadorCmds = new ProcessadorCmds ();



		private void OnGUI (){
			GUI.skin = terminal_skin;
			windowT = GUI.Window (1, windowT, windowFunc, "Terminal");
		}

		private void windowFunc (int id){
			GUILayout.Box (messageBox, GUILayout.Height (350));
			GUILayout.BeginHorizontal ();
			messageToSend = GUILayout.TextField (messageToSend);

			if ((Event.current.keyCode == KeyCode.Return || (GUILayout.Button ("executar", GUILayout.Width (75)))) && messageToSend.Length > 0) {

				//esse metodo ira retornar o comando a ser executado e uma lista de parametros.
				string cmd = processadorCmds.identifyCmd (messageToSend); 

				if (GerenciadorBatalha.block) {
				    if (GerenciadorBatalha.block_mana) {
						if (cmd.Equals ("NOVO_OBJETO")) {
							GameObject.Find ("GerenciadorSummoner").SendMessage ("Instanciar", "Aranha");
							GerenciadorBatalha.block = false;
						} else if (cmd.Equals ("CHAMAR_METODO")) {
							string[] parametros = new string[] {"classe","objeto","futuros parametros"};
							GameObject.Find ("GerenciadorBatalha").SendMessage ("MagoAtacar", parametros);
							GerenciadorBatalha.block = false;
						}
						messageBox += cmd + "\n";

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

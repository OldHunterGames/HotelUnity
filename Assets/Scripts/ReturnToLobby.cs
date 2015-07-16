using UnityEngine;
using System.Collections;

public class ReturnToLobby : MonoBehaviour {
	public void BackToLobby(){
		Application.LoadLevel ("Lobby");
	}
}
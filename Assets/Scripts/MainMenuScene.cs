using UnityEngine;
using System.Collections;

public class MainMenuScene : MonoBehaviour {
	
	void Start () {
		GameObject.DontDestroyOnLoad (GameObject.Find ("Characters"));
		GameObject.DontDestroyOnLoad (GameObject.Find ("Locations"));
		Application.LoadLevel ("Lobby");
	}
}

using UnityEngine;
using System.Collections;

public class MainMenuScene : MonoBehaviour {
	
	void Start () {
		GameObject.DontDestroyOnLoad (GameObject.Find ("Characters"));
//		Application.LoadLevel ("Lobby");
	}
}

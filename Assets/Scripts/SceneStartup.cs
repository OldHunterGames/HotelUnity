using UnityEngine;
using System.Collections;

public class SceneStartup : MonoBehaviour {
	
	void Start () {
		SublocationUtils.UpdateInterfaceForPlayer ("Lobby");
	}
}

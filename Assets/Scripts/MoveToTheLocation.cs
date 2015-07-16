using UnityEngine;
using System.Collections;

public class MoveToTheLocation : MonoBehaviour {
	
	public void Move(string locationName) {
		Application.LoadLevel (LocationUtils.SceneName(locationName));
	}
}

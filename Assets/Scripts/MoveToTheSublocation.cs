using UnityEngine;
using System.Collections;

public class MoveToTheSublocation : MonoBehaviour {
	
	public void Move(string sublocationName) {
		Application.LoadLevel (SublocationUtils.SceneName(sublocationName));
	}
}

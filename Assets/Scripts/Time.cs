using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time : MonoBehaviour {
	Text TimeText;

	string[] TimeName = {"Утро", "День", "Вечер", "Ночь"}; 
	static int Now = 0;

	void OnLevelWasLoaded(int level){
		UpdateTime();
	}

	public void FaseOut(){
		Now++;
		Now %= 4;
		UpdateTime();
	}

	void UpdateTime(){
		TimeText = GameObject.Find ("TimeText").GetComponent<Text> ();
		TimeText.text = TimeName[Now];
	}
}

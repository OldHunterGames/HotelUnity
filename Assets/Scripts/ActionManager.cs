using UnityEngine;
using System.Collections;

public class ActionManager : MonoBehaviour {

	void Start () {
	
	}

	ShortAction getNextShortAction() {
		ShortAction action = new MoveToTheSublocationShortAction(gameObject.name);
		Debug.Log (string.Format("Location Name = {0}, CharacterName = ","Unknow location",gameObject.name));
		action.actionSource = gameObject;
		action.actionTarget = gameObject;
		return action;
	}
}

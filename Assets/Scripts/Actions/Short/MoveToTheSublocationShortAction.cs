using UnityEngine;
using System.Collections;

public class MoveToTheSublocationShortAction : ShortAction {

	private string _sublocationName;

	public MoveToTheSublocationShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}

	override public void ExecuteShortAction() {
//		var componentLocation = actionSource.GetComponent<CharacterLocationComponent> ();
//		var newLocationObject = GameObject.Find (string.Format ("{0}/Characters", _sublocationName));
//		Debug.Assert (newLocationObject, string.Format ("Location {0} is not found!", _sublocationName));
//		if (newLocationObject) {
//			componentLocation.sublocation = _sublocationName;
//			componentLocation.transform.parent = newLocationObject.transform;
//		}
		Debug.Log (string.Format ("Short action '{0}'. '{1}' moved to the '{2}'.", GetType(), actionSource.name, _sublocationName));
	}
}

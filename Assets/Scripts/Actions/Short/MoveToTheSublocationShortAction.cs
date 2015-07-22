using UnityEngine;
using System.Collections;

public class MoveToTheSublocationShortAction : ShortAction {

	private string _sublocationName;

	public MoveToTheSublocationShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}

	override public void ExecuteShortAction() {
		var componentLocation = actionSource.GetComponent<CharacterLocationComponent> ();
		componentLocation.sublocation = _sublocationName;

		Debug.Log (string.Format ("Short action '{0}'. '{1}' moved to the '{2}'.", GetType(), actionSource.name, _sublocationName));
	}
}

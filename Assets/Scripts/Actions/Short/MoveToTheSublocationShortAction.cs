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
	}
}

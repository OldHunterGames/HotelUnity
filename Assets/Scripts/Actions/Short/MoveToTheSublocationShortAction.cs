using UnityEngine;
using System.Collections;

public class MoveToTheSublocationShortAction : ShortAction {

	private string _sublocationName;

	public MoveToTheSublocationShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}

	override public void ExecuteAction() {
		var currentLocation = actionTarget.transform.parent;
		var targetLocation = GameObject.Find (string.Format("Locations/{0}/Characters", _sublocationName));
		Debug.Log (string.Format ("Short action '{0}'. '{1}' moved from {2} to the '{3}'.", GetType(), actionTarget.name, currentLocation.parent.name, _sublocationName));
		actionTarget.transform.parent = targetLocation.transform;

		if (actionTarget.name.Equals ("Player")) {
			SublocationUtils.UpdateInterfaceForPlayer (_sublocationName);
        }
	}
}

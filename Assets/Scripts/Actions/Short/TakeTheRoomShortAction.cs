using UnityEngine;
using System.Collections;

public class TakeTheRoomShortAction : ShortAction {

	private string _sublocationName;
	
	public TakeTheRoomShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}
	
	override public void ExecuteAction() {
		var currentLocation = actionTarget.transform.parent;
		var targetLocation = GameObject.Find (string.Format("Locations/{0}/Characters", _sublocationName));
		var ownerComponent = actionSource.GetComponent<OwnerObjectDetails> ();

		Debug.Log (string.Format ("Short action '{0}'. '{1}' take '{3}'.", GetType(), actionTarget.name, currentLocation.parent.name, _sublocationName));
		actionTarget.transform.parent = targetLocation.transform;
		ownerComponent.owner = actionTarget;

		if (actionTarget.name.Equals ("Player")) {
			SublocationUtils.UpdateInterfaceForPlayer (_sublocationName);
		}
	}
}

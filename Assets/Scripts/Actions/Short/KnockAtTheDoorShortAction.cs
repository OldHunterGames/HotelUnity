using UnityEngine;
using System.Collections;

public class KnockAtTheDoorShortAction : ShortAction {

	private string _sublocationName;
	
	public KnockAtTheDoorShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}
	
	override public void ExecuteAction() {
		var currentLocation = actionTarget.transform.parent;
		var targetLocation = GameObject.Find (string.Format("Locations/{0}/Characters", _sublocationName));
		var ownerComponent = actionSource.GetComponent<OwnerObjectDetails> ();

		Debug.Log (string.Format ("Short action '{0}'. '{1}' knocked at the '{3}' door.", GetType(), actionTarget.name, currentLocation.parent.name, _sublocationName));

		if (targetLocation.transform.Find (ownerComponent.owner.name) == null) {
			Debug.Log (string.Format ("{0} have been knocking at the {1} door for 5 minutes already but nobody opens it", actionTarget.name, _sublocationName));
		} else {
			Debug.Log (string.Format ("{0} have been invited inside of {1}.",actionTarget.name, _sublocationName));
			actionTarget.transform.parent = targetLocation.transform;
			
			if (actionTarget.name.Equals ("Player")) {
				SublocationUtils.UpdateInterfaceForPlayer (_sublocationName);
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class CookShortAction : ShortAction {

	private GameObject _foodInstance;
	private GameObject _destination;
	
	public CookShortAction(GameObject foodInstance, GameObject destination) {
		_foodInstance = foodInstance;
		_destination = destination;
	}

	override public void ExecuteShortAction() {

		var destinationObjects = _destination.transform.FindChild("Objects");
		Debug.Assert (destinationObjects != null, "Source object should attach destinationObjects.");
		Debug.Assert (_foodInstance != null, "Source object should attach _foodInstance.");
		_foodInstance.transform.parent = destinationObjects.transform;
		Debug.Log (string.Format ("Short action '{0}'. '{1}' prepare {2} on {3} and put it in {4} sublocation.", GetType (), actionTarget.name, _foodInstance.name, actionSource.name, _destination.name));
	}
}
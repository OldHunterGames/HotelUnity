using UnityEngine;
using System.Collections;

public class MassCookPhaseAction : PhaseAction {

	private GameObject _foodInstance;
	private GameObject _destination;
	
	public MassCookPhaseAction(GameObject foodInstance, GameObject destination) {
		_foodInstance = foodInstance;
		_destination = destination;
	}

	override public void ExecuteAction() {

		var destinationObjects = _destination.transform.FindChild("Objects");
		Debug.Assert (destinationObjects != null, "Source object should attach destinationObjects.");
		Debug.Assert (_foodInstance != null, "Source object should attach _foodInstance.");
		_foodInstance.transform.parent = destinationObjects.transform;
		
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' prepare {2} on {3} and put it in {4} sublocation.", GetType (), actionTarget.name, _foodInstance.name, actionSource.name, _destination.name));

		var action = new SatisfyAltruismAction();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();

	}
}

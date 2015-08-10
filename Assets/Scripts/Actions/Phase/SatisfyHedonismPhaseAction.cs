using UnityEngine;
using System.Collections;

public class SatisfyHedonismPhaseAction : PhaseAction {
	
	override public void ExecutePhaseAction() {
		var component = actionTarget.GetComponent<HedonismCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HedonismCharacterComponent.");
		var hedonismDetails = actionSource.GetComponent<HedonismObjectDetails> ();
		Debug.Assert (hedonismDetails != null, "Source object should attach HedonismObjectDetails.");
		
		component.hedonism -= hedonismDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' relax on '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

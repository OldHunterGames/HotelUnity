using UnityEngine;
using System.Collections;

public class SatisfySleepAction : Action {

	public override void ExecuteAction() {
		var component = actionTarget.GetComponent<SleepCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HedonismCharacterComponent.");
		var hedonismDetails = actionSource.GetComponent<SleepObjectDetails> ();
		Debug.Assert (hedonismDetails != null, "Source object should attach HedonismObjectDetails.");
		
		component.freshness += hedonismDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Sleep need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

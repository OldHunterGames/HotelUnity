using UnityEngine;
using System.Collections;

public class SatisfySleepAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<SleepCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach SleepCharacterComponent.");
		var hedonismDetails = actionSource.GetComponent<SleepObjectDetails> ();
		Debug.Assert (hedonismDetails != null, "Source object should attach SleepObjectDetails.");
		
		needComponent.freshness += hedonismDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Sleep need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

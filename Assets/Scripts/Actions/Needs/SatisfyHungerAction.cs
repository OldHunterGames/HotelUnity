using UnityEngine;
using System.Collections;

public class SatisfyHungerAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach HungerCharacterComponent.");
		var hedonismDetails = actionSource.GetComponent<HungerObjectDetails> ();
		Debug.Assert (hedonismDetails != null, "Source object should attach HungerObjectDetails.");
		
		needComponent.value -= hedonismDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Food need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

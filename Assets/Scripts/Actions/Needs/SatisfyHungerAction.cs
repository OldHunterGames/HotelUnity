using UnityEngine;
using System.Collections;

public class SatisfyHungerAction : Action {

	public override void ExecuteAction() {
		var component = actionTarget.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HedonismCharacterComponent.");
		var hedonismDetails = actionSource.GetComponent<HungerObjectDetails> ();
		Debug.Assert (hedonismDetails != null, "Source object should attach HedonismObjectDetails.");
		
		component.hunger += hedonismDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Food need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

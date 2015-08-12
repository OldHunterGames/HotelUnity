using UnityEngine;
using System.Collections;

public class SatisfyGreedAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<GreedCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach GreedCharacterComponent.");
		var needDetails = actionSource.GetComponent<GreedObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach GreedObjectDetails.");
		
		needComponent.value -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Greed need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

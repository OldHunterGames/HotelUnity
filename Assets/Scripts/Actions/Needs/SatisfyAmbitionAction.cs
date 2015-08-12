using UnityEngine;
using System.Collections;

public class SatisfyAmbitionAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<AmbitionCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach AmbitionCharacterComponent.");
		var needDetails = actionSource.GetComponent<AmbitionObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach AmbitionObjectDetails.");
		
		needComponent.value -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Ambition need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

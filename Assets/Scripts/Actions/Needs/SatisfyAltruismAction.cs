using UnityEngine;
using System.Collections;

public class SatisfyAltruismAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<AltruismCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach AltruismCharacterComponent.");
		var needDetails = actionSource.GetComponent<AltruismObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach AltruismObjectDetails.");
		
		needComponent.value -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Altruism need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

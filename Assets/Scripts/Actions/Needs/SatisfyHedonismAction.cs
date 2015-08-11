using UnityEngine;
using System.Collections;

public class SatisfyHedonismAction : Action {
	
	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<HedonismCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach HedonismCharacterComponent.");
		var needDetails = actionSource.GetComponent<HedonismObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach HedonismObjectDetails.");
		
		needComponent.hedonism -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Hedonism need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

using UnityEngine;
using System.Collections;

public class SatisfyEntertainmentAction : Action {
	
	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<EntertainmentCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach EntertainmentCharacterComponent.");
		var needDetails = actionSource.GetComponent<EntertainmentObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach EntertainmentObjectDetails.");
		
		needComponent.entertainment -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Entertainment need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

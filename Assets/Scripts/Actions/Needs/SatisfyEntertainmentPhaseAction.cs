using UnityEngine;
using System.Collections;

public class SatisfyEntertainmentAction : Action {
	
	public override void ExecuteAction() {
		var component = actionTarget.GetComponent<EntertainmentCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach EntertainmentCharacterComponent.");
		var entertainmentDetails = actionSource.GetComponent<EntertainmentObjectDetails> ();
		Debug.Assert (entertainmentDetails != null, "Source object should attach EntertainmentObjectDetails.");
		
		component.entertainment -= entertainmentDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Entertainment need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

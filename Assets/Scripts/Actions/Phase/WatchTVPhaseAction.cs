using UnityEngine;
using System.Collections;

public class WatchTVPhaseAction : PhaseAction {
	
	override public void ExecutePhaseAction() {
		var component = actionTarget.GetComponent<EntertainmentCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HungerCharacterComponent.");
		var entertainmentDetails = actionSource.GetComponent<EntertainmentObjectDetails> ();
		Debug.Assert (entertainmentDetails != null, "Source object should attach EntertainmentObjectDetails.");
		
		component.entertainment -= entertainmentDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' watch '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

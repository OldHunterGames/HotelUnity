using UnityEngine;
using System.Collections;

public class WalkerPhaseActionsProducer : PhaseActionsProducer {
		
	public override PhaseAction ProducePhaseAction() {

		var character = gameObject.GetComponent<Character> ();
		var sublocation = character.Sublocation.GetComponent<Sublocation> ();
		var actionFabric = sublocation.getActionFabric<SleepPhaseActionFabric> ();
		Debug.Assert (sublocation != null, "Object should be attached SleepPhaseActionFabric");
		if (actionFabric == null) {
			return null;
		}
		var action = actionFabric.CreatePhaseAction (gameObject);
		Debug.Log (gameObject.name);
		return action;
	}
	
	public override void OnPhaseFinish () {}
}

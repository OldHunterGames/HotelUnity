using UnityEngine;
using System.Collections;

public class LocationPhaseActionsProducer : PhaseActionsProducer {
		
	public override PhaseAction ProducePhaseAction() {
		var action = new IdlePhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = gameObject;

		return action;
	}

	public override void OnPhaseFinish () {}
}
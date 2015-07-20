using UnityEngine;
using System.Collections;

public class WalkerPhaseActionsProducer : PhaseActionsProducer {
		
	public override PhaseAction ProducePhaseAction() {
		var action = new SleepPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = gameObject;

		return action;
	}
	
	public override void OnPhaseStart () {}
}

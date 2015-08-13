using UnityEngine;
using System.Collections;

public class BarPhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new BarPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
}

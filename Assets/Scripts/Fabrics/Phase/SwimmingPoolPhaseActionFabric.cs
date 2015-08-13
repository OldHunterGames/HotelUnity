using UnityEngine;
using System.Collections;

public class SwimmingPoolPhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new SwimmingPoolPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
}

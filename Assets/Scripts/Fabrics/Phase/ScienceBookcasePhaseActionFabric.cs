using UnityEngine;
using System.Collections;

public class ScienceBookcasePhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new ScienceBookcasePhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
}

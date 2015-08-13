using UnityEngine;
using System.Collections;

public class FictionBookcasePhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new FictionBookcasePhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
}

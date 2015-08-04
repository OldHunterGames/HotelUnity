using UnityEngine;
using System.Collections;

public class IdlePhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new IdlePhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;

		return action;
	}
}

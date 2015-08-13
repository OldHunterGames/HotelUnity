using UnityEngine;
using System.Collections;

public class GymPhaseActionFabric : PhaseActionFabric {

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new GymPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
}

using UnityEngine;
using System.Collections;

public class GymPhaseActionFabric : PhaseActionFabric {

	public string title;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new GymPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
	
	public override string caption {
		get {
			return title;
		}
	}
}

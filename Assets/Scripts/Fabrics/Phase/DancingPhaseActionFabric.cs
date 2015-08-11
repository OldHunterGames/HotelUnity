using UnityEngine;
using System.Collections;

public class DancingPhaseActionFabric : PhaseActionFabric {

	public string title;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new DancingPhaseAction ();
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

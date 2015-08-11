using UnityEngine;
using System.Collections;

public class ScienceBookcasePhaseActionFabric : PhaseActionFabric {

	public string title;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new ScienceBookcasePhaseAction ();
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

using UnityEngine;
using System.Collections;

public class EaselPhaseActionFabric : PhaseActionFabric {
	
	public string title;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new EaselPhaseAction ();
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

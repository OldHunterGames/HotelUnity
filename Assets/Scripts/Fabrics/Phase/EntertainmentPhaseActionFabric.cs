using UnityEngine;
using System.Collections;

public class EntertainmentPhaseActionFabric : PhaseActionFabric {
	
	public string title;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new SatisfyEntertainmentPhaseAction ();
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

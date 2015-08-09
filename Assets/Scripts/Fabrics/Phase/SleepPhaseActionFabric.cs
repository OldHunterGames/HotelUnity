using UnityEngine;
using System.Collections;

public class SleepPhaseActionFabric : PhaseActionFabric {

	public string bedName;

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new SleepPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}

	public override string caption {
		get {
			return string.Format("Поспать на {0}", bedName);
		}
	}
}

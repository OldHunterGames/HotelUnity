using UnityEngine;
using System.Collections;

public class WatchTVPhaseActionFabric : PhaseActionFabric {
	
	public string tvName;
	
	override public PhaseAction CreatePhaseAction(GameObject target) {
		var action = new WatchTVPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
	
	public override string caption {
		get {
			return string.Format("Смотреть {0}", tvName);
		}
	}
}

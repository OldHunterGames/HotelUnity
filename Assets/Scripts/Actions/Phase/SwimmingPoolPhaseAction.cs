using UnityEngine;
using System.Collections;

public class SwimmingPoolPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' is swimming in the '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyHedonismAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

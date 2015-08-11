using UnityEngine;
using System.Collections;

public class BarPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' drinks in '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyEntertainmentAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

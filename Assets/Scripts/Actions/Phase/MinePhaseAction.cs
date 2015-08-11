using UnityEngine;
using System.Collections;

public class MinePhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' works in '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyGreedAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

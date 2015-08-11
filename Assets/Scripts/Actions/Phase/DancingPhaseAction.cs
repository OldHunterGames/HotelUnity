using UnityEngine;
using System.Collections;

public class DancingPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' is '{2}'.", GetType (), actionTarget.name, actionSource.name));
		
		var action = new SatisfyCreativityAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

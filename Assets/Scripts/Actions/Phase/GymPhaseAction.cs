using UnityEngine;
using System.Collections;

public class GymPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' training in the '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyAmbitionAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

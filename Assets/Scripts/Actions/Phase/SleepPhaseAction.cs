using UnityEngine;
using System.Collections;

public class SleepPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' sleeps on '{2}'.", GetType(), actionTarget.name, actionSource.name));

		var action = new SatisfySleepAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

using UnityEngine;
using System.Collections;

public class SofaPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' relaxing on '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyHedonismAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

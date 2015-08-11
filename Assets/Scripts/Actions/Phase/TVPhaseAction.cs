using UnityEngine;
using System.Collections;

public class TVPhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' watching TV. '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyEntertainmentAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

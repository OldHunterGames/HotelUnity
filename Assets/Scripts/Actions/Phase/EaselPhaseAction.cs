using UnityEngine;
using System.Collections;

public class EaselPhaseAction : PhaseAction {
	
	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' painting on '{2}'.", GetType (), actionTarget.name, actionSource.name));
		
		var action = new SatisfyCreativityAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

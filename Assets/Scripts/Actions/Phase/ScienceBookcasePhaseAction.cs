using UnityEngine;
using System.Collections;

public class ScienceBookcasePhaseAction : PhaseAction {

	override public void ExecuteAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' reading book from '{2}'.", GetType(), actionTarget.name, actionSource.name));
		
		var action = new SatisfyCuriosityAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

using UnityEngine;
using System.Collections;

public class EatShortAction : ShortAction {
		
	override public void ExecuteAction() {
		Debug.Log (string.Format ("Short action '{0}'. '{1}' eats {2}.", GetType (), actionTarget.name, actionSource.name));

		var action = new SatisfyHungerAction ();
		action.actionSource = actionSource;
		action.actionTarget = actionTarget;
		action.ExecuteAction ();
	}
}

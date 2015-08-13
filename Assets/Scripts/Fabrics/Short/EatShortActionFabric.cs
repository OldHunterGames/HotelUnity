using UnityEngine;
using System.Collections;

public class EatShortActionFabric : ShortActionFabric {

	public override ShortAction CreateShortAction(GameObject target) {
		var action = new EatShortAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}
}

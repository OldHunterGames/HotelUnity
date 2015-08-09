using UnityEngine;
using System.Collections;

public class EatShortActionFabric : ShortActionFabric {

	public string foodName;

	override public ShortAction CreateShortAction(GameObject target) {
		var action = new EatShortAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}

	public override string caption {
		get {
			return string.Format("Съесть {0}", foodName);
		}
	}
}

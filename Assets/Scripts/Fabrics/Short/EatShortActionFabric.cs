using UnityEngine;
using System.Collections;

public class EatShortActionFabric : ShortActionFabric {

	public override ShortAction CreateShortAction(GameObject target) {
		var action = new EatShortAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}

	public override string caption {
		get {
			var foodInfo = gameObject.GetComponent<HungerObjectDetails>();
			string foodName = foodInfo.needName.Length > 0 ? foodInfo.needName : gameObject.name;

			return string.Format("Съесть {0}", foodName);
		}
	}
}

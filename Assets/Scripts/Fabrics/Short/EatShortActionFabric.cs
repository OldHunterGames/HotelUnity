using UnityEngine;
using System.Collections;

public class EatShortActionFabric : ShortActionFabric {

	override public ShortAction CreateShortAction(GameObject target) {
		var action = new EatShortAction ();
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}

	public override string caption {
		get {
			var foodInfo = gameObject.GetComponent<FoodDetailsComponent>();
			string foodName = foodInfo.foodName.Length > 0 ? foodInfo.foodName : gameObject.name;

			return string.Format("Съесть {0}", foodName);
		}
	}
}

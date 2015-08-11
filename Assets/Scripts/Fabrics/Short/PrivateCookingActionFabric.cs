using UnityEngine;
using System.Collections;

public class PrivateCookingActionFabric : ShortActionFabric {

	public GameObject food;
	public GameObject destination;

	override public ShortAction CreateShortAction(GameObject target) {
		var foodInstance = Instantiate (food);
		foodInstance.name = string.Format("{0}(Temp)", food.name);

		var action = new CookShortAction (foodInstance, destination);
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}
	
	public override string caption {
		get {
			return string.Format("Приготовить себе {0} на {1}", food.name, gameObject.name);
		}
	}
}

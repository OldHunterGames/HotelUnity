using UnityEngine;
using System.Collections;

public class PublicCookingActionFabric : PhaseActionFabric {

	public string title;
	public GameObject food;
	public GameObject destination;

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var foodInstance = Instantiate (food);
		foodInstance.name = string.Format("{0}(Temp)", food.name);

		var action = new MassCookPhaseAction (foodInstance, destination);
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}
	
	public override string caption {
		get {
			return title;
		}
	}
}

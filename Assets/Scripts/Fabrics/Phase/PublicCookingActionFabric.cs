using UnityEngine;
using System.Collections;

public class PublicCookingActionFabric : PhaseActionFabric {

	public GameObject food;
	public GameObject destination;

	override public PhaseAction CreatePhaseAction(GameObject target) {
		var foodInstance = Instantiate (food);
		foodInstance.name = "Fastfood(Temp)";

		var action = new MassCookPhaseAction (foodInstance, destination);
		action.actionSource = gameObject;
		action.actionTarget = target;
		return action;
	}
	
	public override string caption {
		get {
			var foodInfo = gameObject.GetComponent<AltruismObjectDetails>();
			string foodName = foodInfo.needName.Length > 0 ? foodInfo.needName : gameObject.name;
			return string.Format("Приготовить всем {0} на {1}", foodName, gameObject.name);
		}
	}
}

using UnityEngine;
using System.Collections;

public class NeederPhaseActionProducer : PhaseActionsProducer {
	
	public override PhaseAction ProducePhaseAction() {
		var componentLocation = gameObject.GetComponent<CharacterLocationComponent> ();
		Debug.Assert (componentLocation != null, "Object should attach CharacterLocationComponent.");

		var componentNeeds = gameObject.GetComponent<NeedsCharacterComponent> ();
		Debug.Assert (componentNeeds != null, "Object should attach NeedsCharacterComponent.");

		if (componentNeeds.NeedForSleep > 0 && componentLocation.sublocation.Equals ("RoomInside")) {
			var action = new NeederSleepPhaseAction ();
			action.actionSource = gameObject;
			action.actionTarget = gameObject;
		
			return action;
		} else {
			return null;
		}
	}
	
	public override void OnPhaseFinish () {}
}

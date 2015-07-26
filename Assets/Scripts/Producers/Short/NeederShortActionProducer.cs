using UnityEngine;
using System.Collections;

public class NeederShortActionProducer : WalkerShortActionsProducer {
	
	public override ShortAction ProduceShortAction () {
		var componentNeeds = gameObject.GetComponent<NeedsCharacterComponent> ();
		Debug.Assert (componentNeeds != null, "Object should attach NeedsCharacterComponent.");
		
		var componentLocation = gameObject.GetComponent<CharacterLocationComponent> ();
		Debug.Assert (componentLocation != null, "Object should attach CharacterLocationComponent.");
		
		if (componentNeeds.Hunger > 0 && componentLocation.sublocation.Equals("DiningRoom")) {
			var action = new NeederEatShortAction();
			action.actionSource = gameObject;

			return action;
		} else {
			return base.ProduceShortAction ();
		}
	}
	
	public override void OnPhaseFinish () {
		var component = gameObject.GetComponent<NeedsCharacterComponent> ();
		
		Debug.Assert (component != null, "Object should attach NeedsCharacterComponent.");

		if (component.Hunger == 5) {
			targetSublocation = "DiningRoom";
		} else if (component.NeedForSleep == 5) {
			targetSublocation = "RoomInside";
		} else {
			base.OnPhaseFinish ();
		}
	}
}

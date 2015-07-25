using UnityEngine;
using System.Collections;

public class EaterShortActionsProducer : WalkerShortActionsProducer {

	public override ShortAction ProduceShortAction () {
		var componentHunger = gameObject.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (componentHunger != null, "Object should attach HungerCharacterComponent.");

		var componentLocation = gameObject.GetComponent<CharacterLocationComponent> ();
		Debug.Assert (componentLocation != null, "Object should attach CharacterLocationComponent.");

		if (componentHunger.hunger > 0 && componentLocation.sublocation.Equals("DiningRoom")) {
			var action = new EatShortAction();
			action.actionSource = gameObject;

			return action;
		} else {
			return base.ProduceShortAction ();
		}
	}

	public override void OnPhaseFinish () {
		var component = gameObject.GetComponent<HungerCharacterComponent> ();

		Debug.Assert (component != null, "Object should attach HungerCharacterComponent.");

		if (component.hunger == 5) {
			targetSublocation = "DiningRoom";
		} else {
			base.OnPhaseFinish ();
		}
	}
}

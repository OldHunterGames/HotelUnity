using UnityEngine;
using System.Collections;

public class EaterShortActionsProducer : WalkerShortActionsProducer {

	public override ShortAction ProduceShortAction () {
		var componentHunger = gameObject.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (componentHunger != null, "Object should attach HungerCharacterComponent.");

		var character = gameObject.GetComponent<Character> ();
		var sublocation = character.Sublocation.GetComponent<Sublocation> ();
		Debug.Assert (sublocation != null, "Object should attach Sublocation.");

		if (componentHunger.value > 0 && sublocation.name.Equals("Kitchen")) {

			var actionFabric = sublocation.getActionFabric<EatShortActionFabric> ();
			Debug.Assert (actionFabric != null, "Object should attach EatShortActionFabric.");
			if (actionFabric == null) {
				return null;
			}
			var action = actionFabric.CreateShortAction (gameObject);
			return action;
		} else {
			return base.ProduceShortAction ();
		}
	}

	public override void OnPhaseFinish () {
		var componentHunger = gameObject.GetComponent<HungerCharacterComponent> ();

		Debug.Assert (componentHunger != null, "Object should attach HungerCharacterComponent.");

		if (componentHunger.value >= 5) {
			targetSublocation = "Kitchen";
		} else {
			base.OnPhaseFinish ();
		}
	}
}

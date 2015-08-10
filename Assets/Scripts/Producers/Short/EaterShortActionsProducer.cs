using UnityEngine;
using System.Collections;

public class EaterShortActionsProducer : WalkerShortActionsProducer {

	public override ShortAction ProduceShortAction () {
		var componentHunger = gameObject.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (componentHunger != null, "Object should attach HungerCharacterComponent.");

		var character = gameObject.GetComponent<Character> ();
		var sublocation = character.Sublocation.GetComponent<Sublocation> ();

		if (componentHunger.hunger > 0 && sublocation.name.Equals("DiningRoom")) {

			var actionFabric = sublocation.getActionFabric<EatShortActionFabric> ();
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
		var component = gameObject.GetComponent<HungerCharacterComponent> ();

		Debug.Assert (component != null, "Object should attach HungerCharacterComponent.");

		if (component.hunger == 5) {
			targetSublocation = "DiningRoom";
		} else {
			base.OnPhaseFinish ();
		}
	}
}

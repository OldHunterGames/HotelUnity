using UnityEngine;
using System.Collections;

public class EatShortAction : ShortAction {
		
	override public void ExecuteShortAction() {
		var component = actionTarget.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HungerCharacterComponent.");
		var foodDetails = actionSource.GetComponent<FoodDetailsComponent> ();
		Debug.Assert (component != null, "Source object should attach FoodDetailsComponent.");

		component.hunger -= foodDetails.hungerRestore;
		if (component.hunger < 0) {
			component.hunger = 0;
		}
		
		Debug.Log (string.Format ("Short action '{0}'. '{1}' eats {2}.", GetType(), actionTarget.name, foodDetails.foodName));
	}
}

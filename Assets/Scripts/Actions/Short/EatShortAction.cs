using UnityEngine;
using System.Collections;

public class EatShortAction : ShortAction {
		
	override public void ExecuteShortAction() {
		var component = actionTarget.GetComponent<HungerCharacterComponent> ();
		Debug.Assert (component != null, "Source object should attach HungerCharacterComponent.");
		var foodDetails = actionSource.GetComponent<FoodDetailsComponent> ();
		Debug.Assert (foodDetails != null, "Source object should attach FoodDetailsComponent.");

		component.hunger -= foodDetails.hungerRestore;
		Debug.Log (string.Format ("Short action '{0}'. '{1}' eats {2}.", GetType (), actionTarget.name, foodDetails.foodName));
	}
}

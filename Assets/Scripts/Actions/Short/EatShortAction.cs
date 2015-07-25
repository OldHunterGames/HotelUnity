using UnityEngine;
using System.Collections;

public class EatShortAction : ShortAction {
		
	override public void ExecuteShortAction() {
		var component = actionSource.GetComponent<HungerCharacterComponent> ();

		Debug.Assert (component != null, "Source object should attach HungerCharacterComponent.");

		if (component.hunger > 0) {
			component.hunger -= 1;
		}
		
		Debug.Log (string.Format ("Short action '{0}'. '{1}' eats.", GetType(), actionSource.name));
	}
}

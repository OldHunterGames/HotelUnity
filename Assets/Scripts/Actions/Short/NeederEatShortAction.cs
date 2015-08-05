using UnityEngine;
using System.Collections;

public class NeederEatShortAction : ShortAction {
		
	override public void ExecuteShortAction() {
		var component = actionSource.GetComponent<NeedsCharacterComponent> ();

		Debug.Assert (component != null, "Source object should attach NeedsCharacterComponent.");

		if (component.Hunger > 0) {
			component.Hunger -= 1;
		}
		
		Debug.Log (string.Format ("Short action '{0}'. '{1}' eats.", GetType(), actionSource.name));
	}
}

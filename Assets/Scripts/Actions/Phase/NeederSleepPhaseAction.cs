using UnityEngine;
using System.Collections;

public class NeederSleepPhaseAction : PhaseAction {
	
	override public void ExecutePhaseAction() {
		var component = actionSource.GetComponent<NeedsCharacterComponent> ();
		
		Debug.Assert (component != null, "Source object should attach NeedsCharacterComponent.");
		
		if (component.Freshness < 15) {
			component.Freshness += 5;
			if (component.Freshness > 15) component.Freshness = 15;
		}
	}
}

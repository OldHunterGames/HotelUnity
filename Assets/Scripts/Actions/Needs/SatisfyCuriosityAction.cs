using UnityEngine;
using System.Collections;

public class SatisfyCuriosityAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<CuriosityCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach CuriosityCharacterComponent.");
		var needDetails = actionSource.GetComponent<CuriosityObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach CuriosityObjectDetails.");
		
		needComponent.curiosity -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Curiosity need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

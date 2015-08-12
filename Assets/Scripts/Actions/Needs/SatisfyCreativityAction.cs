using UnityEngine;
using System.Collections;

public class SatisfyCreativityAction : Action {

	public override void ExecuteAction() {
		var needComponent = actionTarget.GetComponent<CreativityCharacterComponent> ();
		Debug.Assert (needComponent != null, "Source object should attach CreativityCharacterComponent.");
		var needDetails = actionSource.GetComponent<CreativityObjectDetails> ();
		Debug.Assert (needDetails != null, "Source object should attach CreativityObjectDetails.");
		
		needComponent.value -= needDetails.needSatisfyRate;
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' satisfy his Creativity need via '{2}'.", GetType(), actionTarget.name, actionSource.name));
	}
}

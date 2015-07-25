using UnityEngine;
using System.Collections;

public class SleepPhaseAction : PhaseAction {

	override public void ExecutePhaseAction() {
		Debug.Log (string.Format ("PhaseAction action '{0}'. 'Character sleep'.", actionSource));
	}
}

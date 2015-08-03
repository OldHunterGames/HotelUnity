using UnityEngine;
using System.Collections;

public class SleepPhaseAction : PhaseAction {

	override public void ExecutePhaseAction() {
		Debug.Log (string.Format ("Phase action '{0}'. '{1}' sleeps.", GetType(), actionSource.name));
	}
}

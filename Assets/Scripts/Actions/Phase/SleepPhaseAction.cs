using UnityEngine;
using System.Collections;

public class SleepPhaseAction : PhaseAction {

	override public void ExecutePhaseAction() {
		var loggerObject = GameObject.Find ("Logger");
		var logger = loggerObject.GetComponent<Logger> ();

		logger.AddEvent (string.Format ("PhaseAction action. Character '{0}' sleep.", actionSource.name));
		Debug.Log (string.Format ("PhaseAction action. Character '{0}' sleep.", actionSource.name));
	}
}

using UnityEngine;
using System.Collections;

public class PlayerPhaseActionsProducer : PhaseActionsProducer {
	
	private PhaseAction _phaseAction;
	
	public override PhaseAction ProducePhaseAction() {
		var retval = _phaseAction;
		_phaseAction = null;
		return retval;
	}
	
	public void SetPhaseAction(PhaseAction phaseAction) {
		_phaseAction = phaseAction;
	}
	
	public override void OnPhaseFinish () {}
}

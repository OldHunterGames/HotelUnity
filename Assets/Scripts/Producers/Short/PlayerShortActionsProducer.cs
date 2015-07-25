using UnityEngine;
using System.Collections;

public class PlayerShortActionsProducer : ShortActionsProducer {
	
	private ShortAction _shortAction;

	public override ShortAction ProduceShortAction() {
		var retval = _shortAction;
		_shortAction = null;
		return retval;
	}

	public void SetShortAction(ShortAction shortAction) {
		_shortAction = shortAction;
	}
	
	public override void OnPhaseFinish () {}
}

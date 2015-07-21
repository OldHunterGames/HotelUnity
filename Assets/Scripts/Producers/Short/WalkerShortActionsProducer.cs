using UnityEngine;
using System.Collections;

public class WalkerShortActionsProducer : ShortActionsProducer {

	private static readonly int MAX_STEPS = 3;

	private int stepsRemaining = MAX_STEPS;
	
	public override ShortAction ProduceShortAction() {
		if (stepsRemaining > 0) {
			stepsRemaining -= 1;

			var action = new MoveToTheSublocationShortAction (SublocationUtils.RandomSublocation());
			action.actionSource = gameObject;
			action.actionTarget = gameObject;

			return action;
		} else {
			return null;
		}
	}

	public override void OnPhaseStart () {
		stepsRemaining = MAX_STEPS;
	}
}

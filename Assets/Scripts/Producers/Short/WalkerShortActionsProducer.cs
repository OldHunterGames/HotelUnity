using UnityEngine;
using System.Collections;

public class WalkerShortActionsProducer : ShortActionsProducer {
	
	private string _targetSublocation = "Library";

	public override ShortAction ProduceShortAction() {
		var componentLocation = gameObject.GetComponent<CharacterLocationComponent> ();

		Debug.Assert (componentLocation != null, "Object should attach CharacterLocationComponent.");

		if (!componentLocation.location.Equals (_targetSublocation)) {
			var nextSublocation = SublocationUtils.GetNextSublocationInRoute(componentLocation.sublocation, _targetSublocation);

			if (nextSublocation != null) {
				var action = new MoveToTheSublocationShortAction (nextSublocation);
				action.actionSource = gameObject;
				action.actionTarget = gameObject;

				return action;
			} else {
				return null;
			}
		} else {
			return null;
		}
	}

	public override void OnPhaseFinish () {
		var previousLocation = _targetSublocation;

		_targetSublocation = SublocationUtils.RandomSublocation();

		Debug.Log (string.Format("'{0}' wants move to the '{1}' from '{2}'.", gameObject.name, _targetSublocation, previousLocation));
	}
}

using UnityEngine;
using System.Collections;

public class WalkerShortActionsProducer : ShortActionsProducer {
	
	private string _targetSublocation = "Library";

	public override ShortAction ProduceShortAction() {
		var currentSubLocation = gameObject.transform.parent.parent;
		Debug.Assert (currentSubLocation != null, "Object should be child of Location/Characters");
		if (!currentSubLocation.name.Equals (_targetSublocation)) {
			var nextSublocationName = SublocationUtils.GetNextSublocationInRoute(currentSubLocation.name, _targetSublocation);
			var action = new MoveToTheSublocationShortAction (nextSublocationName);
			action.actionSource = gameObject;
			action.actionTarget = gameObject;
			return action;
		} else {
			return null;
		}
	}

	protected string targetSublocation {
		get {
			return _targetSublocation;
		}

		set {
			_targetSublocation = value;
		}
	}

	public override void OnPhaseFinish () {
		var previousLocation = _targetSublocation;

		_targetSublocation = SublocationUtils.RandomSublocation();

		Debug.Log (string.Format("'{0}' wants move to the '{1}' from '{2}'.", gameObject.name, _targetSublocation, previousLocation));
	}
}

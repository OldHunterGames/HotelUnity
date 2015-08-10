using UnityEngine;
using System.Collections;

public class WalkerShortActionsProducer : ShortActionsProducer {
	
	private string _targetSublocation = "Library";

	public override ShortAction ProduceShortAction() {
		var character = gameObject.GetComponent<Character> ();
		var sublocation = character.Sublocation.GetComponent<Sublocation> ();

		Debug.Assert (sublocation != null, "Object should be child of Location/Characters");
		if (!sublocation.name.Equals (_targetSublocation)) {
			var nextSublocationName = SublocationUtils.GetNextSublocationInRoute(sublocation.name, _targetSublocation);

			foreach (var actionFabric in sublocation.getActionFabrics<MoveToSublocationActionFabric> ())
			{
				if (actionFabric.TargetSublocation.name == nextSublocationName) {
					var action = actionFabric.CreateShortAction (gameObject);
					return action;
				}
			}
			return null;
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
		_targetSublocation = SublocationUtils.RandomSublocation();
	}
}

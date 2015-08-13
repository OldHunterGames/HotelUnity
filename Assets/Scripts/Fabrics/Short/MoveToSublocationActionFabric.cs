using UnityEngine;
using System.Collections;

public class MoveToSublocationActionFabric : ShortActionFabric {

	public GameObject TargetSublocation;

	override public ShortAction CreateShortAction(GameObject target) {
		var action = new MoveToTheSublocationShortAction (TargetSublocation.name);
		action.actionSource = gameObject;
		action.actionTarget = target;

		return action;
	}

	public override string title {
		get {
			return _title.Length == 0 ? string.Format("Move to {0}", TargetSublocation.name) : _title;
		}
	}
}

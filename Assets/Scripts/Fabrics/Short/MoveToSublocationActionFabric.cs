﻿using UnityEngine;
using System.Collections;

public class MoveToSublocationActionFabric : ShortActionFabric {

	public GameObject TargetSublocation;

	override public ShortAction CreateShortAction(GameObject target) {
		var action = new MoveToTheSublocationShortAction (TargetSublocation.name);
		action.actionSource = gameObject;
		action.actionTarget = target;

		return action;
	}

	override public bool characterCanSeeIt(GameObject character) {
		var ownerObject = gameObject.GetComponent<OwnerObjectDetails>();
		bool result = false;
		if (ownerObject == null) {
			result = true;
		} else if (ownerObject.owner == null || ownerObject.owner.name.Equals (character.name) ) {
			result = true;
		}
		return result;
	}

	public override string title {
		get {
			return _title.Length == 0 ? string.Format("Move to {0}", TargetSublocation.name) : _title;
		}
	}
}

﻿using UnityEngine;
using System.Collections;

public class KnockAtTheDoorActionFabric : ShortActionFabric {
	
	public GameObject TargetSublocation;
	
	override public ShortAction CreateShortAction(GameObject target) {
		var action = new KnockAtTheDoorShortAction (TargetSublocation.name);
		action.actionSource = gameObject;
		action.actionTarget = target;
		
		return action;
	}
	
	override public bool characterCanSeeIt(GameObject character) {
		var ownerObject = gameObject.GetComponent<OwnerObjectDetails>();
		bool result = false;
		if (ownerObject != null && ownerObject.owner != null && !ownerObject.owner.name.Equals (character.name) ) {
			result = true;
		}
		return result;
	}
	
	public override string title {
		get {
			return _title.Length == 0 ? string.Format("Knock at the door of {0}", TargetSublocation.name) : _title;
		}
	}
}
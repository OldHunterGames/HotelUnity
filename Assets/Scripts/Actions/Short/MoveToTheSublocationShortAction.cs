﻿using UnityEngine;
using System.Collections;

public class MoveToTheSublocationShortAction : ShortAction {

	private string _sublocationName;

	public MoveToTheSublocationShortAction(string sublocationName) {
		_sublocationName = sublocationName;
	}

	override public void ExecuteShortAction() {

		var currentLocation = actionSource.transform.parent;
		var targetLocation = GameObject.Find (string.Format("Locations/{0}/Characters", _sublocationName));
		Debug.Log (string.Format ("Short action '{0}'. '{1}' moved from {2} to the '{3}'.", GetType(), actionSource.name, currentLocation.parent.name, _sublocationName));
		actionSource.transform.parent = targetLocation.transform;
	}
}

using UnityEngine;
using System.Collections;

public abstract class PhaseActionFabric : BasicInformation {

	public abstract PhaseAction CreatePhaseAction(GameObject target);

	public virtual bool characterCanSeeIt(GameObject character) {
		return true;
	}
	
	public virtual bool characterCanDoIt(GameObject character) {
		// TODO: Add some logic for cases when character can see action but cannot choose it (Do not have some skill etc)
		return true;
	}

	public override string title {
		get {
			return _title.Length == 0 ? gameObject.name : _title;
		}
	}
}

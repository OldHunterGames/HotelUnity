using UnityEngine;
using System.Collections;

public abstract class PhaseActionFabric : BasicInformation {

	public abstract PhaseAction CreatePhaseAction(GameObject target);

	public override string title {
		get {
			return _title.Length == 0 ? gameObject.name : _title;
		}
	}
}

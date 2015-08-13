using UnityEngine;
using System.Collections;

public abstract class ShortActionFabric : BasicInformation {

	public abstract ShortAction CreateShortAction(GameObject target);

	public override string title {
		get {
			return _title.Length == 0 ? gameObject.name : _title;
		}
	}
}

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

	public override string caption {
		get {
			var sublocationInfo = TargetSublocation.GetComponent<Sublocation>();
			string sublocationName = sublocationInfo.locationName.Length > 0 ? sublocationInfo.locationName : TargetSublocation.name;

			return string.Format("Перейти в {0}", sublocationName);
		}
	}
}

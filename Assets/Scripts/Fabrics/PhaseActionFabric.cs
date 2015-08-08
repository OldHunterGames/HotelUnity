using UnityEngine;
using System.Collections;

public abstract class PhaseActionFabric : MonoBehaviour {

	public abstract PhaseAction CreatePhaseAction(GameObject target);

	public string caption {
		get {
			return GetType().ToString();
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sublocation : MonoBehaviour {

	public ShortActionFabric[] ShortActionFabrics {
		get {
			return gameObject.GetComponentsInChildren<ShortActionFabric>();
		}
	}

	public PhaseActionFabric[] PhaseActionFabrics {
		get {
			return gameObject.GetComponentsInChildren<PhaseActionFabric>();
		}
	}
}

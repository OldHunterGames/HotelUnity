using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sublocation : MonoBehaviour {

	public string locationName;

	public string locationDescription;

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

	public T getActionFabric<T>() {
		return gameObject.GetComponentInChildren<T>();
	}

	public T[] getActionFabrics<T>() {
		return gameObject.GetComponentsInChildren<T>();
	}
}

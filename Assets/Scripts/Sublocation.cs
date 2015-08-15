using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sublocation : MonoBehaviour {

	public string locationName;

	public string locationDescription;

	public T getActionFabric<T>() {
		return gameObject.GetComponentInChildren<T>();
	}

	public T[] getActionFabrics<T>() {
		return gameObject.GetComponentsInChildren<T>();
	}
}

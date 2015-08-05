using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public Sublocation Sublocation {
		get {
			return gameObject.transform.parent.transform.parent.GetComponent<Sublocation>();
		}
	}
}

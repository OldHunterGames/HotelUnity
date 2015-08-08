using UnityEngine;
using System.Collections;

public abstract class ShortActionFabric : MonoBehaviour {

	public abstract ShortAction CreateShortAction(GameObject target);

	public virtual string caption {
		get {
			return GetType().ToString();
		}
	}
}

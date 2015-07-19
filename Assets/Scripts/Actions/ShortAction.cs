using UnityEngine;
using System.Collections;

public abstract class ShortAction {

	public GameObject actionSource;
	public GameObject actionTarget;

	public abstract void ExecuteShortAction();
}

using UnityEngine;
using System.Collections;

public abstract class Action {
	public GameObject actionSource;
	public GameObject actionTarget;
	
	public abstract void ExecuteAction();
}

using UnityEngine;
using System.Collections;

public abstract class PhaseAction {
	
	public GameObject actionSource;
	public GameObject actionTarget;
	
	public abstract void ExecutePhaseAction();
}

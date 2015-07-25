using UnityEngine;
using System.Collections;

public abstract class PhaseActionsProducer : ScriptableObject {
	
	public GameObject gameObject;
	
	public abstract PhaseAction ProducePhaseAction();
	
	public abstract void OnPhaseStart();
}

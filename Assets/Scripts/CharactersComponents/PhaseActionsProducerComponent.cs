using UnityEngine;
using System.Collections;
using UnityEditor;

public class PhaseActionsProducerComponent : MonoBehaviour, IPhaseEventsListener {
	
	public MonoScript monoScriptActionsProducer;
	
	public PhaseActionsProducer actionsProducer;
	
	void Start () {
		if (monoScriptActionsProducer != null) {
			actionsProducer = ScriptableObject.CreateInstance (monoScriptActionsProducer.GetClass ()) as PhaseActionsProducer;
			actionsProducer.gameObject = gameObject;
		}
	}

	public void OnPhaseFinish() {
		actionsProducer.OnPhaseFinish ();
	}
}

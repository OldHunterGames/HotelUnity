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
		Debug.Assert (actionsProducer != null, string.Format ("Cannot find producer for {0}", gameObject.name));
		if (actionsProducer != null) {
			actionsProducer.OnPhaseFinish ();
		}
	}
}

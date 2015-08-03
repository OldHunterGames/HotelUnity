using UnityEngine;
using System.Collections;
using UnityEditor;

public class ShortActionsProducerComponent : MonoBehaviour, IPhaseEventsListener {
	
	public MonoScript monoScriptActionsProducer;
	
	public ShortActionsProducer actionsProducer;
	
	void Start () {
		if (monoScriptActionsProducer != null) {
			actionsProducer = ScriptableObject.CreateInstance (monoScriptActionsProducer.GetClass ()) as ShortActionsProducer;
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

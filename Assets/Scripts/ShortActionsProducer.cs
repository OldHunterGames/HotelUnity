using UnityEngine;
using System.Collections;

public abstract class ShortActionsProducer : ScriptableObject {

	public GameObject gameObject;

	public abstract ShortAction ProduceShortAction();

	public abstract void OnPhaseStart();
}

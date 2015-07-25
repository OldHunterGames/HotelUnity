using UnityEngine;
using System.Collections;

abstract public class CharacterProcessor: MonoBehaviour {

	public abstract ShortAction ProduceShortAction ();
	public abstract PhaseAction ProducePhaseAction ();
	public abstract void OnPhaseStart ();
}
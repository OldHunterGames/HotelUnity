using UnityEngine;
using System.Collections;

public class ActionManager : MonoBehaviour {

 	public CharacterProcessor processor;

	public ShortAction getNextShortAction() {
		return processor.ProduceShortAction ();
	}

	public PhaseAction getNextPhaseAction() {
		return processor.ProducePhaseAction ();
	}

	public void onPhaseStart() {
		processor.OnPhaseStart ();
	}
}

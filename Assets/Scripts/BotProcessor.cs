using UnityEngine;
using System.Collections;

public class BotProcessor : CharacterProcessor {

	public override ShortAction ProduceShortAction() {
		ShortAction action = new MoveToTheSublocationShortAction("Lobby", "Kitchen");
		action.actionSource = gameObject;
		action.actionTarget = gameObject;
		return action;
	}

	public override PhaseAction ProducePhaseAction() {
		PhaseAction action = new SleepPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = gameObject;
		return action;	
	}
		
	public override void OnPhaseStart ()
	{
		Debug.Log ("Bot.OnPhaseStart()");
	}
}

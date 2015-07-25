using UnityEngine;
using System.Collections;

public class BotProcessor : CharacterProcessor {

	private static readonly int MAX_STEPS = 3;
	private int stepsRemaining = MAX_STEPS;

	public override ShortAction ProduceShortAction() {

		if (stepsRemaining > 0) {
			stepsRemaining -= 1;
			Debug.Log ("Bot.ProduceShortAction()");
			var currentLocation = gameObject.GetComponent<Location> ();
			Debug.Log (currentLocation.locationName);
			Debug.Log (currentLocation.sublocationName);


			var newLocationList = GameObject.FindGameObjectsWithTag ("Sublocation");

			ShortAction action = new MoveToTheSublocationShortAction (currentLocation.sublocationName, newLocationList [Random.Range (0, newLocationList.Length - 1)].name);
			action.actionSource = gameObject;
			action.actionTarget = gameObject;
			return action;
		} else {
			return null;
		}
	}

	public override PhaseAction ProducePhaseAction() {
		Debug.Log ("Bot.ProducePhaseAction()");
		PhaseAction action = new SleepPhaseAction ();
		action.actionSource = gameObject;
		action.actionTarget = gameObject;
		return action;	
	}
		
	public override void OnPhaseStart ()
	{
		stepsRemaining = MAX_STEPS;
		Debug.Log ("Bot.OnPhaseStart()");
	}
}

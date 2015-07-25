using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimeMachine {

	public static readonly TimeMachine Instance = new TimeMachine();

	public int ExecuteShortActions() {
		Debug.Log ("ExecuteShortActions");
		int shortActionsCount = 0;

		foreach (var shortAction in GetShortActionsEnumerable()) {
			shortAction.ExecuteShortAction();
			++shortActionsCount;
		}

		return shortActionsCount;
	}

	public void ExecutePhaseActions() {
		Debug.Log ("ExecutePhaseActions");
		while (ExecuteShortActions() > 0) {}

		foreach (var phaseAction in GetPhaseActionsEnumerable()) {
			phaseAction.ExecutePhaseAction();
		}

		foreach (var producer in GetActionsProducersEnumerable()) {
			producer.OnPhaseStart();
		}
	}
	
	private IEnumerable<GameObject> GetCharactersEnumerable() {

		Debug.Log (string.Format ("CharactersList: {0}", GameObject.FindGameObjectsWithTag ("Character").Length));
		return GameObject.FindGameObjectsWithTag ("Character");
	}

	private IEnumerable<ShortAction> GetShortActionsEnumerable() {
		foreach (var producer in GetActionsProducersEnumerable()) {
			var action = producer.ProduceShortAction();
			
			if (action != null) {
				yield return action;
			}
		}
	}

	private IEnumerable<PhaseAction> GetPhaseActionsEnumerable() {
		foreach (var producer in GetActionsProducersEnumerable()) {
			var action = producer.ProducePhaseAction();
			
			if (action != null) {
				yield return action;
			}
		}
	}

	private IEnumerable<CharacterProcessor> GetActionsProducersEnumerable() {
		foreach (var character in GetCharactersEnumerable()) {
			var actionManager = character.GetComponent<ActionManager> ();

			if (actionManager) {
				var processor = actionManager.processor;

				if (processor) {
					yield return processor;
				}
			}
		}
	}
}

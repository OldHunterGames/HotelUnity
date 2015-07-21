using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimeMachine {

	public static readonly TimeMachine Instance = new TimeMachine();

	private List<PhaseActionsProducer> phaseActionsProducers = new List<PhaseActionsProducer> ();
	private List<ShortActionsProducer> shortActionsProducers = new List<ShortActionsProducer> ();
	private List<PhaseAction> phaseActions = new List<PhaseAction>();
	private List<ShortAction> shortActions = new List<ShortAction>();

	public int ExecuteShortActions() {
		reloadCharactersData ();

		foreach (var shortAction in shortActions) {
			shortAction.ExecuteShortAction();
		}

		return shortActions.Count;
	}

	public void ExecutePhaseActions() {
		reloadCharactersData ();

		while (ExecuteShortActions() > 0) {}

		foreach (var producer in phaseActionsProducers) {
			producer.OnPhaseStart();
		}

		foreach (var producer in shortActionsProducers) {
			producer.OnPhaseStart();
		}
	}

	private void reloadCharactersData() {
		phaseActionsProducers.Clear ();
		shortActionsProducers.Clear ();
		phaseActions.Clear ();
		shortActions.Clear ();

		var characters = GameObject.Find ("Characters");
    	Debug.Assert (characters != null, "Scene should contains 'Characters' node.");

		for (int childIndex = 0; childIndex < characters.transform.childCount; childIndex++) {
			var character = characters.transform.GetChild (childIndex);
			processShortActionsProducers(character);
			processPhaseActionsProducers(character);
		}
	}

	private void processShortActionsProducers(Transform character) {
		var shortActionsProducerComponent = character.GetComponent<ShortActionsProducerComponent> ();
		if (shortActionsProducerComponent) {
			var producer = shortActionsProducerComponent.actionsProducer;
			if (producer) {
				shortActionsProducers.Add (producer);
				var action = producer.ProduceShortAction();
				if (action != null) {
					shortActions.Add(action);
				}
			}
		}
	}

	private void processPhaseActionsProducers(Transform character) {
		var phaseActionsProducerComponent = character.GetComponent<PhaseActionsProducerComponent> ();
		if (phaseActionsProducerComponent) {
			var producer = phaseActionsProducerComponent.actionsProducer;
			if (producer) {
				phaseActionsProducers.Add (producer);
				var action = producer.ProducePhaseAction();
				if (action != null) {
					phaseActions.Add(action);
				}
			}
		}
	}
}

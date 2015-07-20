using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimeMachine {

	public static readonly TimeMachine Instance = new TimeMachine();

	public int ExecuteShortActions() {
		var characters = GameObject.Find ("Characters");

		Debug.Assert (characters != null, "Scene should contains 'Characters' node.");

		var shortActions = new List<ShortAction>();

		for (int childIndex = 0; childIndex < characters.transform.childCount; childIndex++) {
			var character = characters.transform.GetChild(childIndex);

			var producerComponent = character.GetComponent<ShortActionsProducerComponent>();

			if (producerComponent) {
				var producer = producerComponent.actionsProducer;

				if (producer) {
					var action = producer.ProduceShortAction();

					if (action != null) {
						shortActions.Add(action);
					}
				}
			}
		}

		foreach (var shortAction in shortActions) {
			shortAction.ExecuteShortAction();
		}

		return shortActions.Count;
	}

	public void ExecutePhaseActions() {
		while (ExecuteShortActions() > 0) {}

		var characters = GameObject.Find ("Characters");
		
		Debug.Assert (characters != null, "Scene should contains 'Characters' node.");
		
		var phaseActions = new List<PhaseAction>();

		for (int childIndex = 0; childIndex < characters.transform.childCount; childIndex++) {
			var character = characters.transform.GetChild(childIndex);
			
			var producerComponent = character.GetComponent<PhaseActionsProducerComponent>();
			
			if (producerComponent) {
				var producer = producerComponent.actionsProducer;
				
				if (producer) {
					var action = producer.ProducePhaseAction();
					
					if (action != null) {
						phaseActions.Add(action);
					}
				}
			}
		}
		
		foreach (var phaseAction in phaseActions) {
			phaseAction.ExecutePhaseAction();
		}

		var phaseActionsProducers = new List<PhaseActionsProducer> ();
		var shortActionsProducers = new List<ShortActionsProducer> ();

		for (int childIndex = 0; childIndex < characters.transform.childCount; childIndex++) {
			var character = characters.transform.GetChild(childIndex);
			
			var phaseActionsProducerComponent = character.GetComponent<PhaseActionsProducerComponent>();
			
			if (phaseActionsProducerComponent) {
				var producer = phaseActionsProducerComponent.actionsProducer;
				
				if (producer) {
					phaseActionsProducers.Add(producer);
				}
			}

			var shortActionsProducerComponent = character.GetComponent<ShortActionsProducerComponent>();
			
			if (shortActionsProducerComponent) {
				var producer = shortActionsProducerComponent.actionsProducer;
				
				if (producer) {
					shortActionsProducers.Add(producer);
				}
			}
		}

		foreach (var producer in phaseActionsProducers) {
			producer.OnPhaseStart();
		}

		foreach (var producer in shortActionsProducers) {
			producer.OnPhaseStart();
		}
	}
}

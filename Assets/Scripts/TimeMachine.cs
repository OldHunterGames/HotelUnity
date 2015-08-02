using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimeMachine {

	public static readonly TimeMachine Instance = new TimeMachine();
	
	private GameObject[] _characters;

	public TimeMachine() {
		_characters = GameObject.FindGameObjectsWithTag ("Character");

		Debug.Assert (_characters != null, "Scene should contains 'Characters' node.");
	}

	public int ExecuteShortActions() {
		int shortActionsCount = 0;

		foreach (var shortAction in GetShortActionsEnumerable()) {
			shortActionsCount++;

			shortAction.ExecuteShortAction();
		}

		return shortActionsCount;
	}

	public void ExecutePhaseActions() {
		while (ExecuteShortActions() > 0) {}

		foreach (var phaseAction in GetPhaseActionsEnumerable()) {
			phaseAction.ExecutePhaseAction();
		}

		foreach (var listener in GetPhaseEventListenersEnumerable()) {
			listener.OnPhaseFinish();
		}
	}
	
//	private IEnumerable<GameObject> GetCharactersEnumerable() {
//		for (int childIndex = 0; childIndex < _characters.transform.childCount; childIndex++) {
//			yield return _characters.transform.GetChild(childIndex).gameObject;
//		}
//	}

	private IEnumerable<ShortActionsProducer> GetShortActionsProducersEnumerable() {
		foreach (var character in _characters) {
			var component = character.GetComponent<ShortActionsProducerComponent> ();

			if (component) {
				var producer = component.actionsProducer;

				if (producer) {
					yield return producer;
				}
			}
		}
	}

	private IEnumerable<ShortAction> GetShortActionsEnumerable() {
		foreach (var producer in GetShortActionsProducersEnumerable()) {
			var action = producer.ProduceShortAction();

			if (action != null) {
				yield return action;
			}
		}
	}
		
	private IEnumerable<PhaseActionsProducer> GetPhaseActionsProducersEnumerable() {
		foreach (var character in _characters) {
			var component = character.GetComponent<PhaseActionsProducerComponent> ();
			
			if (component) {
				var producer = component.actionsProducer;
				
				if (producer) {
					yield return producer;
				}
			}
		}
	}
	
	private IEnumerable<PhaseAction> GetPhaseActionsEnumerable() {
		foreach (var producer in GetPhaseActionsProducersEnumerable()) {
			var action = producer.ProducePhaseAction();
			
			if (action != null) {
				yield return action;
			}
		}
	}

	private IEnumerable<IPhaseEventsListener> GetPhaseEventListenersEnumerable() {
		foreach (var character in _characters) {
			foreach (var component in character.GetComponents<IPhaseEventsListener>()) {
				yield return component as IPhaseEventsListener;
			}
		}
	}
}

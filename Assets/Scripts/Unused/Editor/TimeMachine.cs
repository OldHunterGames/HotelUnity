//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//
//public class TimeMachine {
//
//	public static readonly TimeMachine Instance = new TimeMachine();
//
//	public int ExecuteShortActions() {
//		int shortActionsCount = 0;
//
//		foreach (var shortAction in GetShortActionsEnumerable()) {
//			shortActionsCount++;
//
//			shortAction.ExecuteShortAction();
//		}
//
//		return shortActionsCount;
//	}
//
//	public void ExecutePhaseActions() {
//		while (ExecuteShortActions() > 0) {}
//
//		foreach (var phaseAction in GetPhaseActionsEnumerable()) {
//			phaseAction.ExecutePhaseAction();
//		}
//
//		foreach (var producer in GetPhaseActionsProducersEnumerable()) {
//			producer.OnPhaseStart();
//		}
//
//		foreach (var producer in GetShortActionsProducersEnumerable()) {
//			producer.OnPhaseStart();
//		}
//	}
//	
//	private IEnumerable<GameObject> GetCharactersEnumerable() {
//
//		Debug.Log (string.Format ("CharactersList: {0}", GameObject.FindGameObjectsWithTag ("Character").Length));
//		return GameObject.FindGameObjectsWithTag ("Character");
//	}
//
//	private IEnumerable<ShortActionsProducer> GetShortActionsProducersEnumerable() {
//		foreach (var character in GetCharactersEnumerable()) {
//			var component = character.GetComponent<ShortActionsProducerComponent> ();
//
//			if (component) {
//				var producer = component.actionsProducer;
//
//				if (producer) {
//					yield return producer;
//				}
//			}
//		}
//	}
//
//	private IEnumerable<ShortAction> GetShortActionsEnumerable() {
//		foreach (var producer in GetShortActionsProducersEnumerable()) {
//			var action = producer.ProduceShortAction();
//
//			if (action != null) {
//				yield return action;
//			}
//		}
//	}
//		
//	private IEnumerable<PhaseActionsProducer> GetPhaseActionsProducersEnumerable() {
//		foreach (var character in GetCharactersEnumerable()) {
//			var component = character.GetComponent<PhaseActionsProducerComponent> ();
//			
//			if (component) {
//				var producer = component.actionsProducer;
//				
//				if (producer) {
//					yield return producer;
//				}
//			}
//		}
//	}
//	
//	private IEnumerable<PhaseAction> GetPhaseActionsEnumerable() {
//		foreach (var producer in GetPhaseActionsProducersEnumerable()) {
//			var action = producer.ProducePhaseAction();
//			
//			if (action != null) {
//				yield return action;
//			}
//		}
//	}
//}

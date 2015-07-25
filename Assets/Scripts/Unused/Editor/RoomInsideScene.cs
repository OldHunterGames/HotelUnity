//using UnityEngine;
//using System.Collections;
//
//public class RoomInsideScene : MonoBehaviour {
//
//	public void PlayerSleep() {
//		var player = GameObject.Find ("Characters/Player");
//		var producerComponent = player.GetComponent<PhaseActionsProducerComponent> ();
//		var producer = producerComponent.actionsProducer as PlayerPhaseActionsProducer;
//		
//		var action = new SleepPhaseAction ();
//		action.actionSource = player;
//		action.actionTarget = player;
//		
//		producer.SetPhaseAction (action);
//		
//		TimeMachine.Instance.ExecutePhaseActions ();
//	}
//}

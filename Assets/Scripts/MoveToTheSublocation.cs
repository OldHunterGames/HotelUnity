using UnityEngine;
using System.Collections;

public class MoveToTheSublocation : MonoBehaviour {
	
	public void Move(string sublocationName) {
		var player = GameObject.Find ("Characters/Player");
		//var producerComponent = player.GetComponent<ShortActionsProducerComponent> ();
		//var producer = producerComponent.actionsProducer as PlayerShortActionsProducer;

		var action = new MoveToTheSublocationShortAction (sublocationName);
		action.actionSource = player;
		action.actionTarget = player;

		//producer.SetShortAction (action);

//		TimeMachine.Instance.ExecuteShortActions ();
	}
}

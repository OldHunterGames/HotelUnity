using UnityEngine;
using System.Collections;

public class LifeTimeObjectDetails : MonoBehaviour, IPhaseEventsListener {
	public int turnsToDestroing;	

	public void OnPhaseFinish() {
		--turnsToDestroing;
		if (turnsToDestroing <= 0) {
			Destroy(gameObject);
		} 
	}
}

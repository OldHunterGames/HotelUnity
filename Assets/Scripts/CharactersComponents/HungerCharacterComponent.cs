using UnityEngine;
using System.Collections;

public class HungerCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	public int hunger = 0;

	public void OnPhaseFinish() {
		if (hunger < 5) {
			hunger += 1;
		}
	}
}

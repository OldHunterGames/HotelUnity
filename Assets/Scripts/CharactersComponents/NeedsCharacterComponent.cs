using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class NeedsCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	public int Hunger = 0;
	public int Freshness = 15;
	public int NeedForSleep = 0;

	public void OnPhaseFinish(){
		if (Hunger < 5) {
			Hunger++;
		}
		if (Freshness > 0) {
			Freshness--;
		}
		GetNeedForSleep ();
	}

	private void GetNeedForSleep(){
		switch (Freshness) {
		case 15:
			NeedForSleep = 0;
			break;
		case 14:
		case 13:
		case 12:
			NeedForSleep = 1;
			break;
		case 11:
		case 10:
			NeedForSleep = 3;
			break;
		case 9:
		case 8:
			NeedForSleep = 4;
			break;
		case 7:
		case 6:
		case 5:
		case 4:
		case 3:
		case 2:
		case 1:
		case 0:
			NeedForSleep = 5;
			break;
		default:
			Debug.Log ("incorrect Freshness");
			break;
		}
	}
}
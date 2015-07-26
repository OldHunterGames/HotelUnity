using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class NeedsCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	public int Hunger;
	public int Freshness;
	public int NeedForSleep;

	public void OnPhaseFinish(){
		if (Hunger < 5) {
			Hunger++;
		}
		if (Freshness > 0) {
			Freshness--;
		}
		GetNeedForSleep (Freshness);
	}

	public NeedsCharacterComponent(int hung, int fresh){
		Hunger = hung;
		Freshness = fresh;
		GetNeedForSleep (Freshness);
	}

	public NeedsCharacterComponent(){
		Hunger = 0;
		Freshness = 15;
		NeedForSleep = 0;
	}

	private void GetNeedForSleep(int fresh){
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
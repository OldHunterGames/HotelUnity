using UnityEngine;
using System.Collections;
using Utils;

public class HungerCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minHunger = 0;
	private const int maxHunger = 100;

	[SerializeField]
	private int _hunger = minHunger;

	public int hunger {
		get {
			return _hunger;
		}
		set {
			_hunger = RangeValidator.validate(value, minHunger, maxHunger);
		}
	}
	
	public void OnPhaseFinish() {
		++hunger;
	}
}

using UnityEngine;
using System.Collections;
using Utils;

public class EntertainmentCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minEntertainment = -1;
	private const int maxEntertainment = 100;
	
	[SerializeField]
	private int _entertainment = minEntertainment;
	
	public int entertainment {
		get {
			return _entertainment;
		}
		set {
			_entertainment = RangeValidator.validate(value, minEntertainment, maxEntertainment);
		}
	}
	
	public void OnPhaseFinish() {
		++entertainment;
	}
}

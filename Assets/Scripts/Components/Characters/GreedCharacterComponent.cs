using UnityEngine;
using System.Collections;
using Utils;

public class GreedCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minGreed = 0;
	private const int maxGreed = 100;
	
	[SerializeField]
	private int _greed = minGreed;
	
	public int greed {
		get {
			return _greed;
		}
		set {
			_greed = RangeValidator.validate(value, minGreed, maxGreed);
		}
	}
	
	public void OnPhaseFinish() {
		++greed;
	}
}

using UnityEngine;
using System.Collections;
using Utils;

public class CreativityCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minCreativity = 0;
	private const int maxCreativity = 15;

	[SerializeField]
	private int _creativity = minCreativity;
	
	public int creativity {
		get {
			return _creativity;
		}
		set {
			_creativity = RangeValidator.validate(value, minCreativity, maxCreativity);
		}
	}
	
	public void OnPhaseFinish() {
		--creativity;
	}
}

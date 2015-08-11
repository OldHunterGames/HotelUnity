using UnityEngine;
using System.Collections;
using Utils;

public class CuriosityCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minCuriosity = 0;
	private const int maxCuriosity = 100;
	
	[SerializeField]
	private int _curiosity = minCuriosity;
	
	public int curiosity {
		get {
			return _curiosity;
		}
		set {
			_curiosity = RangeValidator.validate(value, minCuriosity, maxCuriosity);
		}
	}
	
	public void OnPhaseFinish() {
		++curiosity;
	}
}

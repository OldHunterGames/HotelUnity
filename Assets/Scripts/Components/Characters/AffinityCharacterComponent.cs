using UnityEngine;
using System.Collections;
using Utils;

public class AffinityCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minAffinity = 0;
	private const int maxAffinity = 15;
	
	[SerializeField]
	private int _affinity = minAffinity;
	
	public int affinity {
		get {
			return _affinity;
		}
		set {
			_affinity = RangeValidator.validate(value, minAffinity, maxAffinity);
		}
	}
	
	public void OnPhaseFinish() {
		--affinity;
	}
}

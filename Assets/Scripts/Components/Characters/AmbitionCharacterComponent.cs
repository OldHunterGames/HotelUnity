using UnityEngine;
using System.Collections;
using Utils;

public class AmbitionCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minAmbition = 0;
	private const int maxAmbition = 15;
	
	[SerializeField]
	private int _ambition = minAmbition;
	
	public int ambition {
		get {
			return _ambition;
		}
		set {
			_ambition = RangeValidator.validate(value, minAmbition, maxAmbition);
		}
	}
	
	public void OnPhaseFinish() {
		--ambition;
	}
}

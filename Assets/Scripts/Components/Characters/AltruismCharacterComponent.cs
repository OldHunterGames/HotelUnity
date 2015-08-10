using UnityEngine;
using System.Collections;
using Utils;

public class AltruismCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minAltruism = 0;
	private const int maxAltruism = 15;
	
	[SerializeField]
	private int _altruism = minAltruism;
	
	public int altruism {
		get {
			return _altruism;
		}
		set {
			_altruism = RangeValidator.validate(value, minAltruism, maxAltruism);
		}
	}
	
	public void OnPhaseFinish() {
		--altruism;
	}
}

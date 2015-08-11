using UnityEngine;
using System.Collections;
using Utils;

public class HedonismCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minHedonism = 0;
	private const int maxHedonism = 100;
	
	[SerializeField]
	private int _hedonism = minHedonism;
	
	public int hedonism {
		get {
			return _hedonism;
		}
		set {
			_hedonism = RangeValidator.validate(value, minHedonism, maxHedonism);
		}
	}
	
	public void OnPhaseFinish() {
		++hedonism;
	}
}

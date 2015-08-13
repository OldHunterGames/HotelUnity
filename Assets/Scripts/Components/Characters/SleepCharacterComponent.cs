using UnityEngine;
using System.Collections;
using Utils;

public class SleepCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minFreshness = 0;
	private const int maxFreshness = 15;

	[SerializeField]
	private int _freshness = maxFreshness;

	public int freshness {
		get {
			return _freshness;
		}
		set {
			_freshness = RangeValidator.validate(value, minFreshness, maxFreshness);
		}
	}

	public void OnPhaseFinish() {
		if(--freshness < minFreshness)
		{
			freshness = minFreshness;
			Debug.Log(string.Format("{0} wants to satisfy his {1} need", gameObject.name, GetType().Name.Remove(GetType().Name.IndexOf("Character"))));
		}
	}
}

using UnityEngine;
using System.Collections;
using Utils;

public class NeedCharacterComponent : MonoBehaviour, IPhaseEventsListener {

	private const int minValue = 0;
	private const int maxValue = 100;
	private int phase = 0;

	public int preffer = minValue;

	[SerializeField]
	private int _value = minValue;

	public int value {
		get {
			return _value;
		}
		set {
			_value = RangeValidator.validate(value, minValue, maxValue);
		}
	}

	public void OnPhaseFinish() {
		if (++phase > 4) {
			phase -= 4;
			if(++value > preffer)
			{
				value = preffer;
				Debug.Log(string.Format("{0} wants to satisfy his {1} need", gameObject.name, GetType().Name.Remove(GetType().Name.IndexOf("Character"))));
			}
		}
	}
}

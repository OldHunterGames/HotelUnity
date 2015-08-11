using UnityEngine;
using System.Collections;
using Utils;

public class OrderCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minOrder = 0;
	private const int maxOrder = 100;
	
	[SerializeField]
	private int _order = minOrder;
	
	public int order {
		get {
			return _order;
		}
		set {
			_order = RangeValidator.validate(value, minOrder, maxOrder);
		}
	}
	
	public void OnPhaseFinish() {
		++order;
	}
}

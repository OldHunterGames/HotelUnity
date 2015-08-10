using UnityEngine;
using System.Collections;
using Utils;

public class CommunicationCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minCommunication = 0;
	private const int maxCommunication = 15;
	
	[SerializeField]
	private int _communication = minCommunication;
	
	public int communication {
		get {
			return _communication;
		}
		set {
			_communication = RangeValidator.validate(value, minCommunication, maxCommunication);
		}
	}
	
	public void OnPhaseFinish() {
		--communication;
	}
}

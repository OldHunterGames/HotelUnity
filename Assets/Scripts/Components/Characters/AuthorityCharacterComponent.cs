using UnityEngine;
using System.Collections;
using Utils;

public class AuthorityCharacterComponent : MonoBehaviour, IPhaseEventsListener {
	
	private const int minAuthority = 0;
	private const int maxAuthority = 100;
	
	[SerializeField]
	private int _authority = minAuthority;
	
	public int authority {
		get {
			return _authority;
		}
		set {
			_authority = RangeValidator.validate(value, minAuthority, maxAuthority);
		}
	}
	
	public void OnPhaseFinish() {
		++authority;
	}
}

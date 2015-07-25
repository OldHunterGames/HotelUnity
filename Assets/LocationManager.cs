using UnityEngine;
using System.Collections;

public class LocationManager : MonoBehaviour {

	public GameObject locationProvider;
	public enum DoorStatus { Open=0, Locked=1};

	public DoorStatus status;
	public void getAllowedActions() {

	}
}

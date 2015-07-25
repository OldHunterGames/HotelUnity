using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Logger : MonoBehaviour {

	public Text logMessage;
	public Transform contentPanel;
	private List<string> Eventlog = new List<string>();

	public void AddEvent(string eventString)
	{
		Text log = Instantiate (logMessage) as Text;
		log.text = string.Format ("{0}: {1}. {2}",System.DateTime.Now.ToString("HH:mm:ss"), "currentLocation", eventString);
		log.transform.SetParent (contentPanel);
	}
}

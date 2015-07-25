using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Logger : MonoBehaviour {

	public Text logMessage;
	public Transform contentPanel;

	public void AddEvent(string eventString)
	{
		Text log = Instantiate (logMessage) as Text;
		log.text = string.Format ("{0}: {1}",System.DateTime.Now.ToString("HH:mm:ss"), eventString);
		log.transform.SetParent (contentPanel);
	}
}

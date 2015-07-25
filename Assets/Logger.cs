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

	public void ClearAll()
	{
		int childs = contentPanel.childCount;
		for (int i = childs - 1; i > 0; i--)
		{
			GameObject.Destroy(transform.GetChild(i).gameObject);
		}
	}
}

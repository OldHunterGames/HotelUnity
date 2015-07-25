using UnityEngine;
using System.Collections;

public class MoveToTheSublocationShortAction : ShortAction {

	private string _oldSublocationName;
	private string _newSublocationName;

	public MoveToTheSublocationShortAction(string oldSublocationName, string newSublocationName) {
		_oldSublocationName = oldSublocationName;
		_newSublocationName = newSublocationName;
	}

	override public void ExecuteShortAction() {		
		var loggerObject = GameObject.Find ("Logger");
		var logger = loggerObject.GetComponent<Logger> ();
		var oldLocationObject = GameObject.Find(string.Format ("GameData/Locations/{0}", _oldSublocationName));
		Debug.Assert (oldLocationObject != null, string.Format ("oldLocationObject {0} is not found!", oldLocationObject));
		var oldLocationCharacters = oldLocationObject.GetComponent<Characters>();
		Debug.Assert (oldLocationCharacters != null, string.Format ("oldLocationCharacters {0} is not found!", oldLocationCharacters));

		var newLocationObject = GameObject.Find(string.Format ("GameData/Locations/{0}", _newSublocationName));
		Debug.Assert (newLocationObject != null, string.Format ("newLocationObject {0} is not found!", newLocationObject));
		var newLocationCharacters = newLocationObject.GetComponent<Characters>();
		Debug.Assert (newLocationCharacters != null, string.Format ("newLocationCharacters {0} is not found!", newLocationCharacters));

		var currentLocation = actionSource.GetComponent<Location>();
		if (oldLocationCharacters.character.Contains (actionSource)) {
			oldLocationCharacters.character.Remove (actionSource);
			newLocationCharacters.character.Add (actionSource);
			currentLocation.sublocationName = _newSublocationName;

			logger.AddEvent (string.Format ("Short action. Character '{0}' moved from {1} to {2}.", actionSource.name, _oldSublocationName, _newSublocationName));
			Debug.Log (string.Format ("Short action. Character '{0}' moved from {1} to {2}.", actionSource.name, _oldSublocationName, _newSublocationName));
		}
	}
}

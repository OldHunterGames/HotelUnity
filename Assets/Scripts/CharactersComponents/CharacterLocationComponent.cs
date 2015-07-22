using UnityEngine;
using System.Collections;

public class CharacterLocationComponent : MonoBehaviour {

	public readonly string location = "Hotel";

	[SerializeField]
	private string _sublocation;

	public string sublocation {
		get {
			return _sublocation;
		}

		set {
			var oldSublocation = _sublocation;

			_sublocation = value;

			if (gameObject.name.Equals("Player") && _sublocation != null && !_sublocation.Equals(oldSublocation)) {
				GameObject.DontDestroyOnLoad(GameObject.Find("Characters"));
				Application.LoadLevel (SublocationUtils.SceneName(sublocation));
			}
		}
	}
}

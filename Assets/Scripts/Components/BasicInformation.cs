using UnityEngine;
using System.Collections;

public abstract class BasicInformation : MonoBehaviour {

	[SerializeField]
	protected string _title;

	[SerializeField]
	protected string _description;

	public virtual string title{
		set {
			_title = value;
		}
		get {
			return _title.Length == 0 ? GetType().ToString() : _title;
		}
	}
	public virtual string description {
		set {
			_description = value;
		}
		get {
			return _description.Length == 0 ? GetType().ToString() : _description;
		}
	}
}

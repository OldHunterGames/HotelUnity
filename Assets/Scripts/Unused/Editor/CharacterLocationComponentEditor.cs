using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(CharacterLocationComponent))]
public class CharacterLocationComponentEditor : Editor {
	
	public override void OnInspectorGUI () {
		var component = target as CharacterLocationComponent;

		component.sublocation = EditorGUILayout.TextField ("Sublocation", component.sublocation);

		if (GUI.changed) {
			EditorUtility.SetDirty (component);
		}
	}
}
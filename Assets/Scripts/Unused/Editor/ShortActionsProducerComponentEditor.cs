using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ShortActionsProducerComponent))]
public class ShortActionsProducerComponentEditor : Editor {

	public override void OnInspectorGUI () {
		var component = target as ShortActionsProducerComponent;

		component.monoScriptActionsProducer = EditorGUILayout.ObjectField ("Short actions producer", component.monoScriptActionsProducer, typeof(MonoScript), false) as MonoScript;
		if (component.monoScriptActionsProducer != null) {
			var monoScriptClass = component.monoScriptActionsProducer.GetClass ();

			if (!monoScriptClass.IsSubclassOf (typeof(ShortActionsProducer))) {
				component.monoScriptActionsProducer = null;
			}
		}

		if (GUI.changed) {
			EditorUtility.SetDirty (component);
		}
	}
}
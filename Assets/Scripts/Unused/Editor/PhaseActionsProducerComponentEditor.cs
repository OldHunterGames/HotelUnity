using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PhaseActionsProducerComponent))]
public class PhaseActionsProducerComponentEditor : Editor {
	
	public override void OnInspectorGUI () {
		var component = target as PhaseActionsProducerComponent;
		
		component.monoScriptActionsProducer = EditorGUILayout.ObjectField ("Phase actions producer", component.monoScriptActionsProducer, typeof(MonoScript), false) as MonoScript;
		if (component.monoScriptActionsProducer != null) {
			var monoScriptClass = component.monoScriptActionsProducer.GetClass ();
			
			if (!monoScriptClass.IsSubclassOf (typeof(PhaseActionsProducer))) {
				component.monoScriptActionsProducer = null;
			}
		}
		
		if (GUI.changed) {
			EditorUtility.SetDirty (component);
		}
	}
}
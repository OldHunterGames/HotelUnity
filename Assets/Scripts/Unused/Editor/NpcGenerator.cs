//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//using UnityEditor;
//
//public class NpcGenerator : MonoBehaviour {
//
//	private int npcCount;
//
//	public void updateCount() {
//		InputField valueComponent = gameObject.GetComponentInChildren<InputField> ();
//		int.TryParse(valueComponent.text, out npcCount);
//	}
//		
//	public void CreateNPC() {
//		var characters = GameObject.Find ("Characters");
//
//		for (int i = 0; i < npcCount; i++) {
//			var npc = new GameObject (string.Format("Genarated_NPC_{0}", i));
//			var shortActionsProducerComponent = npc.AddComponent<ShortActionsProducerComponent> ();
//			var walkerShortActionProducerScriptableObject = ScriptableObject.CreateInstance (typeof(WalkerShortActionsProducer));
//			shortActionsProducerComponent.monoScriptActionsProducer = MonoScript.FromScriptableObject (walkerShortActionProducerScriptableObject);
//
//
//			var characterLocationComponent = npc.AddComponent<CharacterLocationComponent> ();
//			characterLocationComponent.sublocation = "Lobby";
//
//			var phaseActionsProducerComponent = npc.AddComponent<PhaseActionsProducerComponent> ();
//			var walkerPhaseActionProducerScriptableObject = ScriptableObject.CreateInstance (typeof(WalkerPhaseActionsProducer));
//			phaseActionsProducerComponent.monoScriptActionsProducer = MonoScript.FromScriptableObject (walkerPhaseActionProducerScriptableObject);
//
//			npc.transform.parent = characters.transform;
//		}
//	}
//}

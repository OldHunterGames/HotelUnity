using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;

public class NpcGenerator : MonoBehaviour {

	private int npcCount;
	public GameObject prefab;

	public void updateCount() {
		InputField valueComponent = gameObject.GetComponentInChildren<InputField> ();
		int.TryParse(valueComponent.text, out npcCount);
	}
		
	public void CreateNPC() {
		var characters = GameObject.Find ("Lobby/Characters");

		for (int i = 0; i < npcCount; i++) {

			GameObject npc = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
			npc.name = string.Format("Genarated_NPC_{0}", i);

			var shortActionsProducerComponent = npc.GetComponent<ShortActionsProducerComponent> ();
			var walkerShortActionProducerScriptableObject = ScriptableObject.CreateInstance (typeof(WalkerShortActionsProducer));
			shortActionsProducerComponent.monoScriptActionsProducer = MonoScript.FromScriptableObject (walkerShortActionProducerScriptableObject);

			var phaseActionsProducerComponent = npc.GetComponent<PhaseActionsProducerComponent> ();
			var walkerPhaseActionProducerScriptableObject = ScriptableObject.CreateInstance (typeof(WalkerPhaseActionsProducer));
			phaseActionsProducerComponent.monoScriptActionsProducer = MonoScript.FromScriptableObject (walkerPhaseActionProducerScriptableObject);

			npc.transform.parent = characters.transform;
		}

		TimeMachine.Instance.UpdateCharactersList ();
	}
}

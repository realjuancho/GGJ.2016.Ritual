using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public bool seenbyNPC;
	public bool allObjectivesDone;

	public NPC[] NPCsInScene;
	public ObjectiveChecker[] ObjectiveCheckers;

	void Start()
	{
		NPCsInScene = GameObject.FindObjectsOfType<NPC>();
		ObjectiveCheckers = GameObject.FindObjectsOfType<ObjectiveChecker>();
	}

	void Update()
	{
		if(!seenbyNPC)
		{
			bool tmpSeenByNPC = false;

			foreach(NPC npc in NPCsInScene)
			{
				if(npc.grandmaFound)
				{
					tmpSeenByNPC = true;
					break;
				}
			}
			seenbyNPC = tmpSeenByNPC;
		}

		if(!allObjectivesDone)
		{
			bool tmpAllObjectivesDone = true;

			foreach(ObjectiveChecker objective in ObjectiveCheckers)
			{
				if(!objective.ObjectiveCompleted)
				{
					tmpAllObjectivesDone = false;
					break;
				}
			}
			allObjectivesDone = tmpAllObjectivesDone;
		}

	}

}

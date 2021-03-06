﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public bool seenbyNPC;
	public bool allObjectivesDone;

	public NPC[] NPCsInScene;
	public ObjectiveChecker[] ObjectiveCheckers;



	TryAgainPanel tryAgainPanel;
	SuccessPanel successPanel;

	void Start()
	{
		NPCsInScene = GameObject.FindObjectsOfType<NPC>();
		ObjectiveCheckers = GameObject.FindObjectsOfType<ObjectiveChecker>();
		tryAgainPanel  = GameObject.FindObjectOfType<TryAgainPanel>();
		tryAgainPanel.gameObject.SetActive(false);

		successPanel = GameObject.FindObjectOfType<SuccessPanel>();
		successPanel.gameObject.SetActive(false);
	}

	void Update()
	{
		CheckSeenByNPC();


		if(seenbyNPC)
		{

			ShowTryAgainPanel();

		}



		CheckObjectives();

		if(allObjectivesDone)
			ShowSuccessPanel();

	}

	void CheckSeenByNPC(){

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

	}

	void CheckObjectives()
	{
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

	void ShowTryAgainPanel()
	{

		tryAgainPanel.gameObject.SetActive(true);
		Animator animatorController =  tryAgainPanel.GetComponent<Animator>();
		animatorController.SetTrigger(Hash.AnimationParameters.tryAgainPanelShow);


	}

	void ShowSuccessPanel()
	{
		successPanel.gameObject.SetActive(true);
		Animator animatorController =  successPanel.GetComponent<Animator>();
		animatorController.SetTrigger(Hash.AnimationParameters.successPanelShow);
	}
}

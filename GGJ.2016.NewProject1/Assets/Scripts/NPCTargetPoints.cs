using UnityEngine;
using System.Collections;

public class NPCTargetPoints : MonoBehaviour {

	public Hash.LocationNames location = Hash.LocationNames.Dormitorio;
	public NPCTarget currentTarget;
	public NPCTarget[] NPCTargetPointsFound;

	int currentPoint = 0;

	void Start()
	{
	 	NPCTargetPointsFound = GetComponentsInChildren<NPCTarget>();

	 	if(NPCTargetPointsFound.Length > 0)
	 	{
	 		currentTarget = NPCTargetPointsFound[0];
	 		currentPoint = 0;
	 	}
	}

	// Update is called once per frame

	public NPCTarget GetCurrentNPCTarget()
	{
		return currentTarget;
	}



	public void moveCurrentPoint()
	{
		if(currentPoint < NPCTargetPointsFound.Length -1)
		{
			currentPoint++;
		}
		else
		{
			currentPoint = 0;
		}

		currentTarget = NPCTargetPointsFound[currentPoint];
	}

}

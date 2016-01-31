using UnityEngine;
using System.Collections;

public class NPCTarget : MonoBehaviour {


	public int targetOrder;

	public bool IsDistractor = true;
	public float DistractorTime = 3.0f;


	public NPCTargetPoints parentTargetPoints;


	void Start()
	{
		if(GetComponent<SpriteRenderer>()) GetComponent<SpriteRenderer>().enabled = false;
		parentTargetPoints = GetComponentInParent<NPCTargetPoints>();

	}


	void OnTriggerStay2D(Collider2D col)
	{
		NPC npc = col.gameObject.GetComponent<NPC>();

		if(npc)
		{
			if(npc.arrivedToTarget)
			{
				if(gameObject.name == parentTargetPoints.GetCurrentNPCTarget().name)
				{
					parentTargetPoints.moveCurrentPoint();
					//Debug.Log(npc.name + "a Siguiente punto" );
					npc.arrivedToTarget = false;
				}
			}
		}
	}
}

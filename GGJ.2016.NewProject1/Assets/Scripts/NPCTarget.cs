using UnityEngine;
using System.Collections;

public class NPCTarget : MonoBehaviour {


	public int targetOrder;

	public bool IsDistractor = true;
	public float DistractorTime = 3.0f;


	public NPCTargetPoints parentTargetPoints;


	void Start()
	{

		parentTargetPoints = GetComponentInParent<NPCTargetPoints>();

	}


	void OnTriggerEnter2D(Collider2D col)
	{
		NPC npc = col.gameObject.GetComponent<NPC>();

		if(npc)
		{
			if(gameObject.name == parentTargetPoints.GetCurrentNPCTarget().name)
			{
				parentTargetPoints.moveCurrentPoint();
				Debug.Log(npc.name + "a Siguiente punto" );
			}
		}
	}
}

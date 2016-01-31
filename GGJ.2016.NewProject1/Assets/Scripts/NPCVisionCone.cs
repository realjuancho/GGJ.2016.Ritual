using UnityEngine;
using System.Collections;

public class NPCVisionCone : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D col)
	{
		//TODO
		if(col.gameObject.tag == Hash.Tags.Player || col.gameObject.GetComponent<Abuela>())
		{
			
			gameObject.GetComponentInParent<NPC>().grandmaFound = true;
		}

		//Debug.Log(col.name);
	}
}

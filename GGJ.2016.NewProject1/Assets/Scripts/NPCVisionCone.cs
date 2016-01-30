using UnityEngine;
using System.Collections;

public class NPCVisionCone : MonoBehaviour {


	public bool grandmaFound = false;

	void OnTriggerEnter2D(Collider2D col)
	{
		//TODO
		if(col.gameObject.tag == Hash.Tags.Player)
		{
			grandmaFound = true;

		}

		//Debug.Log(col.name);
	}
}

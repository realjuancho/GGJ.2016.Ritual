using UnityEngine;
using System.Collections;

public class Abuela : MonoBehaviour {

	public Hash.LocationNames location;

	public Inventory inventory;

	// Use this for initialization
	void Awake () {

		gameObject.AddComponent<Inventory>();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
	{

		CameraPosition camPos = col.gameObject.GetComponent<CameraPosition>();

		if(camPos)
		{
			Debug.Log("Abuela esta en: " + col.name);
			location = camPos.camLocation;
		}
	}

}



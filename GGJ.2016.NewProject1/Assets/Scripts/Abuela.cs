using UnityEngine;
using System.Collections;

public class Abuela : MonoBehaviour {

	public Hash.LocationNames location;


	// Use this for initialization
	void Start () {
	
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



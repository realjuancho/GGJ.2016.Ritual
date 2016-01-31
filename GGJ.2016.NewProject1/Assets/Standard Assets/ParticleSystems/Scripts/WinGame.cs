using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {
	public GameObject Particula;
	public bool ganar;
	public GameObject origen;

	// Use this for initialization
	void Start ()
	{
		ganar = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ganar == true) 
		{
			Instantiate (Particula, origen.transform.position, origen.transform.rotation);
			ganar = false;
		}
	}
}

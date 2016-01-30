using UnityEngine;
using System.Collections;

public class IAObjeto : MonoBehaviour {

	public GameObject Abuela;
	public Vector2 distancia;
	public bool clic;

	// Use this for initialization
	void Start () 
	{
		clic = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		distancia = this.gameObject.transform.position - Abuela.transform.position;
		clic = Input.GetMouseButton (0);
		if (distancia.magnitude <= 2f && clic == true) 
		{
			Destroy (this.gameObject);
		}
	}
}

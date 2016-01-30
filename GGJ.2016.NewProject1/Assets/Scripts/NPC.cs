using UnityEngine;
using System.Collections;


public class NPC : MonoBehaviour {

	//Tiempo que permanecera distraido el NPC
	public float timeSinceDistracted;
	public float timeToDistract;
	public bool distracted;

	//Reporta que encontró a la abuela
	public bool grandmaFound;

	//Tiempo que tardará en girar el NPC de dirección
	public float turningTime = 3.0f;
	public float timeSinceCurrentlyLooking = 0.0f;
	public float NPCspeed = 1.0f;

	//Dirección en la que girará el NPC
	public enum LookingDirection { Left, Right };
	public LookingDirection currentlyLooking = LookingDirection.Right;

	public NPCTargetPoints posicionesObjetivo;
	public Hash.LocationNames myLocation;
	public bool arrivedToTarget;

	//Campo de visión del NPC 
	//TODO: Añadir Atributo RequiredComponent
	BoxCollider2D visionFieldBoxCollider2D;
	SpriteRenderer spriteRenderer;
	float visionFieldOffsetX;
	bool flipX;


	void Start ()
	{
		//Encuentra componentes para hacer flip del NPC

		NPCVisionCone visionCone = GetComponentInChildren<NPCVisionCone>();

		visionFieldBoxCollider2D = visionCone.gameObject.GetComponent<BoxCollider2D>();
		visionFieldOffsetX = visionFieldBoxCollider2D.offset.x;

		spriteRenderer = GetComponent<SpriteRenderer>();
		flipX = spriteRenderer.flipX;


		NPCTargetPoints[] tmpposicionesObjetivo = GameObject.FindObjectsOfType<NPCTargetPoints>();

		foreach(NPCTargetPoints npc in tmpposicionesObjetivo)
		{
			if(npc.location == myLocation)
			{
				posicionesObjetivo = npc;
				break;
			}
		}
	}


	void Update ()
	{
	
			NPCTarget posicionObjetivo = posicionesObjetivo.GetCurrentNPCTarget();

			//Si encuentra una posición de objetivo
			if(posicionObjetivo)
			{

				//Voltea a ver la posicion de objetivo
				if(posicionObjetivo.transform.position.x > transform.position.x) 
					currentlyLooking = LookingDirection.Right;
				else 
					currentlyLooking = LookingDirection.Left;

				SwitchFaces();

				if(!distracted)
				{
					transform.position = Vector2.Lerp(transform.position, posicionObjetivo.transform.position, Time.deltaTime * NPCspeed);

					Vector3 distancia = posicionObjetivo.transform.position - transform.position;

					if(distancia.magnitude < 0.01f)
					{
						transform.position = posicionObjetivo.transform.position;
						arrivedToTarget = true;
						distracted = posicionObjetivo.IsDistractor;
						timeToDistract = posicionObjetivo.DistractorTime;
					}
					visionFieldBoxCollider2D.enabled = true;
				}
				else 
				{
					if(timeSinceDistracted < timeToDistract)
					{
						timeSinceDistracted += Time.deltaTime;
						visionFieldBoxCollider2D.enabled = false;
					}
					else
					{
						distracted = false;
						timeSinceDistracted = 0.0f;
						timeToDistract = 0.0f;
					}
				}

			}

			else{

				//Si el tiempo que ha estado mirando una direccion supera el maximo permitido, el NPC cambiará de dirección
				timeSinceCurrentlyLooking += Time.deltaTime;
				if(timeSinceCurrentlyLooking > turningTime)
				{
					if(currentlyLooking == LookingDirection.Left) currentlyLooking = LookingDirection.Right;
					else currentlyLooking = LookingDirection.Left;

					timeSinceCurrentlyLooking = 0.0f;
					Debug.Log("Now Turn " + currentlyLooking);

					SwitchFaces();
				}
			}
	}


	void FixedUpdate()
	{
		

	}


	void SwitchFaces()
	{
		if(currentlyLooking == LookingDirection.Right) 
				{
					spriteRenderer.flipX = flipX;
					visionFieldBoxCollider2D.offset = new Vector2(visionFieldOffsetX,0);
				}
				else {
					spriteRenderer.flipX = !flipX;
					visionFieldBoxCollider2D.offset = new Vector2(visionFieldOffsetX *-1,0);
				}
					
	}



}

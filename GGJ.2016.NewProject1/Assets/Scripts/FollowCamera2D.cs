using UnityEngine;
using System.Collections;

public class FollowCamera2D : MonoBehaviour {


	public CameraPosition[] cameraPositions;
	public Abuela abuelaTarget;
	public CameraPosition currentCameraPosition;
	public float smoothCamera = 3.0f;

	void Start()
	{

		cameraPositions = GameObject.FindObjectsOfType<CameraPosition>();
		abuelaTarget = GameObject.FindObjectOfType<Abuela>();

	}


	void Update()
	{

		if(abuelaTarget)
		{
			Debug.Log(abuelaTarget.location);

			foreach(CameraPosition camPos in cameraPositions)
			{
				if(camPos.camLocation == abuelaTarget.location)
				{
					currentCameraPosition = camPos;
					transform.position = Vector3.Lerp(transform.position, currentCameraPosition.transform.position, Time.deltaTime * smoothCamera);
				}

			}


		}

	}

}

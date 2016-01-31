using UnityEngine;
using System.Collections;

public class ButtonMenuAction : MonoBehaviour {

	Animator animController;
	// Use this for initialization
	void Start () {

		animController = GetComponentInParent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PressStart()
	{

		animController.SetTrigger(Hash.AnimationParameters.pressStart);

	}
}

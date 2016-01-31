using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasFader : MonoBehaviour {


	Image canvasImage;
	

	// Use this for initialization
	void Start () {

		canvasImage = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {

		

	}

	public void FadeIn()
	{
		canvasImage.CrossFadeAlpha(0,2,false);
	}

	public void FadeOut()
	{
	  	canvasImage.CrossFadeAlpha(1,2,false);
	}
}

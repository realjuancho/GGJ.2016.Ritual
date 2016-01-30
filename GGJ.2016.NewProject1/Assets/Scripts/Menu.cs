using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public Slider volumeSlider;
	public Button exitButton;
	public Button returnButton;

	void Start (){
		volumeSlider.onValueChanged.AddListener(ChangeValue);
		ChangeValue(volumeSlider.value);
		exitButton.onClick.AddListener (exitGame);
		returnButton.onClick.AddListener (closeMenu);
	}
	void ChangeValue(float newValue) {
		AudioListener.volume = newValue;
	}
	void exitGame() {
		Application.Quit();
	}
	void closeMenu(){
		Destroy (GameObject.FindGameObjectWithTag ("Menu"));
	}

}

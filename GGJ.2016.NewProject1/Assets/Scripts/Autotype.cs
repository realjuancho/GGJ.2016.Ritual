using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip sound;

	void Start () {
		writeText("Hola soy un Texto");
	}

	void writeText(string text ){
		StartCoroutine(TypeText(text));
	}
	IEnumerator TypeText (string message) {
		GetComponent<Text>().text = "";
		foreach (char letter in message.ToCharArray()) {
			GetComponent<Text>().text += letter;
			if (sound)
				GetComponent<AudioSource>().PlayOneShot (sound);
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}      
	}
}
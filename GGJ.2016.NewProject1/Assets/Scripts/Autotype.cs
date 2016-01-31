using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip sound;

<<<<<<< HEAD
=======
	public static void writeText(string text ){
		//instance.StartCoroutine(TypeText("Hola soy un Text"));
	}
>>>>>>> 813c2c1602342c05a8a635c47f6d00006b3a6b49
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
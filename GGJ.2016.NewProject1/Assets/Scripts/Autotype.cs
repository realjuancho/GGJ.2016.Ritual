using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip sound;
	Text textComp;
	static public AutoType instance; 

	public static void writeText(string text ){
		//instance.StartCoroutine(TypeText("Hola soy un Text"));
	}
	void Start () {
		instance = this;
		writeText("Hola soy un Texto");
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
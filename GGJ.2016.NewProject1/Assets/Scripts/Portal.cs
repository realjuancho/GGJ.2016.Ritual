using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
	
	public int code;
	float time2Wait = 0f;
	public GameObject player;
	// Update is called once per frame
	void Update () {
		if (time2Wait > 0f)
			time2Wait -= Time.deltaTime;
	}
	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "Player" && time2Wait <= 0f && (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow))) {
			Debug.Log ("Tocado");
			foreach (Portal port in FindObjectsOfType<Portal>()) {
				if (port.code == code && port != this) {
					port.time2Wait = 1f;
					Debug.Log (time2Wait);
					Vector2 pos = port.gameObject.transform.position;
					player.GetComponent<Collider2D> ().gameObject.transform.position = pos;
				}
			}
		}
	}
}

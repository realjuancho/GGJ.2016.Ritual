using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
	
	public int code;
	float time2Wait = 0;

	// Update is called once per frame
	void Update () {
		if (time2Wait > 0)
			time2Wait -= Time.deltaTime;
	}
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name == "Character" && time2Wait <= 0/*&& Input.GetKey(KeyCode.W)*/)
			Debug.Log ("Tocado");
			foreach (Portal port in FindObjectsOfType<Portal>()) {
				if (port.code == code && port != this) {
					port.time2Wait = 2f;
					Vector3 pos = port.gameObject.transform.position;
					GetComponent<Collider>().gameObject.transform.position = pos;
				}
			}
	}
}

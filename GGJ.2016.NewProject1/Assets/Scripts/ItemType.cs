using UnityEngine;
using System.Collections;

public class ItemType : MonoBehaviour {


	public Hash.ItemTypes itemType;
	public bool isPickUpable;
	public bool isThrowable;
	public Sprite imageSprite;
	public AudioClip audioClipEffect;

	private Animator animAbuela;
	private bool collidingWithAbuela;
	private AbuelaInventory inventory;

	void Throw(){


	}
	void Update() {
		if (collidingWithAbuela && isPickUpable && Input.GetAxis("Use") == 1) {
			animAbuela = GameObject.FindWithTag ("playerSprite").GetComponent<Animator>();
			animAbuela.SetBool ("Crouch", true);
			bool b = inventory.AddToInventory(itemType, imageSprite);
			//TODO:
			if (b)
			{
				AudioSource.PlayClipAtPoint(audioClipEffect , Vector3.zero); 
				Destroy(gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		Abuela abuela =  col.GetComponent<Abuela>();
		inventory = abuela.GetComponentInChildren<AbuelaInventory>();
		if (abuela) {
			collidingWithAbuela = true;
		} else {
			collidingWithAbuela = false;
		}
	}
}

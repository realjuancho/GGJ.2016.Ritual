using UnityEngine;
using System.Collections;

public class ItemType : MonoBehaviour {


	public Hash.ItemTypes itemType;
	public bool isPickUpable;
	public bool isThrowable;
	public Sprite imageSprite;
	public AudioClip audioClipEffect;

	void Throw(){


	}


	void OnTriggerEnter2D(Collider2D col)
	{

		Abuela abuela =  col.GetComponent<Abuela>();
		if(abuela)
		{
			AbuelaInventory inventory = abuela.GetComponentInChildren<AbuelaInventory>();
			//Debug.Log(inventario.name);

			if(isPickUpable)
			{
				bool b = inventory.AddToInventory(itemType, imageSprite);

				//TODO:

				if (b)
				{
					AudioSource.PlayClipAtPoint(audioClipEffect , Vector3.zero); 
					Destroy(gameObject);
				}
			}
		}
	}
}

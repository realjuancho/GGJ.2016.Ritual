using UnityEngine;
using System.Collections;

public class ItemType : MonoBehaviour {


	public Hash.ItemTypes itemType;

	public bool isPickUpable;
	public bool isThrowable;

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
				inventory.AddToInventory(itemType);

				Destroy(gameObject);
			}
		}
	}
}

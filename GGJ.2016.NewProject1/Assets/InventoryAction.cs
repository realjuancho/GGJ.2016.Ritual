using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryAction : MonoBehaviour {

	public Sprite SourceImage;
	public AbuelaInventory inventario;
	public ItemLibrary itemLibrary;
	public ItemImage[] itemImageLibrary;

	// Use this for initialization
	void Start () {
		
		inventario = GameObject.FindObjectOfType<AbuelaInventory>();
		itemLibrary = GameObject.FindObjectOfType<ItemLibrary>();
		itemImageLibrary = itemLibrary.imageLibrary;
		SourceImage = GetComponent<Image>().sprite;
	}


	// Update is called once per frame
	void Update () {


		foreach(InventoryItems item in inventario.heldItems)
		{
			foreach(ItemImage it in itemImageLibrary)
			{
				if(it.itemType == item.itemType)
					SourceImage = it.itemImage;
			}
		}
	}
}

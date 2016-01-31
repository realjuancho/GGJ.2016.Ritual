using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryAction : MonoBehaviour {

	public Hash.ButtonOption buttonOption;
	public Image SourceImage;
	public AbuelaInventory inventario;
	public InventoryItems inventoryItem;

	// Use this for initialization
	void Start () {
		
		inventario = GameObject.FindObjectOfType<AbuelaInventory>();
		SourceImage = GetComponent<Image>();
	}


	// Update is called once per frame
	void Update () {

		
		switch(buttonOption)
		{
			case Hash.ButtonOption.ButtonA:
				if(inventario.heldItems.Count > 0) {
					SourceImage.sprite = inventario.heldItems[0].spriteImage;
					inventoryItem = inventario.heldItems[0];}
				break;
			case Hash.ButtonOption.ButtonB:
				if(inventario.heldItems.Count > 1) {
					SourceImage.sprite = inventario.heldItems[1].spriteImage;
					inventoryItem = inventario.heldItems[1];}
				break;
			case Hash.ButtonOption.ButtonC:
				if(inventario.heldItems.Count > 2) {
					SourceImage.sprite = inventario.heldItems[2].spriteImage;
					inventoryItem = inventario.heldItems[2];
					}
				break;
			case Hash.ButtonOption.ButtonD:
				if(inventario.heldItems.Count > 3) {
					SourceImage.sprite = inventario.heldItems[3].spriteImage;
					inventoryItem = inventario.heldItems[3];
					}
				break;

		}

	}

	public void ActionButton()
	{
		Debug.Log("Trying to use: " + inventoryItem.itemType);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryAction : MonoBehaviour {

	public Hash.ButtonOption buttonOption;
	public Image SourceImage;
	public AbuelaInventory inventario;

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
			if(inventario.heldItems.Count > 0) SourceImage.sprite = inventario.heldItems[0].spriteImage;
				break;
			case Hash.ButtonOption.ButtonB:
			if(inventario.heldItems.Count > 1) SourceImage.sprite = inventario.heldItems[1].spriteImage;
				break;
			case Hash.ButtonOption.ButtonC:
			if(inventario.heldItems.Count > 2) SourceImage.sprite = inventario.heldItems[2].spriteImage;
				break;
			case Hash.ButtonOption.ButtonD:
			if(inventario.heldItems.Count > 3) SourceImage.sprite = inventario.heldItems[3].spriteImage;
				break;

		}
		
			
		
	}
}

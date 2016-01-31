using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]
public class AbuelaInventory : MonoBehaviour
{

	public bool displayInventory = false;
	public List<InventoryItems> heldItems;
	public Animator animUIController;
	public static AudioSource audio;

	void Start()
	{
		heldItems = new List<InventoryItems>();

		animUIController = GameObject.Find("UIInventario").GetComponent<Animator>();

		audio = GetComponent<AudioSource>();


	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.I))
		{
			
			animUIController.SetTrigger(Hash.AnimationParameters.switchMenu);
		}

	}

	public bool AddToInventory(Hash.ItemTypes myItemType, Sprite mySprite)
	{
		audio.PlayOneShot(audio.clip, 1.0F);
		if(heldItems.Count < 4)
		{
			InventoryItems item = new InventoryItems( myItemType.ToString(), myItemType);
			item.spriteImage = mySprite;
			heldItems.Add(item);
			return true;
		}
		else
		{
			return false;
		}
	}

	public void RemoveFromInventory(Hash.ItemTypes myItemType)
	{

		foreach(InventoryItems i in heldItems)
		{
			if(i.itemType == myItemType)
			{
				heldItems.Remove(i);
			}

		}
	}



}

[System.Serializable]
public class InventoryItems 
{
	[SerializeField]
	public string name;

	[SerializeField]
	public Hash.ItemTypes itemType;


	[SerializeField]
	public bool isUsable = false;

	[SerializeField]
	public Sprite spriteImage;

	public InventoryItems(string myName, Hash.ItemTypes myItemType)
	{
		name = myName;
		itemType = myItemType;

	}

	public void EnableUsable()
	{
		isUsable = true;

	}

	public void DisableUsable()
	{
		isUsable = true;

	}

}




using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ObjectiveChecker : MonoBehaviour {


	public List<ItemsChecklist> itemsToCheck;

	public bool IsCurrentObjective;
	public bool ObjectiveCompleted = false;
	public WinGame myParticleSystem;

	void Start()
	{
		myParticleSystem = GetComponentInChildren<WinGame>();

	}


	void Update()
	{

		if(!ObjectiveCompleted)
		{
			bool tmpObjectiveCompleted = true;

			foreach(ItemsChecklist itemToCheck in itemsToCheck)
			{
				if(!itemToCheck.hasItem)
				{
					tmpObjectiveCompleted = false;
					break;
				}
			}
			ObjectiveCompleted= tmpObjectiveCompleted;
			if(ObjectiveCompleted) myParticleSystem.ganar = true;
		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{

		Abuela abuela =  col.gameObject.GetComponent<Abuela>();
		if(abuela)
		{
			AbuelaInventory inventario = abuela.GetComponentInChildren<AbuelaInventory>();

			if(inventario)
			{
				foreach(ItemsChecklist neededItem in itemsToCheck)
				{
					foreach(InventoryItems heldItem in inventario.heldItems)
					{
						if(neededItem.itemType == heldItem.itemType)
						{
							neededItem.hasItem = true;
						}
					}
				}
			}
		}
	}


}

[System.Serializable]
public class ItemsChecklist
{
	[SerializeField]
	public Hash.ItemTypes itemType;
	[SerializeField]
	public bool hasItem;
	[SerializeField]
	public bool requiredItem;
	[SerializeField]
	public bool optionalItem;

}

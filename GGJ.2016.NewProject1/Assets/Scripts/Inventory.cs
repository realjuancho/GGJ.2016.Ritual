using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item {
	public int id;


	public Item(int itemID){
		id = itemID;

	}

}

public class Inventory : MonoBehaviour {

	public string[] itemNames;
	public Sprite[] itemIcons;

	public static string[] names;
	public static Sprite[] icons;
	public static List<Item> inventory;

	void Start () {
		names = itemNames;
		icons = itemIcons;
		inventory = new List<Item>();
	}

	public static void addItem (Item item) {
		inventory.Add(item);
	}

	public static bool removeItem (Item item) {
		foreach (Item slot in inventory){
			if (slot.id == item.id) {
				inventory.RemoveAt(slot.id);
				return true;
			}
		}
		return false;
	}

	public static bool checkForItem (Item item){
		foreach (Item slot in inventory){
			if (slot.id == item.id) {
				return true;
			}
		}
		return false;
	}
	public static int getSlotID (int slot){
		return inventory[slot].id;
	}
	public static string getName(int itemID){
		return names[itemID];
	}
	public static Sprite getIcon(int itemID){
		return icons[itemID];
	}



	/*----------------------DEBUG------------------*/

	public static void displayInventory(){
		Debug.Log("----Inventory----\n");
		foreach (Item slot in inventory){
			//Debug.Log("Item : " + slot.id + " Amount: " + slot.amount + "\n");
		}
		Debug.Log("-----------------\n");
	}

	/*----------------------END------------------*/
}

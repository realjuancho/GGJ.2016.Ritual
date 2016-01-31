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

[RequireComponent(typeof(AudioSource))]
public class Inventory : MonoBehaviour {

	public string[] itemNames;
	public Sprite[] itemIcons;

	public static string[] names;
	public static Sprite[] icons;
	public static List<Item> inventory;

	public static AudioSource audio;

	void Start () {
		names = itemNames;
		icons = itemIcons;
		inventory = new List<Item>();
		audio = GetComponent<AudioSource>();
	}

	public static void addItem (Item item) {
		inventory.Add(item);
		audio.PlayOneShot(audio.clip, 1.0F);
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
		
}

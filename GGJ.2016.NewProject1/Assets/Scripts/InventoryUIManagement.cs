using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryUIManagement : MonoBehaviour {

	public GameObject UIItem;

	int numberOfItems;

	// Use this for initialization
	void Start () {
		numberOfItems = 0;
		refreshUIInventory();
	}
	
	// Update is called once per frame
	void Update () {
		refreshUIInventory();
	}

	void refreshUIInventory (){
		removeAllUIItems();
		foreach (Item slot in Inventory.inventory){
			if(slot.id != 0){
				addUIItem(slot);
			}
		}
	}

	void addUIItem (Item item){
		GameObject clone = Instantiate(UIItem) as GameObject;
		clone.transform.SetParent(gameObject.transform, false);
		clone.GetComponent<RectTransform>().anchoredPosition = new Vector2(clone.GetComponent<RectTransform>().anchoredPosition.x, (-60 * numberOfItems) -10);
		clone.GetComponent<UnityEngine.UI.Image>().sprite = Inventory.getIcon(item.id);
		clone.transform.Find("Item Name").GetComponent<UnityEngine.UI.Text>().text = Inventory.getName(item.id);
		numberOfItems++;
	}
	void removeAllUIItems (){
		GameObject[] objects = GameObject.FindGameObjectsWithTag("UIInventoryItem");
		for (int i=0; i<objects.Length; i++){
    		Destroy(objects[i]);
    	}
    	numberOfItems = 0;
	}
}

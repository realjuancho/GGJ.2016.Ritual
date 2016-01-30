using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemLibrary : MonoBehaviour {

	public ItemImage[] imageLibrary;

}

[System.Serializable]
public class ItemImage
{

	[SerializeField]
	public Hash.ItemTypes itemType;


	[SerializeField]
	public Sprite itemImage;

	
}

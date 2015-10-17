using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickedUpItems : MonoBehaviour
{
	public int pickedUpItems;
	public Text pickedUpItemsText;

	public void Update()
	{
		pickedUpItemsText.text = "Items Collected: " + pickedUpItems.ToString();
	}
}
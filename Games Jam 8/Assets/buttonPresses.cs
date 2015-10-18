using UnityEngine;
using System.Collections;

public class buttonPresses : MonoBehaviour {

	public GameObject target;
	public GameObject myUI;

	public void BACK()
	{
		print ("aa");
		target.SetActive(true);
		myUI.SetActive(false);
	}
}

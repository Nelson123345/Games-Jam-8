using UnityEngine;
using System.Collections;

public class ObjectChanger : MonoBehaviour
{
	public GameObject[] objects;
	public string objectName;

	private void Start()
	{
		gameObject.tag = "CollectibleItem";
		objectName = gameObject.name;
		ChangeObject();
	}

	private void ChangeObject()
	{
		int randomI = Random.Range(0, objects.Length);
		gameObject.GetComponent<MeshFilter>().mesh = objects[randomI].GetComponent<MeshFilter>().sharedMesh;
	}
}
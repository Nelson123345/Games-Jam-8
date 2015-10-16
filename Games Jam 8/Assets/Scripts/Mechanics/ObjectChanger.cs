using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectChanger : MonoBehaviour
{

	public GameObject[] objectInspector;
	public GameObject[] objectInScene;
	public List<GameObject> objectPrefabs, objectSelection;
	public string tag;//can be changed to objectName



	private void Start()
	{
		getModelInScene();
		getModelInspector();
	}

	private void getModelInScene()
	{
		objectSelection.AddRange(GameObject.FindGameObjectsWithTag(name));
	}

	
	private void getModelInspector()
	{
		for(int i=0; i < objectInspector.Length; i++)
		{
			objectPrefabs.Add (objectInspector[i].gameObject as GameObject);
		}
	}

	private void selectRandomGameObject()
	{
		getRenderer(objectPrefabs[randomPoint(objectPrefabs.Count)]).material = getRenderer(objectSelection[randomPoint(objectSelection.Count)]).material;
	}

	private Renderer getRenderer(GameObject savedObject)
	{
		Renderer savedRender = savedObject.GetComponent<Renderer>();
		return savedRender;
	}

	private int randomPoint(int lengthOfArray)
	{
		int randomPoints = Random.Range (0, lengthOfArray);
		return randomPoints;
	}
}

/*
	Set objectPrefabs to objectInspector
	Set ObjectSelection to objectInspector
	Find all objects with collectibleObject tag and store them in the objectInScene array
	Select the value from the top of the objectPrefabs list and select a random value from objectSelection
	
 */





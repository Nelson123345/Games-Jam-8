using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectChanger : MonoBehaviour
{
	public GameObject[] objectPrefabs;
	public string objectTag;

	private GameObject[] getObjectsInScene()
	{
		return GameObject.FindGameObjectsWithTag("objectTag");
	}

	private void changeMesh(GameObject changer, GameObject swapper)
	{
		objectsInScene[p].GetComponent<MeshFilter>().mesh = 
	}

	private void chooseMeshes()
	{
		//Creating two Local Lists to cycle through the objects

		//prefabObjects will store then remove the first object until it is gone
		List<GameObject> prefabObjects = new List<GameObject>();

		//sortObjects will get a
		List<GameObject> sortObjects = new List<GameObject>();

		prefabObjects.AddRange(objectPrefabs);
		sortObjects.AddRange(objectPrefabs);

		GameObject[] objectsInScene = getObjectsInScene();

		for(int i = 0; i < objectPrefabs.Length; i++)
		{
			GameObject changingObject = prefabObjects[0];
			prefabObjects.RemoveAt(0);

			int o = Random.Range(0, sortObjects.Count);

			GameObject newObject = sortObjects[o];

			sortObjects.RemoveAt(o);

			for(int p = 0; p < objectsInScene.Length; p++)
			{
				if(objectsInScene[p].name == changingObject.name)
				{

				}
			}
		}
	}

/*
 	public GameObject[] objectInspector;
	public GameObject[] objectInScene;
	public List<GameObject> objectPrefabs, objectSelection;
	public string tag;//can be changed to objectName
*/


/*	private void Start()
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
	}*/
}

/*
	Set objectPrefabs to objectInspector
	Set ObjectSelection to objectInspector
	Find all objects with collectibleObject tag and store them in the objectInScene array
	Select the value from the top of the objectPrefabs list and select a random value from objectSelection
	
 */





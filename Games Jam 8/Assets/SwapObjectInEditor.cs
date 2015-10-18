using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SwapObjectInEditor : MonoBehaviour
{
	public GameObject objToReplace;
	public bool toggle;
	private void Update()
	{
		if(toggle)
		{
			replaceObject();
			toggle =! toggle;
		}
	}

	private void replaceObject()
	{
		GameObject newGameobject = GameObject.Instantiate(objToReplace) as GameObject;
		newGameobject.transform.parent = gameObject.transform.parent;
		newGameobject.transform.rotation = gameObject.transform.rotation;
		newGameobject.transform.localScale = gameObject.transform.localScale;
		newGameobject.transform.position = gameObject.transform.position;
		DestroyImmediate(gameObject);
	}
}
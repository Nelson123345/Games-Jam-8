using UnityEngine;
using System.Collections;

public class startLevel : MonoBehaviour {

	public void LOADLEVEL()
	{
		Application.LoadLevel(1);
	}
	public void QUIT()
	{
		Application.Quit();
	}
}

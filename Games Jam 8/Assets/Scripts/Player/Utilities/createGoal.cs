﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class createGoal : MonoBehaviour
{
	public List<GameObject> collectibleObjects;
	public List<string> collectibleNames;
	public List<GameObject> item;
	public List<item> items;

	private void Start()
	{
		findAllCollectibleObject();
	}

	private void findAllCollectibleObject()
	{
		collectibleObjects.AddRange(GameObject.FindGameObjectsWithTag("CollectibleItem"));
	}

	private void sortAllCollectibleObjects()
	{
		for(int i = 0; i < collectibleObjects.Count; i++)
		{

		}
	}
}
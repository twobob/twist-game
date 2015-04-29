﻿using UnityEngine;
using System.Collections;
// Young Chu
//


// Our item class is a template for item objects
// Doesnt need to inherit from MonoBehaviour
// Make this class readable in he inspector
// no MonoBheaviour, no attaching this scrip to a scene object
[System.Serializable]
public class Item 
{
	public int ID;
	public string itemName;
	public string itemDescription;
	public itemType thisItemType;

	// enum list
	//research the hell is an "enum"
	public enum itemType{
		consumable,
		quest,
		artifact
	};


	// Class constructor
	// Create a class instance

	public Item(int _ID, string _itemName, string _itemDescription, itemType _thisItemType) // Parameters for creating a class instance
	{
		// Our class variables will equal the parameters we put in our constructor
		ID 				= _ID;
		itemName 		= _itemName;
		itemDescription = _itemDescription;
		thisItemType 	= _thisItemType;
	}

	// Create an empty constructor
	public Item()
	{

	}

}

using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		string[] inventory = new string[5];

		inventory [0] = "Key";
		inventory [1] = "Chest";
		inventory [2] = "Locket";
		inventory [3] = "Pearl";
		inventory [4] = "Metal Wedge";

		foreach (string item in inventory) 
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	int numQuests = 10;
	
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < numQuests; i ++) 
		{
			Debug.Log ("Generating Quest Number: " + i);
		}
		
	}

	// Update is called once per frame
	void Update () {
	
	}
}

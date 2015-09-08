using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int myInt = 75 ;
	// Use this for initialization
	void Start () {
		myInt = MultiplyByThree (myInt);
		Debug.Log (myInt);
	}

	int MultiplyByThree (int number){
		int ret;

		ret = number * 3;

		return ret;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

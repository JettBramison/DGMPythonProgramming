using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour {

	public int[] kitchenObjects = new int[7];
	

	// Use this for initialization
	void Start () {
	
		kitchenObjects [0] = 1;
		kitchenObjects [1] = 1;
		kitchenObjects [2] = 15;
		kitchenObjects [3] = 20;
		kitchenObjects [4] = 30;
		kitchenObjects [5] = 4;
		kitchenObjects [6] = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

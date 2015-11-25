using UnityEngine;
using System.Collections;

public class Ducks : MonoBehaviour 
{

	var theObject:GameObject;
	var maxPos:float = 2000.0;
	var minPos:float = 9.0;
	var max = 22;
	
	function Start()
	{
		StartCoroutine(spawn());
	}
	
	function spawn() : IEnumerator 
	{
		for (var i = 0; i < max; i++) 
		{
			yield WaitForSeconds(2.0);
			var theNewPos= new Vector3 (Random.Range(minPos,maxPos),0,Random.Range(minPos,maxPos));
			var go : GameObject = Instantiate(theObject);
			go.transform.position = theNewPos;
		}
	}
		

}

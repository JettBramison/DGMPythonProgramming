using UnityEngine;
using System.Collections;

public class DataTypes : MonoBehaviour 
{
	void Start () 
	{
		//Value type variable
		Vector3 pos = transform.position;
		pos = new Vector3(6, 1, 6);
		
		//Reference type variable
		Transform tran = transform;
		tran.position = new Vector3(6, 1, 6);
	}
}
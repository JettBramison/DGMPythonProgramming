using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{

	int bladesOfGrass = 100;


	// Use this for initialization
	void Start () 
	{
		while (bladesOfGrass > 0) 
		{
			print ("I'm cutting the grass!");
			bladesOfGrass -= 15;
			print (bladesOfGrass);
		}
	}


	
}
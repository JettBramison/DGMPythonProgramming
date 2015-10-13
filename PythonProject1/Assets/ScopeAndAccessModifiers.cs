using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int rocks = 10;
	
	
	private int weeds = 6;
	private int torches = 2;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		rocks = 57;
		
		myOtherClass = new AnotherClass();
		myOtherClass.InfinityBag(rocks, myOtherClass.voidWhip);
	}
	
	
	void Example (int shovels, int eggs)
	{
		int answer;
		answer = shovels * eggs * rocks;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		Debug.Log("There are this many rocks: " + rocks);
	}
}
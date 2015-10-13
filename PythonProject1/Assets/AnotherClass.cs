using UnityEngine;
using System.Collections;

public class AnotherClass
{
	public int voidWhip;
	public int kraorgBlaster;
	
	
	private int dannonLauncher;
	private int hypoPunch;
	
	
	public void InfinityBag (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Mystical Items Total: " + answer);
	}
	
	
	private void StoreInventory (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Store Inventory Total: " + answer);
	}
}
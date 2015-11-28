using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
	public float crosshairScale = 1;
	public Texture2D cursor;



	// Use this for initialization
	void Start () {
		cursor = Resources.Load<Texture2D> ("Crosshair1");
		Cursor.visible = false;
		//GUI.DrawTexture(new Rect(Input.mousePosition.x, Input.mousePosition.y, cursor.width, cursor.height), cursor);

	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(Input.mousePosition.x - cursor.width/2 , (Screen.height - Input.mousePosition.y) - cursor.height / 2, cursor.width, cursor.height), cursor);

	}
	// Update is called once per frame
	void Update () {
		//if(crosshairTexture!=null)
		//	GUI.DrawTexture(new Rect((Screen.width-crosshairTexture.width*crosshairScale)/2 ,(Screen.height-crosshairTexture.height*crosshairScale)/2, crosshairTexture.width*crosshairScale, crosshairTexture.height*crosshairScale),crosshairTexture);
		//else
		//	Debug.Log("No crosshair texture set in the Inspector");
	
	}
}
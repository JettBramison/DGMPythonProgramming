using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
    private Camera camera;

	// Use this for initialization
	void Start () {
        camera = Camera.main;
        Cursor.visible = false;
    }

	// Update is called once per frame
	void Update () {

        FollowMouse();
        MouseClick();
    }

    void MouseClick() {
        if (Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().Play();
        }
    }

    void FollowMouse() {
  
        var mousePos = Input.mousePosition;
        mousePos.z = 5; 
        this.transform.position = camera.ScreenToWorldPoint(mousePos);//new Vector3(Input.mousePosition.x / Screen.width* ( camera.pixelWidth/ Screen.width ), Input.mousePosition.y / Screen.height * 10f , -5);
    }
}
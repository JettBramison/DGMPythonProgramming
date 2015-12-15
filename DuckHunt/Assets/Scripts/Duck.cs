using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour {
    //small number like 0.05
    public float verticalSpeed;
    private Ducks ducks;
	// Use this for initialization
	void Start () {
        ducks = GameObject.FindObjectOfType<Ducks>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 t = new Vector3(0, verticalSpeed, 0);
        this.transform.position += t;


        if (Input.GetMouseButtonDown(0)) {
            Vector3 m = Input.mousePosition;
            m.z = 5;
            Vector3 temp = Camera.main.ScreenToWorldPoint(m);
            Vector2 mouse = new Vector2(temp.x, temp.y);
            if (GetComponent<PolygonCollider2D>() == Physics2D.OverlapPoint(mouse)) {
                AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
                Destroy(gameObject);
                ducks.NotifyDuckKilled();
            }
        }
    }

    
}

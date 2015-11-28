using UnityEngine;
using System.Collections;

public class Ducks : MonoBehaviour 
{
	
	public Texture2D theObject;
	int max = 10;
	private bool[] draw;
	private Rect[] r; 
	private bool waitingUpdate = false; 
	private int waitTime = 5;
	int numEscaped = 0;
	int score = 0;
	int maxSpeed = 2;
	int horSpeed = 5;
	
	
	void Start()
	{
		r = new Rect[max];
		draw = new bool[max];
		for(int i = 0; i < max; i++){
			draw[i] = false;
			//float vert = Random.Range (0, Screen.height - theObject.height);
			//float horz = Random.Range (0, Screen.width - theObject.width);
			//r[i] = new Rect (horz, vert, theObject.width, theObject.height);
		}
		
		//theObject = Resources.Load<Texture2D> ("duck");
		//StartCoroutine(spawn());
		//spawn ();
	}
	
	IEnumerator CheckSpawn(){	
		yield return new WaitForSeconds(waitTime);
		int times = Random.Range (0, max);
		int act = 0;
		for (int i = 0; i < max; i++) {
			if (!draw [i]) {
				if(act < times){
					act++;
					draw [i] = true;
					float vert = Random.Range (0, Screen.height - theObject.height);
					float horz = Random.Range (0, Screen.width - theObject.width);
					r[i] = new Rect (horz, vert, theObject.width, theObject.height);
				}else{
					break;
				}
			}
		}
		waitingUpdate = false;
	}
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 400, 50), "<size=30>Score: " + score + "</size>");
		GUI.Label (new Rect (10, 60, 400, 50), "<size=30>Number Escaped: " + numEscaped + "</size>");
		for (var i = 0; i < max; i++) {
			if (draw [i]) {
				int speed = Random.Range(0,maxSpeed);
				int hSpeed = Random.Range(-horSpeed,horSpeed);
				Rect tr = new Rect(r[i].xMin - hSpeed ,r[i].yMin - speed,theObject.width,theObject.height);
				r[i] = tr;
				if(r[i].yMin - 1 < 0){
					draw[i] = false;
					numEscaped+=1;
				}else{
					GUI.DrawTexture (r [i], theObject);
				}
			}
			//yield return new WaitForSeconds(2);
			//var theNewPos= new Vector3 (Random.Range(minPos,maxPos),0,Random.Range(minPos,maxPos));
			//var go= Instantiate(theObject);
			//go.transform.position = theNewPos;
			//}
		}
	}
	
	void Update(){
		if (!waitingUpdate) {
			waitingUpdate = true;
			StartCoroutine (CheckSpawn ());
		}
		Vector2 mousePos = new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y);
		for (int i = 0; i < max; i++) {
			if (Input.GetMouseButtonDown (0)) {
				if (r [i].Contains (mousePos) && draw[i]) {
					draw [i] = false;
					score+=1;
				}
			}
		}
	}
}
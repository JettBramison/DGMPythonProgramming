using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ducks : MonoBehaviour {
    public int numWaves;
    public int ducksPerWave;
    public int timeBetweenSpawn;
    private int spawnedWaves;
    private int ducksKilled;
    private Text text;
    public Transform duck;
    private LevelManager levelManager;
    
    private bool running;
	// Use this for initialization
	void Start () {
        text = GameObject.FindObjectOfType<Text>();
        text.text = "Level " + Application.loadedLevel;
        ducksKilled = 0;
        spawnedWaves = 0;
        running = false;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!running) {
            running = true;
            StartCoroutine(Spawn());
        }
        
	}

    public void NotifyDuckKilled() {
        ducksKilled += 1;
        if(ducksKilled >= numWaves * ducksPerWave) {
            levelManager.LoadNextLevel();
        }
    }

    IEnumerator Spawn() {
        yield return new WaitForSeconds(timeBetweenSpawn);
        if (spawnedWaves < numWaves) {
            for (int i = 0; i < ducksPerWave; i++) {
                Instantiate(duck, new Vector3(Random.Range(1f, 12f), 3, -5), Quaternion.identity);
                
            }
            spawnedWaves +=1;
        }
        running = false;
    }
}

using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
    private LevelManager levelManager;
    private static int numMisses = 0;
    public static int maxMisses;
    void Start() {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D trigger) {
        numMisses++;
        if (numMisses >= maxMisses) {
            levelManager.LoadLevel("Lose");
        }
    }

    public void ResetNumMisses() {
        numMisses = 0;
    }



}

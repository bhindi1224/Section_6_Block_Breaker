using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    // config params
    [Range(.01f, 5f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;

    // state variables
    [SerializeField] int currentScore = 0;

    
    // Update is called once per frame
	void Update () {
        Time.timeScale = gameSpeed;    
	}

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}

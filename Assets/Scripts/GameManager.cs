using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool paused = false;
    public static float highScore = 0;
    public static float currScore = 0;

    void Update()
    {
        if (paused && Input.GetKeyDown(KeyCode.R))
            Restart();
        
        currScore += Time.deltaTime;
    }

    public static void OnLoss()
    {
        paused = true;

        if (currScore > highScore)
            highScore = currScore;
        print("Score: " + currScore);
        print("High score: " + highScore);
    }

    public static void Restart()
    {
        currScore = 0;
        paused = false;
        GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        foreach (GameObject asteroid in asteroids)
            Destroy(asteroid);
    }
}

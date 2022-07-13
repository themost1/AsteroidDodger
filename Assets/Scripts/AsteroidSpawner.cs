using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroidPrefab;
    [SerializeField] float asteroidSpeed;
    [SerializeField] public static float asteroidXSpeed = -6;
    float timeBeforeSpawn = 1;

    void Update()
    {
        if (GameManager.paused)
            return;
        
        timeBeforeSpawn -= Time.deltaTime;
        if (timeBeforeSpawn <= 0)
        {
            SpawnAsteroid();
        }
    }

    void SpawnAsteroid()
    {
        int dirMult = Random.Range(0, 2) == 0 ? -1 : 1;
        float spawnX = Random.Range(5, 9);
        float spawnY = dirMult == -1 ? 5 : -5;
        GameObject asteroid = Instantiate(asteroidPrefab, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
        asteroid.GetComponent<Asteroid>().SetSpeed(asteroidSpeed * dirMult);



        float asteroidScale = Random.Range(0.5f, 1.2f);
        asteroid.transform.localScale *= asteroidScale;

        timeBeforeSpawn = 1;
    }
}

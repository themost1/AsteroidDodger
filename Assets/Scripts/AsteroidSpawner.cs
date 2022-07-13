using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroidPrefab;
    [SerializeField] float asteroidSpeed;
    [SerializeField] float maxAsteroidSpeed = 6;
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

        if (asteroidSpeed < maxAsteroidSpeed)
        {
            asteroidSpeed *= 1.00001f;
            asteroidXSpeed *= 1.00001f;

        }
    }

    void SpawnAsteroid()
    {
        int dirMult = Random.Range(0, 2) == 0 ? -1 : 1;
        float spawnX = Random.Range(6.5f, 12.5f);
        float spawnY = dirMult == -1 ? 5 : -5;
        GameObject asteroid = Instantiate(asteroidPrefab, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
        float asteroidSpeedAdj = Random.Range(0.9f, 1.1f);
        asteroid.GetComponent<Asteroid>().SetSpeed(asteroidSpeed * asteroidSpeedAdj * dirMult);



        float asteroidScale = Random.Range(0.5f, 1.2f);
        asteroid.transform.localScale *= asteroidScale;

        timeBeforeSpawn = 1;
    }
}

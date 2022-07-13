using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroidPrefab;
    public static float asteroidXSpeed;
    float timeBeforeSpawn = 1;

    void Update()
    {
        timeBeforeSpawn -= Time.deltaTime;
        if (timeBeforeSpawn <= 0)
        {
            SpawnAsteroid();
        }
    }

    void SpawnAsteroid()
    {
        GameObject asteroid = Instantiate(asteroidPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        float dirMult = Random.Range(0, 2) == 0 ? -1 : 1;
        asteroid.GetComponent<Asteroid>().SetSpeed(3 * dirMult);
        timeBeforeSpawn = 1;
    }
}

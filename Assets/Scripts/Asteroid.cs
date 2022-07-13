using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float speed = -1;

    void Update()
    {
        transform.position += new Vector3(AsteroidSpawner.asteroidXSpeed, speed, 0) * Time.deltaTime;
        if (transform.position.x < -10)
            Destroy(gameObject);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}

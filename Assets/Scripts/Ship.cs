using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float speed = 3.0f;
    
    void Update()
    {
        float moveAmt = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveAmt += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveAmt -= 1;
        }

        Move(moveAmt * speed * Time.deltaTime);
    }

    void Move(float moveAmt)
    {
        transform.position += new Vector3(0, moveAmt, 0);
    }
}

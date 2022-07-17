using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private RawImage img;
    [SerializeField] private float x, y;
    
    void Start()
    {
        float scaleElement = 12 * Screen.width / 1920;
        transform.localScale = new Vector3(scaleElement, scaleElement, 1);
    }

    void Update()
    {
        if (GameManager.paused)
            return;

        img.uvRect = new Rect(img.uvRect.position + new Vector2(x, y) * Time.deltaTime, img.uvRect.size);
    }
}

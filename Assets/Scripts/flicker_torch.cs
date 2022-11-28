using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker_torch : MonoBehaviour
{
    Light candle;
    // Start is called before the first frame update
    void Start()
    {
        candle = GetComponent<Light>();
        candle.intensity = Random.Range(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        candle.intensity = 5f * Mathf.PerlinNoise(Time.time * 0.25f, 0f);
    }
}

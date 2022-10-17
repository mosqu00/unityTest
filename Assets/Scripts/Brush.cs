using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    private float x = 0.0f;
    private float z = 0.0f;
    private const float aX = 0.00008f;
    private const float aZ = 0.0004f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * aX * Mathf.Sin(x);
        transform.position += transform.right * aZ * Mathf.Sin(z);
        x += 0.001f;
        z += 0.002f;
    }
}

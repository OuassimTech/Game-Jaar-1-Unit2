using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -15;

    // Update is called once per frame
    void Update()
    {
        //Destroying objects if they pass the lower and top boundary's
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if
        (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

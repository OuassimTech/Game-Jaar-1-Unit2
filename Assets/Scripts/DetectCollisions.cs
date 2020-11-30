using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Destroying game objects on collision
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

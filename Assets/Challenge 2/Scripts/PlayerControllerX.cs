using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float cooldownSpawnTime = 1.0f;

    private float nextSpawnTime = 0.0f;

    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time > nextSpawnTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextSpawnTime = Time.time + cooldownSpawnTime;
            }
        }
    }
}

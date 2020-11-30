using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float leftBoundary = -17.0f;
    public float rightBoundary = 17.0f;

    public GameObject procetilePrefab;

    // Update is called once per frame
    void Update()
    {
        //creating boundary's
        if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        
        //Making player move left and right
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        //Firering sandwich
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(procetilePrefab, transform.position, procetilePrefab.transform.rotation);
        }

    }
}

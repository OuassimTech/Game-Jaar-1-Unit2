﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        //Moving the sandwich forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

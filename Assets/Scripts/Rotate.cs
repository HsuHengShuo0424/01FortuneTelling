using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 0; 

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5;
        }
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.98f;
    }
}
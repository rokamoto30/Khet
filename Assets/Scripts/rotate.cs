﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            RotateRight();
        }

    }
    void RotateLeft ()
    {
        transform.Rotate (Vector3.forward * 90);
    }
    void RotateRight ()
    {
        transform.Rotate(Vector3.forward * -90);
    }
}

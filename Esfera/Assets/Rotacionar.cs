﻿using UnityEngine;
using System.Collections;

public class Rotacionar : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0.3f, 0.5f, 0.7f);
    }
}

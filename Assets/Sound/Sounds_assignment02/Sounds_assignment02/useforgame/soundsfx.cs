﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundsfx : MonoBehaviour
{
    public AudioSource playsound;

    void OnTriggerEnter(Collider other)
    {
        playsound.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playsound.Play();
    }
}

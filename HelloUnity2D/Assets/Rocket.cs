﻿using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    // Require the rocket to be a rigidbody.
    // This way we the user can not assign a prefab without rigidbody
    public Rigidbody rocket;
    public float speed = 10f;

    void FireRocket()
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position, transform.rotation);
        rocketClone.velocity = transform.forward * speed;

        // You can also acccess other components / scripts of the clone
        rocketClone.GetComponent<MyRocketScript>().DoSomething();
    }

    // Calls the fire method when holding down ctrl or mouse
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRocket();
        }
    }
}

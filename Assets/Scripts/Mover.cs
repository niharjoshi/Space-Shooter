using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
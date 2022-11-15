using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = transform.forward * 2;
    }
    public void Jump()
    {
        rb.velocity += transform.up * 3;
    }
}

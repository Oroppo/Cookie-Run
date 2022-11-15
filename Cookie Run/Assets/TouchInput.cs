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
        rb.velocity = new Vector3(0,0,1) ;
    }
    public void Jump()
    {
        Debug.Log("Jumped");
        rb.velocity = new Vector3(0, 10.0f, 0);
    }
}

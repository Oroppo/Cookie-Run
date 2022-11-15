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
        rb.velocity += new Vector3(0, 1, 0);
    }
}

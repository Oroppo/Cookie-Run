using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    Rigidbody rb;
    bool canJump=false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.AddForce(0,0,2) ;
    }
    public void Jump()
    {
        Debug.LogError("Doot");
        canJump = true;
        rb.AddForce(0, 10, 0,ForceMode.Impulse);
    }
}

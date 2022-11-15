using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{

    public bool isFlat = true;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector2 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * (tilt * 5);

        rb.AddForce(tilt);

    }
}

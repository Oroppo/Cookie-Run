using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = Vector3.forward;
        }
    }
}

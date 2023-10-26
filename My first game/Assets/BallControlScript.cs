using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    private Rigidbody rb;
    float kickStrength = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(kickStrength * Vector3.up, ForceMode.Impulse);
        }

    }
}

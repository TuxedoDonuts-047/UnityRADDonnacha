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

    }

    void KickBall(Transform kicker)
    {
        rb.AddForce(kickStrength * kicker.forward, ForceMode.Impulse);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Zombie")
            print("OOOOOOFFFFFFOFFF");
            if (collision.gameObject.name == "Plane")
        { print("Boing!!"); }
        else
        {
            print("Ouch");
            KickBall(collision.transform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    private Rigidbody rb;
    float kickStrength = 50;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KickBall(Transform kicker)
    {
        rb.AddExplosionForce(kickStrength, kicker.position, 4);
        rb.AddForce(kickStrength * kicker.forward, ForceMode.Impulse);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Zombie")
        { print("OOF!"); }

        if (collision.gameObject.name == "Plane")
        { print("Boing!!"); }
        else
        {
            zombieControlScript testIfZombie =
                collision.gameObject.GetComponent<zombieControlScript> ();
            if (testIfZombie != null)
            {
                testIfZombie.dieNow();
            }

            print("Ouch");

            KickBall(collision.transform);
        }
    }
}

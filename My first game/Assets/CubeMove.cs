using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public Transform footballCloneTemplate;
    float runSpeed=15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += runSpeed * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position -= runSpeed * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 180 * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -180 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           Transform newBall = Instantiate(footballCloneTemplate,
                transform.position + 2*transform.forward, 
                Quaternion.identity);
           BallControlScript myNewBallScript =
                newBall.GetComponent<BallControlScript>();

            myNewBallScript.KickBall(transform);
        }
    }
}

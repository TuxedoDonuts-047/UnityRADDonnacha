using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManagerScript : MonoBehaviour
{

    int numberOfZombies = 200;
    public Transform zombieCloneTemplate;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfZombies; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-50f, 50f),
                0f,
                Random.Range(-50f, 50f));

            Instantiate(zombieCloneTemplate,position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

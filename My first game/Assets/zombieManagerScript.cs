using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManagerScript : MonoBehaviour
{

    int numberOfZombies = 150;
    public Transform zombieCloneTemplate;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfZombies; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-30f, 30f),
                3.6f,
                Random.Range(-30f, 30f));

            Instantiate(zombieCloneTemplate,position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class zombieControlScript : MonoBehaviour
{
    CubeMove player;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow}
        ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 10;
    private float walkingSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindAnyObjectByType <CubeMove>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case ZombieState.Idle:

                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("isWalking", true);
                }

                break;

            case ZombieState.Attack:


                break;


            case ZombieState.Follow:
                transform.LookAt(player.transform.position);
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                break;
        }
    }
}


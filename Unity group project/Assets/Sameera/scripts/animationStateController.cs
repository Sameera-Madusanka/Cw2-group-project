using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int leftWalkingHash;
    int rightWalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        leftWalkingHash = Animator.StringToHash("leftWalking");
        rightWalkingHash = Animator.StringToHash("rightWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        //if player presses w key
        if (!isWalking && forwardPressed) 
        {
            //then set the isWalking boolean to be true
            animator.SetBool(isWalkingHash,true);
        
        }
        if (isWalking && !forwardPressed)
        {
            //then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        }


        bool leftWalking = animator.GetBool(leftWalkingHash);
        bool leftPressed = Input.GetKey("a");
        //if player presses a key
        if (!leftWalking && leftPressed)
        {
            //then set the isWalking boolean to be true
            animator.SetBool(leftWalkingHash, true);

        }
        if (leftWalking && !leftPressed)
        {
            //then set the isWalking boolean to be false
            animator.SetBool(leftWalkingHash, false);
        }

        bool rightWalking = animator.GetBool(rightWalkingHash);
        bool rightPressed = Input.GetKey("d");
        //if player presses d key
        if (!rightWalking && rightPressed)
        {
            //then set the isWalking boolean to be true
            animator.SetBool(rightWalkingHash, true);

        }
        if (rightWalking && !rightPressed)
        {
            //then set the isWalking boolean to be false
            animator.SetBool(rightWalkingHash, false);
        }

        /*
        bool backPressed = Input.GetKey("s");
        //if player presses d key
        if (!isWalking && backPressed)
        {
            //then set the isWalking boolean to be true
            animator.SetBool(isWalkingHash, true);

        }
        if (isWalking && !backPressed)
        {
            //then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        } */

    }
}

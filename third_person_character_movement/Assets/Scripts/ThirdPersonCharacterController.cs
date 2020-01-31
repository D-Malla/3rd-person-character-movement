using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float speed;


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(horizontalMove, 0f, verticalMove) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}

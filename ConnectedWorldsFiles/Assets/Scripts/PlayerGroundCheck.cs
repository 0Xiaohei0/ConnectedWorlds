﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private string whatIsGround = "WalkableSurface";
    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(whatIsGround))
        {
            playerMovement.grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(whatIsGround))
        {
            playerMovement.grounded = false;
        }
    }
}

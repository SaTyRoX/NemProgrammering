using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupUnlock : MonoBehaviour
{

    public GameObject WhatToUnlock;
    public AudioClip PickUpAudioClip;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {
            
            AudioSource.PlayClipAtPoint(PickUpAudioClip, transform.position);
            Destroy(WhatToUnlock);
            Destroy(gameObject);
        }
    }

}

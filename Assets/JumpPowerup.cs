using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    public float JumpPowerDuration = 3;
    public float JumpPowerAmount = 500;

    public AudioClip PickUpAudioClip;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            collision.GetComponent<PlayerMovement>().JumpPowerUp(JumpPowerDuration, JumpPowerAmount);
            AudioSource.PlayClipAtPoint(PickUpAudioClip, transform.position);
            Destroy(gameObject);
        }
    }

}

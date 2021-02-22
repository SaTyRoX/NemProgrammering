using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float Speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
        
    }

    void Shoot () {
        GameObject spawn = Instantiate(bulletPrefab) as GameObject;
        spawn.transform.position = FirePoint.transform.position;
        spawn.GetComponent<Rigidbody2D>().velocity = FirePoint.transform.right * Speed;
    }

}

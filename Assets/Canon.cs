using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject SpawnPoint;
    public GameObject BulletPrefab;
    public float ShootIntervalMin;
    public float ShootIntervalMax;

    public float Speed = 10;

    IEnumerator Start() {

        GameObject spawn = Instantiate(BulletPrefab) as GameObject;
        spawn.transform.position = SpawnPoint.transform.position;

        spawn.GetComponent<Rigidbody2D>() .velocity = SpawnPoint.transform.right * Speed;

        Destroy(spawn, 3);
        spawn.transform.localScale *= Random.Range(1, 3);

    

        yield return new WaitForSeconds(Random.Range(ShootIntervalMin, ShootIntervalMax));

        StartCoroutine(Start());

    }


}

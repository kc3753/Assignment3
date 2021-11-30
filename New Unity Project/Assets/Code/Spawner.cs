using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int spawntimer;
    public Transform spawnPos;
    float currTime = 0;
    void spawn(){

        GameObject newbullet = Instantiate(bulletPrefab, spawnPos.position, Quaternion.identity);
    }
    

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime >= spawntimer){
            spawn();
            currTime = 0;
        }
    }
}

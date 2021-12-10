using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSkateboard : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int spawntimer;
    public Transform spawnPos;
    float currTime = 0;
    void spawn(){

        GameObject newbullet = Instantiate(bulletPrefab, spawnPos.position, Quaternion.identity);
        newbullet.transform.Rotate (new Vector3(0 , 45, 0));
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

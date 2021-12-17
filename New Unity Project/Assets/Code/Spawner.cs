using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public float spawntimer;
    public Transform spawnPos;

    public enum Dir { left, right };
    float currTime = 0;

    public Dir direction;
    void spawn()
    {
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);

        int prefabIndex = UnityEngine.Random.Range(0, 3);
        GameObject newVehicle = Instantiate(prefabList[prefabIndex], spawnPos.position, Quaternion.identity);
        if (direction == Dir.left)
        {
            print("Debug");
            newVehicle.transform.Rotate(0, 180, 0);
        }
        //newbullet.transform.Rotate (new Vector3(0 , 45, 0));
    }


    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime >= spawntimer)
        {
            spawn();
            currTime = 0;
        }
    }
}

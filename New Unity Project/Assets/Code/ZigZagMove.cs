using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagMove : MonoBehaviour
{
    //Rigidbody _rigidbody;
    public float m_Speed = 5f;
    int timeCount = 0;
    //int rSpeed = 2;
    bool right = false;

    void Update () {
        timeCount += 1;
        if (timeCount % 80 == 0){
            right = true;
        }
        else if(timeCount % 40 == 0){
            right = false;
        }

        if(right == true){
            transform.Translate(Vector3.left * m_Speed * Time.deltaTime);
        }
        else {
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        }
        Destroy(gameObject, 18); 
    }
}

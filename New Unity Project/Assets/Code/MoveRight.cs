using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float m_Speed = 5f;

    void Start(){
        _rigidbody= GetComponent<Rigidbody>();
    }

    void Update () {
        transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        Destroy(gameObject, 10); 
    }
}

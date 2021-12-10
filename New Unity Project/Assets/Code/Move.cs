using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidbody;
    //public float m_Speed = 5f;
    // float m_Speed = Random.Range(2.0f, 6.0f);
    void Start(){
        _rigidbody= GetComponent<Rigidbody>();
        // _rigidbody.AddForce(new Vector3(_rigidbody.velocity.x , _rigidbody.velocity.y, -100.0f));
    }

    void Update () {
        transform.Translate(Vector3.back * Random.Range(2.0f, 5.0f) * Time.deltaTime);
        Destroy(gameObject, 15); 
    }
}

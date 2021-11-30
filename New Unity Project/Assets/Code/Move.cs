using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidbody;
    void Start(){
        _rigidbody= GetComponent<Rigidbody>();
        _rigidbody.AddForce(new Vector3(_rigidbody.velocity.x , _rigidbody.velocity.y, -100.0f));
    }

    void FixedUpdate () {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float pspeed = 1f;
    public Joystick joystick;
    public

    void Start(){
        _rigidbody= GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        float hor = joystick.Horizontal;
        float ver = joystick.Vertical;
        _rigidbody.velocity = new Vector3(-ver,0,hor).normalized * pspeed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}

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
        Vector3 vec = new Vector3(-ver,0,hor).normalized * pspeed;
        double zlocation = _rigidbody.position.z;

        //print(zlocation);
        if(zlocation > 25){
            if(vec.z > 0){
                vec.z = 0;
            }
        }
        if(zlocation < -25){
            if(vec.z < 0){
                vec.z = 0;
            }
        }
        _rigidbody.velocity =vec;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (other.gameObject.CompareTag("Timer"))
        {
                Destroy(other.gameObject);
                PublicVars.countdownTime += 10;
        }
        if (other.gameObject.CompareTag("MinusTimer"))
        {
                Destroy(other.gameObject);
                PublicVars.countdownTime -= 10;
        }
    }
}

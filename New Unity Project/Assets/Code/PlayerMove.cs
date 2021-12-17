using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Rigidbody _rigidbody;
    Transform t;
    public float pspeed = 1f;
    public Joystick joystick;
    public GameObject LoseGameUI;
    public AudioClip Crash;
    public AudioClip Train;
    public AudioClip BGM;
    float speed = 0f;
    public bool crashsound;
    public bool trainsound;
    AudioSource audioSource;
    public Animator _animator;

    public GameObject completeLevelUI;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        t = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
        crashsound = false;
        trainsound = false;
        audioSource.clip = BGM;
        audioSource.Play();
    }

    private void Update()
    {
        float hor = joystick.Horizontal;
        float ver = joystick.Vertical;
        Vector3 vec = new Vector3(-ver, 0, hor).normalized * pspeed;
        speed = (hor * hor + ver * ver);
        _animator.SetFloat("speed", speed);
        if (hor != 0 || ver != 0)
        {
            t.forward = vec;
        }
        double zlocation = _rigidbody.position.z;

        if (zlocation > 25)
        {
            if (vec.z > 0)
            {
                vec.z = 0;
            }
        }
        if (zlocation < -25)
        {
            if (vec.z < 0)
            {
                vec.z = 0;
            }
        }
        _rigidbody.velocity = vec;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            if (!crashsound)
            {
                audioSource.PlayOneShot(Crash);
                crashsound = true;
            }

            LoseGameUI.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Train"))
        {
            if (!trainsound)
            {
                audioSource.PlayOneShot(Train);
                trainsound = true;
            }

            LoseGameUI.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Timer"))
        {
            Destroy(other.gameObject);
            PublicVars.countdownTime += 10;
        }
        else if (other.gameObject.CompareTag("MinusTimer"))
        {
            Destroy(other.gameObject);
            PublicVars.countdownTime -= 10;
        }
        else if (other.CompareTag("LevelGate"))
        {
            completeLevelUI.SetActive(true);
            new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

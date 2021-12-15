using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject completeLevelUI;
    void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            completeLevelUI.SetActive(true);
            new WaitForSeconds(5);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}

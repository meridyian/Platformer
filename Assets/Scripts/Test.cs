using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false;

    private void Start()
    {
        Debug.Log("sdsds");
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("xssss");
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            levelCompleted = true;
            Debug.Log("x");
            Invoke("CompleteLevel", 2f);

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

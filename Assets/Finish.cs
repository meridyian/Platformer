using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //since it will be the only audiosource on finishobject no need to use serialize

    private AudioSource finishSound;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            finishSound.Play();
            CompleteLevel();
        }
    }

    private void CompleteLevel()
    {

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    //check if the player is touching to the platform
    //if so parent it to player


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //parent platform to player
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //for leaving
        if (collision.gameObject.name == "Player")
        {
            //parent platform to player
            collision.gameObject.transform.SetParent(null);
        }
    }
}
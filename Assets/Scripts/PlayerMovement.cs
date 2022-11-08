using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //jump during the game
        if (Input.GetKey("space"))
        {
            // to access, only jump
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 7, 0);
        }
    }
}

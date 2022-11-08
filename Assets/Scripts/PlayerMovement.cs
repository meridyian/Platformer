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
        //jump during the game but dont when you pressed down
        if (Input.GetKeyDown("space"))
        {
            // to access, only jump
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
        }
    }
}

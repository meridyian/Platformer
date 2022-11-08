using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    private void Start()
    {
        //execute your rb at start of the game
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        // directional variable range(-1,1)
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        

        //jump during the game but dont when you pressed down with input manager
        if (Input.GetButtonDown("Jump"))
        {
            // to access, only jump
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }
    }
}

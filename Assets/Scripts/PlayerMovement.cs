using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private float dirX = 0f;
    // to make it somehow public 
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;


    //created a variable with datatype that you created, finite set of values for states
    private enum MovementState {idle, running, jumping, falling};


    // Start is called before the first frame update
    private void Start()
    {
        //execute your rb at start of the game
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        // directional variable range(-1,1)
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //jump during the game but dont when you pressed down with input manager
        if (Input.GetButtonDown("Jump"))
        {
            // to access, only jump
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {

        MovementState state;

        //enable/disable running animation
        // else if- else
        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            //sprite renderer has an ability to change the direction
            state = MovementState.running;
            sprite.flipX = true;

        }
        else
        {
            state = MovementState.idle;
        }

        // since you dont want to see idle or running animation whiile you are in the air
        // seconda part to exacute
        // check if you are jumping
        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < .1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);


    }
}

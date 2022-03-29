using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll2d;
    private Animator anim;
    private SpriteRenderer sprite;

    [SerializeField] private LayerMask jumpableground;

    private enum PlayerState {idle, running, jumping, falling}
   
    [SerializeField] private float movementspeed = 10f;
    [SerializeField] private float jumpforce = 10f;
    private float dirx = 0f;
    
  
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll2d = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * movementspeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        PlayerState state;

        if (dirx > 0f)
        {
            state = PlayerState.running;
            sprite.flipX = false ;
        }
        else if (dirx < 0f)
        {
            state = PlayerState.running;
            sprite.flipX = true;
        }
        else
        {
            state = PlayerState.idle;
        }


        if (rb.velocity.y > .1f)
        {
            state = PlayerState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = PlayerState.falling;
        }
 
        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll2d.bounds.center, coll2d.bounds.size, 0f, Vector2.down, .1f, jumpableground);
    }
}

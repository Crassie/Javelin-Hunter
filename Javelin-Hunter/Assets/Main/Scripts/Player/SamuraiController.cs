using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SamuraiController : MonoBehaviour
{
    // General
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector3 xScale;

    // Animation
    float animationValue;
    public Animator animator;   

    Vector2 movement;

    void Start()
    {
        xScale = transform.localScale;
    }

    void Update()
    {        
        animator.SetFloat("run", animationValue);
        animValue();
        CharacterMove();
        CharMoveFlip();
        CharacterSpriteFlip();        
    }    

    void FixedUpdate()
    {
        // use the movement gained from inputs to add to our current position making the player move
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);    
    }

    void CharMoveFlip()
    {           
        if ((Input.GetAxis("Horizontal")) > 0)
        {
            xScale.x = 5;
        }
        if ((Input.GetAxis("Horizontal")) < 0)
        {
            xScale.x = -5;
        }
        transform.localScale = xScale;
    }

    void CharacterMove()
    {
        // UP DOWN LEFT RIGHT input recievers
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");        
    }

    void CharacterSpriteFlip()
    {
        // Find mouse position and transform it into the world position
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // And compare it with the needed "middle" point then flip if it is needed
        // Here the player is the "middle"
        if (mousePos.x < transform.position.x)
        {
            xScale.x = -5;
        }
        else
        if (mousePos.x > transform.position.x)
        {
            xScale.x = 5;
        }
    }

    void animValue() // Player Movement Animation
    {
        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
        {
            animationValue = Mathf.Abs(movement.x);            
        }
        else
        {
            animationValue = Mathf.Abs(movement.y);
        }
    }
}

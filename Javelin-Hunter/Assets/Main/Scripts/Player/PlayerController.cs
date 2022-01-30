using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{   

    public Animator animator;

    public float speed = 5f;
    public Rigidbody2D rb;
    float Value;

    Vector2 movement;

    void Update()
    {             
        // UP DOWN LEFT RIGHT input recievers
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animValue();

        animator.SetFloat("speed", Value);
    }


    void FixedUpdate()
    {
        // use the movement gained from inputs to add to our current position making the player move
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        // Rotate towards the mouse
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle -90, Vector3.forward);
        
    }
    
    void animValue() // Player Movement Animation
    {
        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
        {
            Value = Mathf.Abs(movement.x);
        }
        else
        {
            Value = Mathf.Abs(movement.y);
        }
    }      
}

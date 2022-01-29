using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public GameObject player;
    Transform playerTransform;
    public float bulletSpeed = 50f;
    Rigidbody2D rb;    

    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
        //ChangePos();
        rb = GetComponent<Rigidbody2D>();        
    }

    void Update() // Move
    {
        rb.AddForce(transform.up * bulletSpeed);
        Destroy(gameObject, 5f);
    }

    void ChangePos()
    {
        transform.Translate(new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z));
    }
}

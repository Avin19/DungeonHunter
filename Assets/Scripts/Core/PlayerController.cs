using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed =20f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    
    private void Movement()
    {
        float dirX =  Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        Vector2 moveDir = new Vector2(dirX,dirY);
        rb.MovePosition(rb.position+moveDir*speed*Time.fixedDeltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator _animator;

    [Header("Movement related")]
    public float GravityScaleOnFall;
    public Vector2 direction;
    public float walkingSpeed;
   
    //attribute
    [Header("Jump related")]
    public bool isJumping = false;
    public byte currentJumpCount = 0;
    public int jumpPower = 1000;
    public byte MaxJumpCount = 3;

    private void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), transform.position.y);

        if (Input.GetButtonDown("Fire1"))
        {
            if(currentJumpCount < MaxJumpCount) isJumping = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //bon par rapport au Game Design
        if (rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = GravityScaleOnFall;
            _animator.SetBool("Falling?", true);
        }
        else
        {
            //je touche le sol ?
            rb2d.gravityScale = 1;
            _animator.SetBool("Falling?", false);
        }

        if (isJumping)
        {
            //on saute effectivement
            currentJumpCount++;
            rb2d.AddForce(Vector2.up * jumpPower);
            isJumping = false;
        }


        direction.x *= walkingSpeed * Time.deltaTime;
        //direction est le nouveau vecteur vitesse
        direction.y = rb2d.velocity.y;
        rb2d.velocity = direction;
    }

}

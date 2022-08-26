using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{

    //par ici po

    public Rigidbody2D rb2d;
    public float GravityScaleOnFall;
    public Animator _animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        //bon par rapport au Game Design
        if (rb2d.velocity.y < -1)
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
    }


}

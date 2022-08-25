using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityMovement : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float GravityScaleOnFall;

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.y < 0)
        {
            rb2d.gravityScale = GravityScaleOnFall;
        }
        else
        {
            rb2d.gravityScale = 1;
        }
    }
}

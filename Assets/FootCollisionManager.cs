using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootCollisionManager : MonoBehaviour
{
    public VelocityMovement _vm;
     
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Floor"))
        {
            Debug.Log("contact avec un tag Floor");
            _vm.currentJumpCount = 0;
            //mettre à 0 la vitesse en y ?
        }
    }
}

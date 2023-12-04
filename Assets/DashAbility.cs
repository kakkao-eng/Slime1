using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DashAbility : Ability
{ 
    public float dashVelocity;

    public override void Activate(GameObject parent)
    {
        PlayerMovements movement = parent.GetComponent<PlayerMovements>();
        movement.Sp = dashVelocity;
    }

    public override void BeginCooldown(GameObject parent)
    {
        PlayerMovements movement = parent.GetComponent<PlayerMovements>();
        movement.Sp = movement.speed;
      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Sphere : Unit
{
    private void Update()
    {
        MovementSpeed();
    }
    public override void MovementSpeed()
    {
        movementSpeed = 200;
    }


}
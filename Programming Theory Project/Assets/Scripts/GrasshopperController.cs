using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrasshopperController : AnimalController //INHERITANCE
{
    private float jumpdir;
protected override void Jump() //POLYMORPHISM
    {
        if (movingRight)
        {
            jumpdir = 0.25f;
        }
        else
        {
            jumpdir = -0.25f;
        }
        animalRb.AddForce(new Vector2(jumpdir, 1) * jumpForce, ForceMode2D.Impulse);
    }
}

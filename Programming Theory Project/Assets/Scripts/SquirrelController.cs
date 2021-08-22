using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelController : AnimalController //INHERITANCE
{
    protected override void Jump() //POLYMORPHISM
    {
        animalRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
